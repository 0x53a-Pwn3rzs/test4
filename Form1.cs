using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Data.Sqlite;
using System.Net.Http.Headers;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public class Settings
        {
            public string Google_CSE_Api_Key { get; set; }
            public string Google_CSE_ID { get; set; }
            public string Subfinder_Location { get; set; }
            public string Acunetix_Api_URL { get; set; }
            public string Acunetix_Api_Key { get; set; }
        }

        private static readonly HttpClient httpClient = new HttpClient();
        private Dictionary<string, string> countryCodes = new Dictionary<string, string>();
        private Dictionary<string, string> languageCodes = new Dictionary<string, string>();
        private int totalResults = 0;
        private int processedDomainsCount = 0;
        private static int ResultsPerRequest = 10;
        private string whitelistDbPath = "Data Source=AcunetixHelperSoft_Local_Database.sqlite";
        private string blacklistDbPath = "Data Source=Blacklist.sqlite";
        private bool scanProfilesLoaded = false;

        public Form1()

        {
            InitializeComponent();

            // Attach the DropDown event handler to the Scan Profiles ComboBox
            Acunetix_Importer_Scan_Profiles_ComboBox.DropDown += Acunetix_Importer_Scan_Profiles_ComboBox_DropDown;

            try
            {
                using (var conn = new SqliteConnection(whitelistDbPath))
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS WhitelistDomains(Domain TEXT);";
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT Domain FROM WhitelistDomains;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Local_Database_Whitelist_CheckedListBox.Items.Add(reader.GetString(0));
                        }
                    }
                    conn.Close();
                }

                using (var conn = new SqliteConnection(blacklistDbPath))
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = "CREATE TABLE IF NOT EXISTS BlacklistDomains(Domain TEXT);";
                    command.ExecuteNonQuery();
                    command.CommandText = "SELECT Domain FROM BlacklistDomains;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Local_Database_Blacklist_CheckedListBox.Items.Add(reader.GetString(0));
                        }
                    }
                    conn.Close();
                }

                // Add the code block here
                using (var conn = new SqliteConnection(blacklistDbPath))
                {
                    conn.Open();
                    var command = conn.CreateCommand();
                    command.CommandText = "SELECT Domain FROM BlacklistDomains;";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Local_Database_Blacklist_CheckedListBox.Items.Add(reader.GetString(0));
                        }
                    }
                    conn.Close();
                }

                Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Click += Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetEventHandlers();
            InitializeCodes();
            InitializeComboBoxes();
            LoadSettings();
            SaveSettings();

            // Call the methods to initially populate the CheckListBox controls
            UpdateWhitelistCheckListBox();
            UpdateBlacklistCheckListBox();
        }

        private void LoadSettings()
        {
            try
            {
                string json = File.ReadAllText("settings.json");
                Settings settings = JsonConvert.DeserializeObject<Settings>(json);

                Settings_CSE_Apikey_MaskedTextBox.Text = settings.Google_CSE_Api_Key;
                Settings_CSE_ID_MaskedTextBox.Text = settings.Google_CSE_ID;
                Settings_Subfinder_Location_MaskedTextBox.Text = settings.Subfinder_Location;
                Settings_Acunetix_Api_URL_MaskedTextBox.Text = settings.Acunetix_Api_URL;
                Settings_Acunetix_Api_Key_MaskedTextBox.Text = settings.Acunetix_Api_Key;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSettings()
        {
            try
            {
                Settings settings = new Settings
                {
                    Google_CSE_Api_Key = Settings_CSE_Apikey_MaskedTextBox.Text,
                    Google_CSE_ID = Settings_CSE_ID_MaskedTextBox.Text,
                    Subfinder_Location = Settings_Subfinder_Location_MaskedTextBox.Text,
                    Acunetix_Api_URL = Settings_Acunetix_Api_URL_MaskedTextBox.Text,
                    Acunetix_Api_Key = Settings_Acunetix_Api_Key_MaskedTextBox.Text
                };

                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText("settings.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private async Task<List<string>> GetScanConfigurations(string apiUrl, string apiKey)
        {
            List<string> scanConfigurations = new List<string>();

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-Auth", apiKey);

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl + "/api/v1/scanning_profiles");
                    if (response.IsSuccessStatusCode)
                    {
                        byte[] contentBytes = await response.Content.ReadAsByteArrayAsync();
                        string content = Encoding.UTF8.GetString(contentBytes);

                        JObject responseJson = JObject.Parse(content);
                        JArray profiles = (JArray)responseJson["scanning_profiles"];

                        foreach (var profile in profiles)
                        {
                            string name = (string)profile["name"];
                            scanConfigurations.Add(name);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve scanning profiles from the Acunetix API. Status code: " + response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving scanning profiles from the Acunetix API: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return scanConfigurations;
        }


        private async void Acunetix_Importer_Scan_Profiles_ComboBox_DropDown(object sender, EventArgs e)
        {
            if (!scanProfilesLoaded)
            {
                string apiUrl = Settings_Acunetix_Api_URL_MaskedTextBox.Text;
                string apiKey = Settings_Acunetix_Api_Key_MaskedTextBox.Text;

                List<string> scanConfigurations = await GetScanConfigurations(apiUrl, apiKey);

                Acunetix_Importer_Scan_Profiles_ComboBox.Items.Clear();
                Acunetix_Importer_Scan_Profiles_ComboBox.Items.AddRange(scanConfigurations.ToArray());

                scanProfilesLoaded = true;
            }
        }

        public class CustomMessageHandler : DelegatingHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                var response = await base.SendAsync(request, cancellationToken);

                if (response.Content?.Headers?.ContentType?.CharSet == "utf8")
                {
                    response.Content.Headers.ContentType.CharSet = "utf-8";
                }

                return response;
            }
        }

        private async Task<List<string>> AddTargetsToAcunetix(List<string> targets, string apiUrl, string apiKey)
        {
            List<string> targetUuids = new List<string>();

            using (HttpClient httpClient = new HttpClient(new CustomMessageHandler { InnerHandler = new HttpClientHandler() }))
            {
                httpClient.DefaultRequestHeaders.Add("X-Auth", apiKey);

                try
                {
                    foreach (string target in targets)
                    {
                        var payload = new
                        {
                            targets = new[]
                            {
                        new
                        {
                            address = target.Trim(),
                            description = ""
                        }
                    },
                            groups = new string[] { }
                        };

                        HttpResponseMessage response = await httpClient.PostAsJsonAsync($"{apiUrl}/api/v1/targets/add", payload);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();
                            dynamic responseObject = JsonConvert.DeserializeObject(responseContent);
                            string targetUuid = responseObject.targets[0].target_id;

                            targetUuids.Add(targetUuid);
                        }
                        else
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();

                            // Copy response content to clipboard
                            Clipboard.SetText(responseContent);

                            MessageBox.Show($"Failed to add target '{target}' to Acunetix. Status code: {response.StatusCode}. Response content has been copied to clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while adding targets to Acunetix: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return targetUuids;
        }

        private async Task<bool> StartScansForTargets(List<string> targets, string scanProfile, string apiUrl, string apiKey)
        {
            bool success = true;

            using (HttpClient httpClient = new HttpClient(new CustomMessageHandler { InnerHandler = new HttpClientHandler() }))

            {
                httpClient.DefaultRequestHeaders.Add("X-Auth", apiKey);

                try
                {
                    foreach (string target in targets)
                    {
                        var payload = new
                        {
                            profile_id = scanProfile,
                            incremental = false,
                            schedule = new
                            {
                                disable = false,
                                start_date = (DateTime?)null,
                                time_sensitive = false
                            },
                            target_id = target
                        };

                        HttpResponseMessage response = await httpClient.PostAsJsonAsync($"{apiUrl}/api/v1/scans", payload);

                        if (!response.IsSuccessStatusCode)
                        {
                            success = false;
                            MessageBox.Show($"Failed to start scan for target '{target}' in Acunetix. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    success = false;
                    MessageBox.Show("An error occurred while starting scans in Acunetix: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return success;
        }



        // Place the UpdateWhitelistCheckListBox method here
        private void UpdateWhitelistCheckListBox()
        {
            Local_Database_Whitelist_CheckedListBox.Items.Clear(); // Clear existing items

            using (var conn = new SqliteConnection(whitelistDbPath))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "SELECT Domain FROM WhitelistDomains;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Local_Database_Whitelist_CheckedListBox.Items.Add(reader.GetString(0));
                    }
                }

                conn.Close();
            }
        }

        // Place the UpdateBlacklistCheckListBox method here
        private void UpdateBlacklistCheckListBox()
        {
            Local_Database_Blacklist_CheckedListBox.Items.Clear(); // Clear existing items

            using (var conn = new SqliteConnection(blacklistDbPath))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "SELECT Domain FROM BlacklistDomains;";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Local_Database_Blacklist_CheckedListBox.Items.Add(reader.GetString(0));
                    }
                }

                conn.Close();
            }
        }

        private void SetEventHandlers()
        {
            // Attach the event handlers
            Google_CSE_Scraper_Keywords_RichTextBox.TextChanged += Keywords_richTextBox_TextChanged;
            Google_CSE_Scraper_Export_To_Subfinder_Button.Click += Export_to_subfinder_button_Click;
            Google_CSE_Scraper_Clear_Results_Button.Click += Google_cse_scraper_clear_results_button_Click;
            Subfinder_Module_Clear_Subfinder_Domains_Button.Click += Subfinder_Module_Clear_Subfinder_Domains_Button_Click;
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Click += Subfinder_Module_Delete_gov_mil_arpa_Domains_Button_Click;
        }

        private void InitializeCodes()
        {
            // Initialize country codes
            countryCodes.Add("Belgium", "countryBE");
            countryCodes.Add("Canada", "countryCA");
            countryCodes.Add("China", "countryCN");
            countryCodes.Add("Denmark", "countryDK");
            countryCodes.Add("European Union", "countryEU");
            countryCodes.Add("France", "countryFR");
            countryCodes.Add("Germany", "countryDE");
            countryCodes.Add("India", "countryIN");
            countryCodes.Add("Italy", "countryIT");
            countryCodes.Add("Netherlands", "countryNL");
            countryCodes.Add("Poland", "countryPL");
            countryCodes.Add("Russia", "countryRU");
            countryCodes.Add("Spain", "countryES");
            countryCodes.Add("Switzerland", "countryCH");
            countryCodes.Add("Turkey", "countryTR");
            countryCodes.Add("Ukraine", "countryUA");
            countryCodes.Add("United Kingdom", "countryUK");
            countryCodes.Add("United States", "countryUS");

            // Initialize language codes
            languageCodes.Add("Arabic", "lang_ar");
            languageCodes.Add("Bulgarian", "lang_bg");
            languageCodes.Add("Catalan", "lang_ca");
            languageCodes.Add("Chinese (Simplified)", "lang_zh-CN");
            languageCodes.Add("Chinese (Traditional)", "lang_zh-TW");
            languageCodes.Add("Croatian", "lang_hr");
            languageCodes.Add("Czech", "lang_cs");
            languageCodes.Add("Danish", "lang_da");
            languageCodes.Add("Dutch", "lang_nl");
            languageCodes.Add("English", "lang_en");
            languageCodes.Add("Estonian", "lang_et");
            languageCodes.Add("Finnish", "lang_fi");
            languageCodes.Add("French", "lang_fr");
            languageCodes.Add("German", "lang_de");
            languageCodes.Add("Greek", "lang_el");
            languageCodes.Add("Hebrew", "lang_iw");
            languageCodes.Add("Hungarian", "lang_hu");
            languageCodes.Add("Icelandic", "lang_is");
            languageCodes.Add("Indonesian", "lang_id");
            languageCodes.Add("Italian", "lang_it");
            languageCodes.Add("Japanese", "lang_ja");
            languageCodes.Add("Korean", "lang_ko");
            languageCodes.Add("Latvian", "lang_lv");
            languageCodes.Add("Lithuanian", "lang_lt");
            languageCodes.Add("Norwegian", "lang_no");
            languageCodes.Add("Polish", "lang_pl");
            languageCodes.Add("Portuguese", "lang_pt");
            languageCodes.Add("Romanian", "lang_ro");
            languageCodes.Add("Russian", "lang_ru");
            languageCodes.Add("Serbian", "lang_sr");
            languageCodes.Add("Slovak", "lang_sk");
            languageCodes.Add("Slovenian", "lang_sl");
            languageCodes.Add("Spanish", "lang_es");
            languageCodes.Add("Swedish", "lang_sv");
            languageCodes.Add("Turkish", "lang_tr");
        }

        private void InitializeComboBoxes()
        {
            // Fill ComboBoxes with country and language names
            foreach (var country in countryCodes.Keys)
            {
                Google_CSE_Scraper__Settings_Country_ComboBox.Items.Add(country);
            }
            foreach (var language in languageCodes.Keys)
            {
                Google_CSE_Scraper_Settings_Language_ComboBox.Items.Add(language);
            }
            // Set default values
            Google_CSE_Scraper__Settings_Country_ComboBox.SelectedItem = "United States";
            Google_CSE_Scraper_Settings_Language_ComboBox.SelectedItem = "English";
        }

        private async void Start_cse_search_button_Click(object sender, EventArgs e)
        {
            var keywords = Google_CSE_Scraper_Keywords_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            // Clear the checkedListBox and reset the totalResults counter before the loop
            Google_CSE_Scraper_Results_CheckedListBox.Items.Clear();
            totalResults = 0;

            foreach (var keyword in keywords)
            {
                await RunCseSearch(keyword);
                await Task.Delay(1000); // Wait for 1 second
            }
        }

        private async Task RunCseSearch(string keyword)
        {
            int resultsPerSearch = (int)Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Value;
            int requestsNeeded = (int)Math.Ceiling((double)resultsPerSearch / ResultsPerRequest);

            for (int i = 1; i <= requestsNeeded; i++)
            {
                await SendCseRequest(keyword, i * ResultsPerRequest);
                await Task.Delay(1000); // Wait for 1 second before the next request
            }
        }

        private async Task SendCseRequest(string keyword, int startIndex)
        {
            var country = countryCodes[Google_CSE_Scraper__Settings_Country_ComboBox.SelectedItem.ToString()];
            var language = languageCodes[Google_CSE_Scraper_Settings_Language_ComboBox.SelectedItem.ToString()];

            var apiKey = Settings_CSE_Apikey_MaskedTextBox.Text;
            var cseId = Settings_CSE_ID_MaskedTextBox.Text;

            string query = $"https://www.googleapis.com/customsearch/v1?key={apiKey}&cx={cseId}&q={keyword}&num={ResultsPerRequest}&start={startIndex}&cr={country}&lr={language}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    JObject googleSearch = JObject.Parse(content);
                    JArray items = (JArray)googleSearch["items"];

                    if (items != null)
                    {
                        foreach (var item in items)
                        {
                            string link = (string)item["link"];
                            Uri uri = new Uri(link);
                            Google_CSE_Scraper_Results_CheckedListBox.Items.Add(uri.Host);
                            totalResults++; // Increment the counter for each result
                        }
                    }
                }
                else if (response.StatusCode == (System.Net.HttpStatusCode)429)
                {
                    MessageBox.Show("Too Many Requests! You are being rate limited. Try slowing down your requests.");
                }
                else
                {
                    MessageBox.Show("Error!!1\nSomething is wrong.\nCheck your Settings, Dumbass!\nStatuscode of Response says: " + response.StatusCode.ToString());
                }
            }

            // Update the label at the end of each request
            Google_CSE_Scraper_Results_Label.Text = $"Total results: {totalResults}";
        }


        private void Clear_keywords_button_Click(object sender, EventArgs e)
        {
            Google_CSE_Scraper_Keywords_RichTextBox.Clear();
        }

        private void Keywords_richTextBox_TextChanged(object sender, EventArgs e)
        {
            var keywords = Google_CSE_Scraper_Keywords_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            Google_CSE_Scraper_Keywords_Label.Text = "Keywords: " + keywords.Length;
            Google_CSE_Scraper_Keywords_Label.Refresh(); // Force the label to update its display
        }

        private void Export_to_subfinder_button_Click(object sender, EventArgs e)
        {
            // Clear the richTextBox
            Subfinder_Module_Domains_RichTextBox.Clear();

            // Add each item from the checkedListBox to the richTextBox
            foreach (var item in Google_CSE_Scraper_Results_CheckedListBox.Items)
            {
                Subfinder_Module_Domains_RichTextBox.AppendText(item.ToString() + "\n");
            }
        }

        private void Google_cse_scraper_clear_results_button_Click(object sender, EventArgs e)
        {
            // Clear the checkedListBox and reset the totalResults counter
            Google_CSE_Scraper_Results_CheckedListBox.Items.Clear();
            totalResults = 0;

            // Update the label to show that there are no results
            Google_CSE_Scraper_Results_Label.Text = "Total results: 0";
        }

        private async void Start_Subfinder_Enumeration_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Enabled = false;
            var threads = (int)Subfinder_Module_Threads_NumericUpDown.Value;
            var subfinderLocation = Settings_Subfinder_Location_MaskedTextBox.Text;
            var domains = Subfinder_Module_Domains_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var totalCount = domains.Length;
            List<Task> runningTasks = new List<Task>();
            processedDomainsCount = 0;

            // Added the line here
            UpdateDomainCount();

            for (int i = 0; i < domains.Length; i++)
            {
                if (runningTasks.Count >= threads)
                {
                    var completedTask = await Task.WhenAny(runningTasks);
                    runningTasks.Remove(completedTask);
                }

                var subfinderTask = RunSubfinder(subfinderLocation, domains[i], totalCount);
                runningTasks.Add(subfinderTask);
            }

            await Task.WhenAll(runningTasks);
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Enabled = true;
        }

        private async Task RunSubfinder(string subfinderLocation, string domain, int totalCount)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = subfinderLocation,
                    Arguments = $"-d {domain} -silent -active",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                var process = new Process { StartInfo = startInfo };
                process.Start();

                // Create a StreamReader for the output
                using (var reader = process.StandardOutput)
                {
                    // Read line by line
                    string line;
                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            Subfinder_Module_Domain_Results_CheckedListBox.Items.Add(line);
                            UpdateSubdomainsCount();
                        });
                    }
                }

                // Wait for the process to exit
                await Task.Run(() => process.WaitForExit());

                // Update the processedDomainsCount and the label
                this.Invoke((MethodInvoker)delegate
                {
                    // Use Interlocked.Increment to safely increment the counter
                    Interlocked.Increment(ref processedDomainsCount);
                    Subfinder_Module_Domains_Processed_Label.Text = $"Domains processed: {processedDomainsCount}/{totalCount}";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while running the subfinder process: {ex.Message}");
            }
        }


        private void Subfinder_Module_Clear_Subfinder_Domains_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Domains_RichTextBox.Clear();
            UpdateDomainCount();
        }

        private void Subfinder_Module_Delete_gov_mil_arpa_Domains_Button_Click(object sender, EventArgs e)
        {
            var lines = Subfinder_Module_Domains_RichTextBox.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var filteredLines = lines.Where(line => !line.EndsWith(".gov") && !line.EndsWith(".mil") && !line.EndsWith(".arpa"));
            Subfinder_Module_Domains_RichTextBox.Text = string.Join("\n", filteredLines);
            UpdateDomainCount();
        }
        private void UpdateDomainCount()
        {
            var domainCount = Subfinder_Module_Domains_RichTextBox.Lines.Length;
            Subfinder_Module_Domains_Label.Text = $"Domains: {domainCount}";
        }

        private void UpdateSubdomainsCount()
        {
            int subdomainsCount = Subfinder_Module_Domain_Results_CheckedListBox.Items.Count;
            Subfinder_Module_Results_Label.Text = $"Subdomains: {subdomainsCount}";
        }

        private void Subfinder_Module_Clear_Subdomains_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Domain_Results_CheckedListBox.Items.Clear();
            UpdateSubdomainsCount();
        }

        private void Subfinder_Module_Delete_Selected_Subdomains_Button_Click(object sender, EventArgs e)
        {
            for (int i = Subfinder_Module_Domain_Results_CheckedListBox.CheckedItems.Count - 1; i >= 0; i--)
            {
                Subfinder_Module_Domain_Results_CheckedListBox.Items.Remove(Subfinder_Module_Domain_Results_CheckedListBox.CheckedItems[i]);
            }
            UpdateSubdomainsCount();
        }

        private void Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button_Click(object sender, EventArgs e)
        {
            UpdateWhitelistCheckListBox();
            try
            {
                using (var conn = new SqliteConnection(whitelistDbPath))
                using (var blacklistConn = new SqliteConnection(blacklistDbPath))
                {
                    conn.Open();
                    blacklistConn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        var command = conn.CreateCommand();
                        command.Transaction = transaction;

                        var blacklistCmd = new SqliteCommand() { Connection = blacklistConn };

                        foreach (string item in Subfinder_Module_Domain_Results_CheckedListBox.Items)
                        {
                            blacklistCmd.CommandText = "SELECT COUNT(*) FROM BlacklistDomains WHERE Domain = @Domain;";
                            blacklistCmd.Parameters.AddWithValue("@Domain", item);
                            long count = (long)blacklistCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // If domain is on the blacklist, do not add it to the whitelist
                                continue;
                            }

                            Local_Database_Whitelist_CheckedListBox.Items.Add(item);

                            command.CommandText = "INSERT INTO WhitelistDomains(Domain) VALUES(@Domain);";
                            command.Parameters.AddWithValue("@Domain", item);
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }

                    conn.Close();
                    blacklistConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button_Click(object sender, EventArgs e)
        {
            UpdateWhitelistCheckListBox();
            try
            {
                using (var conn = new SqliteConnection(whitelistDbPath))
                using (var blacklistConn = new SqliteConnection(blacklistDbPath))
                {
                    conn.Open();
                    blacklistConn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        var command = conn.CreateCommand();
                        command.Transaction = transaction;

                        var blacklistCmd = new SqliteCommand { Connection = blacklistConn };

                        foreach (var selectedDomain in Subfinder_Module_Domain_Results_CheckedListBox.CheckedItems)
                        {
                            var domain = selectedDomain.ToString();

                            // Check if domain is in the blacklist
                            blacklistCmd.CommandText = "SELECT COUNT(*) FROM BlacklistDomains WHERE Domain = @Domain;";
                            blacklistCmd.Parameters.AddWithValue("@Domain", domain);
                            long count = (long)blacklistCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // If domain is on the blacklist, skip it
                                continue;
                            }

                            // Check if domain is already in the whitelist
                            bool isDuplicate = Local_Database_Whitelist_CheckedListBox.Items.Contains(domain);

                            if (!isDuplicate)
                            {
                                // Add domain to whitelist
                                Local_Database_Whitelist_CheckedListBox.Items.Add(domain);

                                command.CommandText = "INSERT INTO WhitelistDomains(Domain) VALUES(@Domain);";
                                command.Parameters.AddWithValue("@Domain", domain);
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }

                    conn.Close();
                    blacklistConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Local_Database_Export_All_Websites_To_Acunetix_Importer_Button_Click(object sender, EventArgs e)
        {
            StringBuilder targetsBuilder = new StringBuilder();

            foreach (var website in Local_Database_Whitelist_CheckedListBox.Items)
            {
                targetsBuilder.AppendLine(website.ToString());
            }

            Acunetix_Importer_Targets_RichTextBox.Text = targetsBuilder.ToString();
        }

        private void Local_Database_Other_Options_Export_Selected_Websites_To_Acunetix_Importer_Button_Click(object sender, EventArgs e)
        {
            StringBuilder targetsBuilder = new StringBuilder();

            foreach (var selectedWebsite in Local_Database_Whitelist_CheckedListBox.CheckedItems)
            {
                targetsBuilder.AppendLine(selectedWebsite.ToString());
            }

            Acunetix_Importer_Targets_RichTextBox.Text = targetsBuilder.ToString();
        }

        private void Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button_Click(object sender, EventArgs e)
        {
            UpdateBlacklistCheckListBox();
            try
            {
                using (var whitelistConn = new SqliteConnection(whitelistDbPath))
                using (var blacklistConn = new SqliteConnection(blacklistDbPath))
                {
                    whitelistConn.Open();
                    blacklistConn.Open();

                    using (var whitelistTransaction = whitelistConn.BeginTransaction())
                    using (var blacklistTransaction = blacklistConn.BeginTransaction())
                    {
                        var whitelistCommand = whitelistConn.CreateCommand();
                        whitelistCommand.Transaction = whitelistTransaction;

                        var blacklistCommand = blacklistConn.CreateCommand();
                        blacklistCommand.Transaction = blacklistTransaction;

                        foreach (var selectedWebsite in Local_Database_Whitelist_CheckedListBox.CheckedItems)
                        {
                            var website = selectedWebsite.ToString();

                            // Remove website from whitelist
                            whitelistCommand.CommandText = "DELETE FROM WhitelistDomains WHERE Domain = @Domain;";
                            whitelistCommand.Parameters.AddWithValue("@Domain", website);
                            whitelistCommand.ExecuteNonQuery();

                            // Add website to blacklist if not already present
                            blacklistCommand.CommandText = "INSERT OR IGNORE INTO BlacklistDomains(Domain) VALUES(@Domain);";
                            blacklistCommand.Parameters.AddWithValue("@Domain", website);
                            blacklistCommand.ExecuteNonQuery();

                            // Add website to Local_Database_Blacklist_CheckedListBox
                            Local_Database_Blacklist_CheckedListBox.Items.Add(website);
                        }

                        whitelistTransaction.Commit();
                        blacklistTransaction.Commit();
                    }

                    whitelistConn.Close();
                    blacklistConn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Domains_RichTextBox.Clear();

            foreach (var selectedWebsite in Local_Database_Whitelist_CheckedListBox.CheckedItems)
            {
                Subfinder_Module_Domains_RichTextBox.AppendText(selectedWebsite.ToString() + "\n");
            }
        }

        private void Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button_Click(object sender, EventArgs e)
        {
            Subfinder_Module_Domains_RichTextBox.Clear();

            foreach (var website in Local_Database_Whitelist_CheckedListBox.Items)
            {
                Subfinder_Module_Domains_RichTextBox.AppendText(website.ToString() + "\n");
            }
        }

        private void Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button_Click(object sender, EventArgs e)
        {
            UpdateWhitelistCheckListBox();
            try
            {
                using (var conn = new SqliteConnection(whitelistDbPath))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        var command = conn.CreateCommand();
                        command.Transaction = transaction;

                        foreach (var selectedWebsite in Local_Database_Whitelist_CheckedListBox.CheckedItems)
                        {
                            var website = selectedWebsite.ToString();

                            // Remove website from the database
                            command.CommandText = "DELETE FROM WhitelistDomains WHERE Domain = @Domain;";
                            command.Parameters.AddWithValue("@Domain", website);
                            command.ExecuteNonQuery();

                            // Remove website from the checked list box
                            Local_Database_Whitelist_CheckedListBox.Items.Remove(selectedWebsite);
                        }

                        transaction.Commit();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Local_Database_Clear_Database_Button_Click(object sender, EventArgs e)
        {
            UpdateWhitelistCheckListBox();
            try
            {
                using (var conn = new SqliteConnection(whitelistDbPath))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        var command = conn.CreateCommand();
                        command.Transaction = transaction;

                        // Delete all entries from the database
                        command.CommandText = "DELETE FROM WhitelistDomains;";
                        command.ExecuteNonQuery();

                        // Clear the checked list box
                        Local_Database_Whitelist_CheckedListBox.Items.Clear();

                        transaction.Commit();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Local_Database_Clear_Blacklist_Button_Click(object sender, EventArgs e)
        {
            UpdateBlacklistCheckListBox();
            try
            {
                using (var conn = new SqliteConnection(blacklistDbPath))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        var command = conn.CreateCommand();
                        command.Transaction = transaction;

                        // Delete all entries from the blacklist
                        command.CommandText = "DELETE FROM BlacklistDomains;";
                        command.ExecuteNonQuery();

                        // Clear the checked list box
                        Local_Database_Blacklist_CheckedListBox.Items.Clear();

                        transaction.Commit();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Local_Database_Whitelist_CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWhitelistCheckListBox();
        }

        private void Settings_Save_Settings_Button_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private async void Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button_Click(object sender, EventArgs e)
        {
            List<string> targets = new List<string>();
            using (StringReader reader = new StringReader(Acunetix_Importer_Targets_RichTextBox.Text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    targets.Add(line.Trim());
                }
            }
            string scanProfile = Acunetix_Importer_Scan_Profiles_ComboBox.SelectedItem.ToString();
            string apiUrl = Settings_Acunetix_Api_URL_MaskedTextBox.Text;
            string apiKey = Settings_Acunetix_Api_Key_MaskedTextBox.Text;

            // Add targets to Acunetix
            List<string> addedTargets = await AddTargetsToAcunetix(targets, apiUrl, apiKey);
            if (addedTargets.Count > 0) // Check if targets were successfully added
            {
                // Start scans for the added targets with the selected scan profile
                bool startScansSuccess = await StartScansForTargets(addedTargets, scanProfile, apiUrl, apiKey);
                if (startScansSuccess)
                {
                    MessageBox.Show("Scans have been started in Acunetix for the specified targets.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to start scans in Acunetix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to add targets to Acunetix. Aborting scan start.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }//
}