using System;

namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new System.Windows.Forms.TabControl();
            Google_CSE_Scraper_TabPage = new System.Windows.Forms.TabPage();
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox = new System.Windows.Forms.PictureBox();
            Google_CSE_Scraper_Start_CSE_Search_PictureBox = new System.Windows.Forms.PictureBox();
            Google_CSE_Scraper_Dorking_Example_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Query_Description_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Delete_Selected_Results_Button = new System.Windows.Forms.Button();
            Google_CSE_Scraper_Clear_Results_Button = new System.Windows.Forms.Button();
            Google_CSE_Scraper_Clear_Keywords_Button = new System.Windows.Forms.Button();
            Google_CSE_Scraper_Settings_GroupBox = new System.Windows.Forms.GroupBox();
            Google_CSE_Scraper_Settings_Reminder_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            Google_CSE_Scraper_Settings_Language_ComboBox = new System.Windows.Forms.ComboBox();
            Google_CSE_Scraper_Settings_Country_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper__Settings_Country_ComboBox = new System.Windows.Forms.ComboBox();
            Google_CSE_Scraper_Settings_Language_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Export_To_Subfinder_Button = new System.Windows.Forms.Button();
            Google_CSE_Scraper_Start_CSE_Search_Button = new System.Windows.Forms.Button();
            Google_CSE_Scraper_Results_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            Google_CSE_Scraper_Results_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Keywords_Label = new System.Windows.Forms.Label();
            Google_CSE_Scraper_Keywords_RichTextBox = new System.Windows.Forms.RichTextBox();
            Subfinder_TabPage = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox = new System.Windows.Forms.PictureBox();
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox = new System.Windows.Forms.PictureBox();
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Domains_Processed_Label = new System.Windows.Forms.Label();
            Subfinder_Module_Clear_Subdomains_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Clear_Subfinder_Domains_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Start_Subfinder_Enumeration_Button = new System.Windows.Forms.Button();
            Subfinder_Module_Threads_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            Subfinder_Module_Threads_Amount_Label = new System.Windows.Forms.Label();
            Subfinder_Module_Domain_Results_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            Subfinder_Module_Results_Label = new System.Windows.Forms.Label();
            Subfinder_Module_Domains_Label = new System.Windows.Forms.Label();
            Subfinder_Module_Domains_RichTextBox = new System.Windows.Forms.RichTextBox();
            Local_Database_TabPage = new System.Windows.Forms.TabPage();
            Local_Database_Other_Options = new System.Windows.Forms.GroupBox();
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button = new System.Windows.Forms.Button();
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button = new System.Windows.Forms.Button();
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button = new System.Windows.Forms.Button();
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button = new System.Windows.Forms.Button();
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button = new System.Windows.Forms.Button();
            Local_Database_Blacklist_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            Local_Database_Whitelist_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            Local_Database_Blacklist_Label = new System.Windows.Forms.Label();
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button = new System.Windows.Forms.Button();
            Local_Database_Clear_Blacklist_Button = new System.Windows.Forms.Button();
            Local_Database_Clear_Database_Button = new System.Windows.Forms.Button();
            Acunetix_Importer_TabPage = new System.Windows.Forms.TabPage();
            Acunetix_Importer_PictureBox = new System.Windows.Forms.PictureBox();
            Acunetix_Importer_Clear_Targets_Button = new System.Windows.Forms.Button();
            Acunetix_Importer_Scan_Profiles_ComboBox = new System.Windows.Forms.ComboBox();
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button = new System.Windows.Forms.Button();
            Acunetix_Importer_Targets_Count_Label = new System.Windows.Forms.Label();
            Acunetix_Importer_Targets_RichTextBox = new System.Windows.Forms.RichTextBox();
            Advanced_Acunetix_Operations_TabPage = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            button28 = new System.Windows.Forms.Button();
            button25 = new System.Windows.Forms.Button();
            button26 = new System.Windows.Forms.Button();
            button27 = new System.Windows.Forms.Button();
            Settings_TabPage = new System.Windows.Forms.TabPage();
            Settings_Save_Settings_Button = new System.Windows.Forms.Button();
            Settings_Acunetix_Api_Key_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            Settings_Acunetix_Api_URL_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            Settings_Acunetix_Api_Key_Label = new System.Windows.Forms.Label();
            Settings_Acunetix_Api_Url_Label = new System.Windows.Forms.Label();
            label51 = new System.Windows.Forms.Label();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            Settings_Subfinder_Location_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            Settings_CSE_ID_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            Settings_CSE_Apikey_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            label50 = new System.Windows.Forms.Label();
            Settings_Subfinder_Location_Label = new System.Windows.Forms.Label();
            Settings_Google_CSE_ID_Label = new System.Windows.Forms.Label();
            Settings_Google_CSE_Api_Key_Label = new System.Windows.Forms.Label();
            About_TabPage = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            Google_CSE_Scraper_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Google_CSE_Scraper_Export_To_Subfinder_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Google_CSE_Scraper_Start_CSE_Search_PictureBox).BeginInit();
            Google_CSE_Scraper_Settings_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown).BeginInit();
            Subfinder_TabPage.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Subfinder_Module_Start_Subdomain_Enumeration_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Subfinder_Module_Threads_NumericUpDown).BeginInit();
            Local_Database_TabPage.SuspendLayout();
            Local_Database_Other_Options.SuspendLayout();
            Acunetix_Importer_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Acunetix_Importer_PictureBox).BeginInit();
            Advanced_Acunetix_Operations_TabPage.SuspendLayout();
            groupBox3.SuspendLayout();
            Settings_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Google_CSE_Scraper_TabPage);
            tabControl1.Controls.Add(Subfinder_TabPage);
            tabControl1.Controls.Add(Local_Database_TabPage);
            tabControl1.Controls.Add(Acunetix_Importer_TabPage);
            tabControl1.Controls.Add(Advanced_Acunetix_Operations_TabPage);
            tabControl1.Controls.Add(Settings_TabPage);
            tabControl1.Controls.Add(About_TabPage);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1265, 706);
            tabControl1.TabIndex = 2;
            // 
            // Google_CSE_Scraper_TabPage
            // 
            Google_CSE_Scraper_TabPage.BackColor = System.Drawing.Color.Transparent;
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Export_To_Subfinder_PictureBox);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Start_CSE_Search_PictureBox);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Dorking_Example_Label);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Query_Description_Label);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Delete_Selected_Results_Button);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Clear_Results_Button);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Clear_Keywords_Button);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Settings_GroupBox);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Export_To_Subfinder_Button);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Start_CSE_Search_Button);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Results_CheckedListBox);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Results_Label);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Keywords_Label);
            Google_CSE_Scraper_TabPage.Controls.Add(Google_CSE_Scraper_Keywords_RichTextBox);
            Google_CSE_Scraper_TabPage.Location = new System.Drawing.Point(4, 24);
            Google_CSE_Scraper_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_TabPage.Name = "Google_CSE_Scraper_TabPage";
            Google_CSE_Scraper_TabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_TabPage.Size = new System.Drawing.Size(1257, 678);
            Google_CSE_Scraper_TabPage.TabIndex = 0;
            Google_CSE_Scraper_TabPage.Text = "Google CSE Scraper";
            Google_CSE_Scraper_TabPage.UseVisualStyleBackColor = true;
            // 
            // Google_CSE_Scraper_Export_To_Subfinder_PictureBox
            // 
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox.Image = (System.Drawing.Image)resources.GetObject("Google_CSE_Scraper_Export_To_Subfinder_PictureBox.Image");
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox.Location = new System.Drawing.Point(321, 250);
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox.Name = "Google_CSE_Scraper_Export_To_Subfinder_PictureBox";
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox.Size = new System.Drawing.Size(36, 36);
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox.TabIndex = 42;
            Google_CSE_Scraper_Export_To_Subfinder_PictureBox.TabStop = false;
            // 
            // Google_CSE_Scraper_Start_CSE_Search_PictureBox
            // 
            Google_CSE_Scraper_Start_CSE_Search_PictureBox.Image = (System.Drawing.Image)resources.GetObject("Google_CSE_Scraper_Start_CSE_Search_PictureBox.Image");
            Google_CSE_Scraper_Start_CSE_Search_PictureBox.Location = new System.Drawing.Point(321, 208);
            Google_CSE_Scraper_Start_CSE_Search_PictureBox.Name = "Google_CSE_Scraper_Start_CSE_Search_PictureBox";
            Google_CSE_Scraper_Start_CSE_Search_PictureBox.Size = new System.Drawing.Size(36, 36);
            Google_CSE_Scraper_Start_CSE_Search_PictureBox.TabIndex = 41;
            Google_CSE_Scraper_Start_CSE_Search_PictureBox.TabStop = false;
            // 
            // Google_CSE_Scraper_Dorking_Example_Label
            // 
            Google_CSE_Scraper_Dorking_Example_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Google_CSE_Scraper_Dorking_Example_Label.Location = new System.Drawing.Point(649, 70);
            Google_CSE_Scraper_Dorking_Example_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Dorking_Example_Label.Name = "Google_CSE_Scraper_Dorking_Example_Label";
            Google_CSE_Scraper_Dorking_Example_Label.Size = new System.Drawing.Size(296, 174);
            Google_CSE_Scraper_Dorking_Example_Label.TabIndex = 28;
            Google_CSE_Scraper_Dorking_Example_Label.Text = resources.GetString("Google_CSE_Scraper_Dorking_Example_Label.Text");
            // 
            // Google_CSE_Scraper_Query_Description_Label
            // 
            Google_CSE_Scraper_Query_Description_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Google_CSE_Scraper_Query_Description_Label.Location = new System.Drawing.Point(321, 411);
            Google_CSE_Scraper_Query_Description_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Query_Description_Label.Name = "Google_CSE_Scraper_Query_Description_Label";
            Google_CSE_Scraper_Query_Description_Label.Size = new System.Drawing.Size(275, 174);
            Google_CSE_Scraper_Query_Description_Label.TabIndex = 27;
            Google_CSE_Scraper_Query_Description_Label.Text = resources.GetString("Google_CSE_Scraper_Query_Description_Label.Text");
            // 
            // Google_CSE_Scraper_Delete_Selected_Results_Button
            // 
            Google_CSE_Scraper_Delete_Selected_Results_Button.Location = new System.Drawing.Point(808, 32);
            Google_CSE_Scraper_Delete_Selected_Results_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Delete_Selected_Results_Button.Name = "Google_CSE_Scraper_Delete_Selected_Results_Button";
            Google_CSE_Scraper_Delete_Selected_Results_Button.Size = new System.Drawing.Size(137, 29);
            Google_CSE_Scraper_Delete_Selected_Results_Button.TabIndex = 26;
            Google_CSE_Scraper_Delete_Selected_Results_Button.Text = "Delete Selected Results";
            Google_CSE_Scraper_Delete_Selected_Results_Button.UseVisualStyleBackColor = true;
            // 
            // Google_CSE_Scraper_Clear_Results_Button
            // 
            Google_CSE_Scraper_Clear_Results_Button.AutoSize = true;
            Google_CSE_Scraper_Clear_Results_Button.Location = new System.Drawing.Point(860, 637);
            Google_CSE_Scraper_Clear_Results_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Clear_Results_Button.Name = "Google_CSE_Scraper_Clear_Results_Button";
            Google_CSE_Scraper_Clear_Results_Button.Size = new System.Drawing.Size(85, 29);
            Google_CSE_Scraper_Clear_Results_Button.TabIndex = 13;
            Google_CSE_Scraper_Clear_Results_Button.Text = "Clear Results";
            Google_CSE_Scraper_Clear_Results_Button.UseVisualStyleBackColor = true;
            Google_CSE_Scraper_Clear_Results_Button.Click += Google_cse_scraper_clear_results_button_Click;
            // 
            // Google_CSE_Scraper_Clear_Keywords_Button
            // 
            Google_CSE_Scraper_Clear_Keywords_Button.AutoSize = true;
            Google_CSE_Scraper_Clear_Keywords_Button.Location = new System.Drawing.Point(313, 637);
            Google_CSE_Scraper_Clear_Keywords_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Clear_Keywords_Button.Name = "Google_CSE_Scraper_Clear_Keywords_Button";
            Google_CSE_Scraper_Clear_Keywords_Button.Size = new System.Drawing.Size(98, 29);
            Google_CSE_Scraper_Clear_Keywords_Button.TabIndex = 12;
            Google_CSE_Scraper_Clear_Keywords_Button.Text = "Clear Keywords";
            Google_CSE_Scraper_Clear_Keywords_Button.UseVisualStyleBackColor = true;
            Google_CSE_Scraper_Clear_Keywords_Button.Click += Clear_keywords_button_Click;
            // 
            // Google_CSE_Scraper_Settings_GroupBox
            // 
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper_Settings_Reminder_Label);
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper_Settings_Results_Per_Keyword_Label);
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown);
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper_Settings_Language_ComboBox);
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper_Settings_Country_Label);
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper__Settings_Country_ComboBox);
            Google_CSE_Scraper_Settings_GroupBox.Controls.Add(Google_CSE_Scraper_Settings_Language_Label);
            Google_CSE_Scraper_Settings_GroupBox.Location = new System.Drawing.Point(321, 22);
            Google_CSE_Scraper_Settings_GroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Settings_GroupBox.Name = "Google_CSE_Scraper_Settings_GroupBox";
            Google_CSE_Scraper_Settings_GroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Settings_GroupBox.Size = new System.Drawing.Size(308, 180);
            Google_CSE_Scraper_Settings_GroupBox.TabIndex = 25;
            Google_CSE_Scraper_Settings_GroupBox.TabStop = false;
            Google_CSE_Scraper_Settings_GroupBox.Text = "Scraper Settings";
            // 
            // Google_CSE_Scraper_Settings_Reminder_Label
            // 
            Google_CSE_Scraper_Settings_Reminder_Label.AutoSize = true;
            Google_CSE_Scraper_Settings_Reminder_Label.Location = new System.Drawing.Point(7, 151);
            Google_CSE_Scraper_Settings_Reminder_Label.Margin = new System.Windows.Forms.Padding(4, 23, 4, 0);
            Google_CSE_Scraper_Settings_Reminder_Label.Name = "Google_CSE_Scraper_Settings_Reminder_Label";
            Google_CSE_Scraper_Settings_Reminder_Label.Size = new System.Drawing.Size(212, 15);
            Google_CSE_Scraper_Settings_Reminder_Label.TabIndex = 23;
            Google_CSE_Scraper_Settings_Reminder_Label.Text = "Do not forget to set Apikey and CSE ID.";
            // 
            // Google_CSE_Scraper_Settings_Results_Per_Keyword_Label
            // 
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.AutoSize = true;
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Location = new System.Drawing.Point(7, 39);
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Name = "Google_CSE_Scraper_Settings_Results_Per_Keyword_Label";
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Size = new System.Drawing.Size(116, 15);
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.TabIndex = 16;
            Google_CSE_Scraper_Settings_Results_Per_Keyword_Label.Text = "Results per Keyword:";
            // 
            // Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown
            // 
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Location = new System.Drawing.Point(139, 37);
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Name = "Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown";
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Size = new System.Drawing.Size(162, 23);
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.TabIndex = 17;
            Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Google_CSE_Scraper_Settings_Language_ComboBox
            // 
            Google_CSE_Scraper_Settings_Language_ComboBox.FormattingEnabled = true;
            Google_CSE_Scraper_Settings_Language_ComboBox.Location = new System.Drawing.Point(139, 110);
            Google_CSE_Scraper_Settings_Language_ComboBox.Margin = new System.Windows.Forms.Padding(4, 9, 4, 3);
            Google_CSE_Scraper_Settings_Language_ComboBox.Name = "Google_CSE_Scraper_Settings_Language_ComboBox";
            Google_CSE_Scraper_Settings_Language_ComboBox.Size = new System.Drawing.Size(162, 23);
            Google_CSE_Scraper_Settings_Language_ComboBox.TabIndex = 21;
            // 
            // Google_CSE_Scraper_Settings_Country_Label
            // 
            Google_CSE_Scraper_Settings_Country_Label.AutoSize = true;
            Google_CSE_Scraper_Settings_Country_Label.Location = new System.Drawing.Point(7, 76);
            Google_CSE_Scraper_Settings_Country_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Settings_Country_Label.Name = "Google_CSE_Scraper_Settings_Country_Label";
            Google_CSE_Scraper_Settings_Country_Label.Size = new System.Drawing.Size(53, 15);
            Google_CSE_Scraper_Settings_Country_Label.TabIndex = 20;
            Google_CSE_Scraper_Settings_Country_Label.Text = "Country:";
            // 
            // Google_CSE_Scraper__Settings_Country_ComboBox
            // 
            Google_CSE_Scraper__Settings_Country_ComboBox.FormattingEnabled = true;
            Google_CSE_Scraper__Settings_Country_ComboBox.Location = new System.Drawing.Point(139, 73);
            Google_CSE_Scraper__Settings_Country_ComboBox.Margin = new System.Windows.Forms.Padding(4, 9, 4, 3);
            Google_CSE_Scraper__Settings_Country_ComboBox.Name = "Google_CSE_Scraper__Settings_Country_ComboBox";
            Google_CSE_Scraper__Settings_Country_ComboBox.Size = new System.Drawing.Size(162, 23);
            Google_CSE_Scraper__Settings_Country_ComboBox.TabIndex = 22;
            // 
            // Google_CSE_Scraper_Settings_Language_Label
            // 
            Google_CSE_Scraper_Settings_Language_Label.AutoSize = true;
            Google_CSE_Scraper_Settings_Language_Label.Location = new System.Drawing.Point(7, 113);
            Google_CSE_Scraper_Settings_Language_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Settings_Language_Label.Name = "Google_CSE_Scraper_Settings_Language_Label";
            Google_CSE_Scraper_Settings_Language_Label.Size = new System.Drawing.Size(62, 15);
            Google_CSE_Scraper_Settings_Language_Label.TabIndex = 19;
            Google_CSE_Scraper_Settings_Language_Label.Text = "Language:";
            // 
            // Google_CSE_Scraper_Export_To_Subfinder_Button
            // 
            Google_CSE_Scraper_Export_To_Subfinder_Button.AutoSize = true;
            Google_CSE_Scraper_Export_To_Subfinder_Button.Location = new System.Drawing.Point(364, 250);
            Google_CSE_Scraper_Export_To_Subfinder_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Export_To_Subfinder_Button.Name = "Google_CSE_Scraper_Export_To_Subfinder_Button";
            Google_CSE_Scraper_Export_To_Subfinder_Button.Size = new System.Drawing.Size(265, 36);
            Google_CSE_Scraper_Export_To_Subfinder_Button.TabIndex = 11;
            Google_CSE_Scraper_Export_To_Subfinder_Button.Text = "Export to Subfinder";
            Google_CSE_Scraper_Export_To_Subfinder_Button.UseVisualStyleBackColor = true;
            Google_CSE_Scraper_Export_To_Subfinder_Button.Click += Export_to_subfinder_button_Click;
            // 
            // Google_CSE_Scraper_Start_CSE_Search_Button
            // 
            Google_CSE_Scraper_Start_CSE_Search_Button.Location = new System.Drawing.Point(364, 208);
            Google_CSE_Scraper_Start_CSE_Search_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Start_CSE_Search_Button.Name = "Google_CSE_Scraper_Start_CSE_Search_Button";
            Google_CSE_Scraper_Start_CSE_Search_Button.Size = new System.Drawing.Size(265, 36);
            Google_CSE_Scraper_Start_CSE_Search_Button.TabIndex = 10;
            Google_CSE_Scraper_Start_CSE_Search_Button.Text = "Start CSE Search";
            Google_CSE_Scraper_Start_CSE_Search_Button.UseVisualStyleBackColor = true;
            Google_CSE_Scraper_Start_CSE_Search_Button.Click += Start_cse_search_button_Click;
            // 
            // Google_CSE_Scraper_Results_CheckedListBox
            // 
            Google_CSE_Scraper_Results_CheckedListBox.FormattingEnabled = true;
            Google_CSE_Scraper_Results_CheckedListBox.Location = new System.Drawing.Point(953, 32);
            Google_CSE_Scraper_Results_CheckedListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Results_CheckedListBox.Name = "Google_CSE_Scraper_Results_CheckedListBox";
            Google_CSE_Scraper_Results_CheckedListBox.Size = new System.Drawing.Size(296, 634);
            Google_CSE_Scraper_Results_CheckedListBox.TabIndex = 24;
            // 
            // Google_CSE_Scraper_Results_Label
            // 
            Google_CSE_Scraper_Results_Label.AutoSize = true;
            Google_CSE_Scraper_Results_Label.Location = new System.Drawing.Point(953, 3);
            Google_CSE_Scraper_Results_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Results_Label.Name = "Google_CSE_Scraper_Results_Label";
            Google_CSE_Scraper_Results_Label.Size = new System.Drawing.Size(47, 15);
            Google_CSE_Scraper_Results_Label.TabIndex = 9;
            Google_CSE_Scraper_Results_Label.Text = "Results:";
            // 
            // Google_CSE_Scraper_Keywords_Label
            // 
            Google_CSE_Scraper_Keywords_Label.AutoSize = true;
            Google_CSE_Scraper_Keywords_Label.Location = new System.Drawing.Point(9, 3);
            Google_CSE_Scraper_Keywords_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Google_CSE_Scraper_Keywords_Label.Name = "Google_CSE_Scraper_Keywords_Label";
            Google_CSE_Scraper_Keywords_Label.Size = new System.Drawing.Size(61, 15);
            Google_CSE_Scraper_Keywords_Label.TabIndex = 8;
            Google_CSE_Scraper_Keywords_Label.Text = "Keywords:";
            // 
            // Google_CSE_Scraper_Keywords_RichTextBox
            // 
            Google_CSE_Scraper_Keywords_RichTextBox.Location = new System.Drawing.Point(9, 22);
            Google_CSE_Scraper_Keywords_RichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Google_CSE_Scraper_Keywords_RichTextBox.Name = "Google_CSE_Scraper_Keywords_RichTextBox";
            Google_CSE_Scraper_Keywords_RichTextBox.Size = new System.Drawing.Size(296, 644);
            Google_CSE_Scraper_Keywords_RichTextBox.TabIndex = 2;
            Google_CSE_Scraper_Keywords_RichTextBox.Text = "";
            // 
            // Subfinder_TabPage
            // 
            Subfinder_TabPage.Controls.Add(groupBox2);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Start_Subdomain_Enumeration_PictureBox);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Domains_Processed_Label);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Clear_Subdomains_Button);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Clear_Subfinder_Domains_Button);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Start_Subfinder_Enumeration_Button);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Threads_NumericUpDown);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Threads_Amount_Label);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Domain_Results_CheckedListBox);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Results_Label);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Domains_Label);
            Subfinder_TabPage.Controls.Add(Subfinder_Module_Domains_RichTextBox);
            Subfinder_TabPage.Location = new System.Drawing.Point(4, 24);
            Subfinder_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_TabPage.Name = "Subfinder_TabPage";
            Subfinder_TabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_TabPage.Size = new System.Drawing.Size(1257, 678);
            Subfinder_TabPage.TabIndex = 1;
            Subfinder_TabPage.Text = "Subfinder Module";
            Subfinder_TabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button);
            groupBox2.Controls.Add(Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button);
            groupBox2.Controls.Add(Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button);
            groupBox2.Location = new System.Drawing.Point(321, 226);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(310, 238);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Other Options:";
            // 
            // Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button
            // 
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.Location = new System.Drawing.Point(7, 22);
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.Name = "Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button";
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.Size = new System.Drawing.Size(296, 27);
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.TabIndex = 39;
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.Text = "Export Selected Subdomains to Local Database";
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.UseVisualStyleBackColor = true;
            Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button.Click += Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button_Click;
            // 
            // Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button
            // 
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Location = new System.Drawing.Point(7, 121);
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Name = "Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button";
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Size = new System.Drawing.Size(296, 27);
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.TabIndex = 36;
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Text = "Delete .gov .mil .arpa Domains";
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.UseVisualStyleBackColor = true;
            Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button.Click += Subfinder_Module_Delete_gov_mil_arpa_Domains_Button_Click;
            // 
            // Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button
            // 
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.Location = new System.Drawing.Point(7, 205);
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.Name = "Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button";
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.Size = new System.Drawing.Size(296, 27);
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.TabIndex = 34;
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.Text = "Delete Selected Subdomains";
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.UseVisualStyleBackColor = true;
            Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button.Click += Subfinder_Module_Delete_Selected_Subdomains_Button_Click;
            // 
            // Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox
            // 
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.Image = (System.Drawing.Image)resources.GetObject("Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.Image");
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.Location = new System.Drawing.Point(324, 94);
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.Name = "Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox";
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.Size = new System.Drawing.Size(36, 36);
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.TabIndex = 41;
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox.TabStop = false;
            // 
            // Subfinder_Module_Start_Subdomain_Enumeration_PictureBox
            // 
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.Image = (System.Drawing.Image)resources.GetObject("Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.Image");
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.Location = new System.Drawing.Point(324, 52);
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.Name = "Subfinder_Module_Start_Subdomain_Enumeration_PictureBox";
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.Size = new System.Drawing.Size(36, 36);
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.TabIndex = 40;
            Subfinder_Module_Start_Subdomain_Enumeration_PictureBox.TabStop = false;
            // 
            // Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button
            // 
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Location = new System.Drawing.Point(367, 94);
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Name = "Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button";
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Size = new System.Drawing.Size(257, 36);
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.TabIndex = 38;
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Text = "Export All Subdomains to Local Database";
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.UseVisualStyleBackColor = true;
            Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button.Click += Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button_Click;
            // 
            // Subfinder_Module_Domains_Processed_Label
            // 
            Subfinder_Module_Domains_Processed_Label.AutoSize = true;
            Subfinder_Module_Domains_Processed_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Subfinder_Module_Domains_Processed_Label.Location = new System.Drawing.Point(321, 153);
            Subfinder_Module_Domains_Processed_Label.Margin = new System.Windows.Forms.Padding(4, 29, 4, 0);
            Subfinder_Module_Domains_Processed_Label.Name = "Subfinder_Module_Domains_Processed_Label";
            Subfinder_Module_Domains_Processed_Label.Size = new System.Drawing.Size(201, 24);
            Subfinder_Module_Domains_Processed_Label.TabIndex = 37;
            Subfinder_Module_Domains_Processed_Label.Text = "Domains processed:";
            // 
            // Subfinder_Module_Clear_Subdomains_Button
            // 
            Subfinder_Module_Clear_Subdomains_Button.Location = new System.Drawing.Point(798, 632);
            Subfinder_Module_Clear_Subdomains_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Clear_Subdomains_Button.Name = "Subfinder_Module_Clear_Subdomains_Button";
            Subfinder_Module_Clear_Subdomains_Button.Size = new System.Drawing.Size(140, 27);
            Subfinder_Module_Clear_Subdomains_Button.TabIndex = 33;
            Subfinder_Module_Clear_Subdomains_Button.Text = "Clear Subdomains";
            Subfinder_Module_Clear_Subdomains_Button.UseVisualStyleBackColor = true;
            Subfinder_Module_Clear_Subdomains_Button.Click += Subfinder_Module_Clear_Subdomains_Button_Click;
            // 
            // Subfinder_Module_Clear_Subfinder_Domains_Button
            // 
            Subfinder_Module_Clear_Subfinder_Domains_Button.Location = new System.Drawing.Point(313, 632);
            Subfinder_Module_Clear_Subfinder_Domains_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Clear_Subfinder_Domains_Button.Name = "Subfinder_Module_Clear_Subfinder_Domains_Button";
            Subfinder_Module_Clear_Subfinder_Domains_Button.Size = new System.Drawing.Size(105, 27);
            Subfinder_Module_Clear_Subfinder_Domains_Button.TabIndex = 32;
            Subfinder_Module_Clear_Subfinder_Domains_Button.Text = "Clear Domains";
            Subfinder_Module_Clear_Subfinder_Domains_Button.UseVisualStyleBackColor = true;
            // 
            // Subfinder_Module_Start_Subfinder_Enumeration_Button
            // 
            Subfinder_Module_Start_Subfinder_Enumeration_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Location = new System.Drawing.Point(367, 52);
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Name = "Subfinder_Module_Start_Subfinder_Enumeration_Button";
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Size = new System.Drawing.Size(257, 36);
            Subfinder_Module_Start_Subfinder_Enumeration_Button.TabIndex = 31;
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Text = "Start Subdomain Enumeration";
            Subfinder_Module_Start_Subfinder_Enumeration_Button.UseVisualStyleBackColor = true;
            Subfinder_Module_Start_Subfinder_Enumeration_Button.Click += Start_Subfinder_Enumeration_Button_Click;
            // 
            // Subfinder_Module_Threads_NumericUpDown
            // 
            Subfinder_Module_Threads_NumericUpDown.Location = new System.Drawing.Point(495, 23);
            Subfinder_Module_Threads_NumericUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Threads_NumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            Subfinder_Module_Threads_NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Subfinder_Module_Threads_NumericUpDown.Name = "Subfinder_Module_Threads_NumericUpDown";
            Subfinder_Module_Threads_NumericUpDown.Size = new System.Drawing.Size(126, 23);
            Subfinder_Module_Threads_NumericUpDown.TabIndex = 17;
            Subfinder_Module_Threads_NumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Subfinder_Module_Threads_Amount_Label
            // 
            Subfinder_Module_Threads_Amount_Label.AutoSize = true;
            Subfinder_Module_Threads_Amount_Label.Location = new System.Drawing.Point(321, 25);
            Subfinder_Module_Threads_Amount_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Subfinder_Module_Threads_Amount_Label.Name = "Subfinder_Module_Threads_Amount_Label";
            Subfinder_Module_Threads_Amount_Label.Size = new System.Drawing.Size(170, 15);
            Subfinder_Module_Threads_Amount_Label.TabIndex = 16;
            Subfinder_Module_Threads_Amount_Label.Text = "How many Subfinder's to start:";
            // 
            // Subfinder_Module_Domain_Results_CheckedListBox
            // 
            Subfinder_Module_Domain_Results_CheckedListBox.FormattingEnabled = true;
            Subfinder_Module_Domain_Results_CheckedListBox.Location = new System.Drawing.Point(946, 25);
            Subfinder_Module_Domain_Results_CheckedListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Domain_Results_CheckedListBox.Name = "Subfinder_Module_Domain_Results_CheckedListBox";
            Subfinder_Module_Domain_Results_CheckedListBox.Size = new System.Drawing.Size(299, 634);
            Subfinder_Module_Domain_Results_CheckedListBox.TabIndex = 30;
            // 
            // Subfinder_Module_Results_Label
            // 
            Subfinder_Module_Results_Label.AutoSize = true;
            Subfinder_Module_Results_Label.Location = new System.Drawing.Point(946, 7);
            Subfinder_Module_Results_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Subfinder_Module_Results_Label.Name = "Subfinder_Module_Results_Label";
            Subfinder_Module_Results_Label.Size = new System.Drawing.Size(76, 15);
            Subfinder_Module_Results_Label.TabIndex = 27;
            Subfinder_Module_Results_Label.Text = "Subdomains:";
            // 
            // Subfinder_Module_Domains_Label
            // 
            Subfinder_Module_Domains_Label.AutoSize = true;
            Subfinder_Module_Domains_Label.Location = new System.Drawing.Point(9, 7);
            Subfinder_Module_Domains_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Subfinder_Module_Domains_Label.Name = "Subfinder_Module_Domains_Label";
            Subfinder_Module_Domains_Label.Size = new System.Drawing.Size(57, 15);
            Subfinder_Module_Domains_Label.TabIndex = 26;
            Subfinder_Module_Domains_Label.Text = "Domains:";
            // 
            // Subfinder_Module_Domains_RichTextBox
            // 
            Subfinder_Module_Domains_RichTextBox.Location = new System.Drawing.Point(9, 25);
            Subfinder_Module_Domains_RichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Subfinder_Module_Domains_RichTextBox.Name = "Subfinder_Module_Domains_RichTextBox";
            Subfinder_Module_Domains_RichTextBox.Size = new System.Drawing.Size(296, 634);
            Subfinder_Module_Domains_RichTextBox.TabIndex = 25;
            Subfinder_Module_Domains_RichTextBox.Text = "";
            // 
            // Local_Database_TabPage
            // 
            Local_Database_TabPage.Controls.Add(Local_Database_Other_Options);
            Local_Database_TabPage.Controls.Add(Local_Database_Blacklist_CheckedListBox);
            Local_Database_TabPage.Controls.Add(Local_Database_Whitelist_CheckedListBox);
            Local_Database_TabPage.Controls.Add(Local_Database_Blacklist_Label);
            Local_Database_TabPage.Controls.Add(Local_Database_Export_All_Websites_To_Acunetix_Importer_Button);
            Local_Database_TabPage.Controls.Add(Local_Database_Clear_Blacklist_Button);
            Local_Database_TabPage.Controls.Add(Local_Database_Clear_Database_Button);
            Local_Database_TabPage.Location = new System.Drawing.Point(4, 24);
            Local_Database_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_TabPage.Name = "Local_Database_TabPage";
            Local_Database_TabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_TabPage.Size = new System.Drawing.Size(1257, 678);
            Local_Database_TabPage.TabIndex = 3;
            Local_Database_TabPage.Text = "Local Database";
            Local_Database_TabPage.UseVisualStyleBackColor = true;
            // 
            // Local_Database_Other_Options
            // 
            Local_Database_Other_Options.Controls.Add(Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button);
            Local_Database_Other_Options.Controls.Add(Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button);
            Local_Database_Other_Options.Controls.Add(Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button);
            Local_Database_Other_Options.Controls.Add(Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button);
            Local_Database_Other_Options.Controls.Add(Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button);
            Local_Database_Other_Options.Location = new System.Drawing.Point(312, 35);
            Local_Database_Other_Options.Name = "Local_Database_Other_Options";
            Local_Database_Other_Options.Size = new System.Drawing.Size(322, 328);
            Local_Database_Other_Options.TabIndex = 27;
            Local_Database_Other_Options.TabStop = false;
            Local_Database_Other_Options.Text = "Other Options:";
            // 
            // Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button
            // 
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.Location = new System.Drawing.Point(7, 22);
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.Name = "Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button";
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.Size = new System.Drawing.Size(296, 27);
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.TabIndex = 17;
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.Text = "Export Selected Websites to Acunetix Importer";
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.UseVisualStyleBackColor = true;
            Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button.Click += Local_Database_Other_Options_Export_Selected_Websites_To_Acunetix_Importer_Button_Click;
            // 
            // Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button
            // 
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.Location = new System.Drawing.Point(7, 55);
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.Name = "Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button";
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.Size = new System.Drawing.Size(296, 27);
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.TabIndex = 21;
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.Text = "Export Selected Websites to Blacklist";
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.UseVisualStyleBackColor = true;
            Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button.Click += Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button_Click;
            // 
            // Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button
            // 
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.Location = new System.Drawing.Point(7, 140);
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.Name = "Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button";
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.Size = new System.Drawing.Size(296, 27);
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.TabIndex = 23;
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.Text = "Export Selected Websites to Subfinder Module";
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.UseVisualStyleBackColor = true;
            Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button.Click += Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button_Click;
            // 
            // Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button
            // 
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.Location = new System.Drawing.Point(7, 173);
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.Name = "Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button";
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.Size = new System.Drawing.Size(296, 27);
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.TabIndex = 22;
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.Text = "Export All Websites to Subfinder Module";
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.UseVisualStyleBackColor = true;
            Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button.Click += Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button_Click;
            // 
            // Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button
            // 
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.Location = new System.Drawing.Point(7, 295);
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.Name = "Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button";
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.Size = new System.Drawing.Size(296, 27);
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.TabIndex = 18;
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.Text = "Remove Selected Websites from Database";
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.UseVisualStyleBackColor = true;
            Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button.Click += Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button_Click;
            // 
            // Local_Database_Blacklist_CheckedListBox
            // 
            Local_Database_Blacklist_CheckedListBox.FormattingEnabled = true;
            Local_Database_Blacklist_CheckedListBox.Location = new System.Drawing.Point(958, 162);
            Local_Database_Blacklist_CheckedListBox.Name = "Local_Database_Blacklist_CheckedListBox";
            Local_Database_Blacklist_CheckedListBox.Size = new System.Drawing.Size(291, 508);
            Local_Database_Blacklist_CheckedListBox.TabIndex = 26;
            // 
            // Local_Database_Whitelist_CheckedListBox
            // 
            Local_Database_Whitelist_CheckedListBox.FormattingEnabled = true;
            Local_Database_Whitelist_CheckedListBox.Location = new System.Drawing.Point(9, 35);
            Local_Database_Whitelist_CheckedListBox.Name = "Local_Database_Whitelist_CheckedListBox";
            Local_Database_Whitelist_CheckedListBox.Size = new System.Drawing.Size(296, 634);
            Local_Database_Whitelist_CheckedListBox.TabIndex = 25;
            Local_Database_Whitelist_CheckedListBox.SelectedIndexChanged += Local_Database_Whitelist_CheckedListBox_SelectedIndexChanged;
            // 
            // Local_Database_Blacklist_Label
            // 
            Local_Database_Blacklist_Label.AutoSize = true;
            Local_Database_Blacklist_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Local_Database_Blacklist_Label.Location = new System.Drawing.Point(958, 134);
            Local_Database_Blacklist_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Local_Database_Blacklist_Label.Name = "Local_Database_Blacklist_Label";
            Local_Database_Blacklist_Label.Size = new System.Drawing.Size(76, 24);
            Local_Database_Blacklist_Label.TabIndex = 24;
            Local_Database_Blacklist_Label.Text = "Blacklist";
            // 
            // Local_Database_Export_All_Websites_To_Acunetix_Importer_Button
            // 
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.Location = new System.Drawing.Point(9, 6);
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.Name = "Local_Database_Export_All_Websites_To_Acunetix_Importer_Button";
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.Size = new System.Drawing.Size(296, 27);
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.TabIndex = 16;
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.Text = "Export All Websites to Acunetix Importer";
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.UseVisualStyleBackColor = true;
            Local_Database_Export_All_Websites_To_Acunetix_Importer_Button.Click += Local_Database_Export_All_Websites_To_Acunetix_Importer_Button_Click;
            // 
            // Local_Database_Clear_Blacklist_Button
            // 
            Local_Database_Clear_Blacklist_Button.Location = new System.Drawing.Point(855, 642);
            Local_Database_Clear_Blacklist_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Clear_Blacklist_Button.Name = "Local_Database_Clear_Blacklist_Button";
            Local_Database_Clear_Blacklist_Button.Size = new System.Drawing.Size(96, 27);
            Local_Database_Clear_Blacklist_Button.TabIndex = 15;
            Local_Database_Clear_Blacklist_Button.Text = "Clear Blacklist";
            Local_Database_Clear_Blacklist_Button.UseVisualStyleBackColor = true;
            Local_Database_Clear_Blacklist_Button.Click += Local_Database_Clear_Blacklist_Button_Click;
            // 
            // Local_Database_Clear_Database_Button
            // 
            Local_Database_Clear_Database_Button.Location = new System.Drawing.Point(312, 642);
            Local_Database_Clear_Database_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Local_Database_Clear_Database_Button.Name = "Local_Database_Clear_Database_Button";
            Local_Database_Clear_Database_Button.Size = new System.Drawing.Size(104, 27);
            Local_Database_Clear_Database_Button.TabIndex = 14;
            Local_Database_Clear_Database_Button.Text = "Clear Database";
            Local_Database_Clear_Database_Button.UseVisualStyleBackColor = true;
            Local_Database_Clear_Database_Button.Click += Local_Database_Clear_Database_Button_Click;
            // 
            // Acunetix_Importer_TabPage
            // 
            Acunetix_Importer_TabPage.Controls.Add(Acunetix_Importer_PictureBox);
            Acunetix_Importer_TabPage.Controls.Add(Acunetix_Importer_Clear_Targets_Button);
            Acunetix_Importer_TabPage.Controls.Add(Acunetix_Importer_Scan_Profiles_ComboBox);
            Acunetix_Importer_TabPage.Controls.Add(Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button);
            Acunetix_Importer_TabPage.Controls.Add(Acunetix_Importer_Targets_Count_Label);
            Acunetix_Importer_TabPage.Controls.Add(Acunetix_Importer_Targets_RichTextBox);
            Acunetix_Importer_TabPage.Location = new System.Drawing.Point(4, 24);
            Acunetix_Importer_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Acunetix_Importer_TabPage.Name = "Acunetix_Importer_TabPage";
            Acunetix_Importer_TabPage.Size = new System.Drawing.Size(1257, 678);
            Acunetix_Importer_TabPage.TabIndex = 4;
            Acunetix_Importer_TabPage.Text = "Acunetix Importer";
            Acunetix_Importer_TabPage.UseVisualStyleBackColor = true;
            // 
            // Acunetix_Importer_PictureBox
            // 
            Acunetix_Importer_PictureBox.Image = (System.Drawing.Image)resources.GetObject("Acunetix_Importer_PictureBox.Image");
            Acunetix_Importer_PictureBox.Location = new System.Drawing.Point(322, 51);
            Acunetix_Importer_PictureBox.Name = "Acunetix_Importer_PictureBox";
            Acunetix_Importer_PictureBox.Size = new System.Drawing.Size(36, 36);
            Acunetix_Importer_PictureBox.TabIndex = 42;
            Acunetix_Importer_PictureBox.TabStop = false;
            // 
            // Acunetix_Importer_Clear_Targets_Button
            // 
            Acunetix_Importer_Clear_Targets_Button.Location = new System.Drawing.Point(313, 639);
            Acunetix_Importer_Clear_Targets_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Acunetix_Importer_Clear_Targets_Button.Name = "Acunetix_Importer_Clear_Targets_Button";
            Acunetix_Importer_Clear_Targets_Button.Size = new System.Drawing.Size(93, 27);
            Acunetix_Importer_Clear_Targets_Button.TabIndex = 20;
            Acunetix_Importer_Clear_Targets_Button.Text = "Clear Targets";
            Acunetix_Importer_Clear_Targets_Button.UseVisualStyleBackColor = true;
            // 
            // Acunetix_Importer_Scan_Profiles_ComboBox
            // 
            Acunetix_Importer_Scan_Profiles_ComboBox.FormattingEnabled = true;
            Acunetix_Importer_Scan_Profiles_ComboBox.Location = new System.Drawing.Point(322, 22);
            Acunetix_Importer_Scan_Profiles_ComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Acunetix_Importer_Scan_Profiles_ComboBox.Name = "Acunetix_Importer_Scan_Profiles_ComboBox";
            Acunetix_Importer_Scan_Profiles_ComboBox.Size = new System.Drawing.Size(293, 23);
            Acunetix_Importer_Scan_Profiles_ComboBox.TabIndex = 19;
            // 
            // Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button
            // 
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.Location = new System.Drawing.Point(365, 51);
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.Name = "Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button";
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.Size = new System.Drawing.Size(250, 36);
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.TabIndex = 18;
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.Text = "Add to Acunetix and Start Selected Scan";
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.UseVisualStyleBackColor = true;
            Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button.Click += Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button_Click;
            // 
            // Acunetix_Importer_Targets_Count_Label
            // 
            Acunetix_Importer_Targets_Count_Label.AutoSize = true;
            Acunetix_Importer_Targets_Count_Label.Location = new System.Drawing.Point(9, 3);
            Acunetix_Importer_Targets_Count_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Acunetix_Importer_Targets_Count_Label.Name = "Acunetix_Importer_Targets_Count_Label";
            Acunetix_Importer_Targets_Count_Label.Size = new System.Drawing.Size(47, 15);
            Acunetix_Importer_Targets_Count_Label.TabIndex = 16;
            Acunetix_Importer_Targets_Count_Label.Text = "Targets:";
            // 
            // Acunetix_Importer_Targets_RichTextBox
            // 
            Acunetix_Importer_Targets_RichTextBox.Location = new System.Drawing.Point(9, 22);
            Acunetix_Importer_Targets_RichTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Acunetix_Importer_Targets_RichTextBox.Name = "Acunetix_Importer_Targets_RichTextBox";
            Acunetix_Importer_Targets_RichTextBox.Size = new System.Drawing.Size(296, 644);
            Acunetix_Importer_Targets_RichTextBox.TabIndex = 15;
            Acunetix_Importer_Targets_RichTextBox.Text = "";
            // 
            // Advanced_Acunetix_Operations_TabPage
            // 
            Advanced_Acunetix_Operations_TabPage.Controls.Add(groupBox3);
            Advanced_Acunetix_Operations_TabPage.Controls.Add(button28);
            Advanced_Acunetix_Operations_TabPage.Controls.Add(button25);
            Advanced_Acunetix_Operations_TabPage.Controls.Add(button26);
            Advanced_Acunetix_Operations_TabPage.Controls.Add(button27);
            Advanced_Acunetix_Operations_TabPage.Location = new System.Drawing.Point(4, 24);
            Advanced_Acunetix_Operations_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Advanced_Acunetix_Operations_TabPage.Name = "Advanced_Acunetix_Operations_TabPage";
            Advanced_Acunetix_Operations_TabPage.Size = new System.Drawing.Size(1257, 678);
            Advanced_Acunetix_Operations_TabPage.TabIndex = 5;
            Advanced_Acunetix_Operations_TabPage.Text = "Advanced Acunetix Operations";
            Advanced_Acunetix_Operations_TabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(9, 381);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(611, 286);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Statistics";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(7, 58);
            label11.Margin = new System.Windows.Forms.Padding(4, 29, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(78, 24);
            label11.TabIndex = 22;
            label11.Text = "Targets:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(7, 114);
            label12.Margin = new System.Windows.Forms.Padding(4, 29, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(144, 24);
            label12.TabIndex = 23;
            label12.Text = "Running Scans:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(7, 227);
            label14.Margin = new System.Windows.Forms.Padding(4, 29, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(214, 24);
            label14.TabIndex = 25;
            label14.Text = "Unscanned Targets Left:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(7, 171);
            label13.Margin = new System.Windows.Forms.Padding(4, 29, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(142, 24);
            label13.TabIndex = 24;
            label13.Text = "Queued Scans:";
            // 
            // button28
            // 
            button28.Location = new System.Drawing.Point(9, 40);
            button28.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button28.Name = "button28";
            button28.Size = new System.Drawing.Size(296, 27);
            button28.TabIndex = 26;
            button28.Text = "Delete All Queued Scans";
            button28.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            button25.Location = new System.Drawing.Point(9, 74);
            button25.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button25.Name = "button25";
            button25.Size = new System.Drawing.Size(296, 27);
            button25.TabIndex = 21;
            button25.Text = "Delete All Finished Targets with 0 Vulnerabilities";
            button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            button26.Location = new System.Drawing.Point(9, 107);
            button26.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button26.Name = "button26";
            button26.Size = new System.Drawing.Size(296, 27);
            button26.TabIndex = 20;
            button26.Text = "Delete All Targets in Acunetix";
            button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            button27.Location = new System.Drawing.Point(9, 7);
            button27.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button27.Name = "button27";
            button27.Size = new System.Drawing.Size(296, 27);
            button27.TabIndex = 19;
            button27.Text = "Delete All Running Scans";
            button27.UseVisualStyleBackColor = true;
            // 
            // Settings_TabPage
            // 
            Settings_TabPage.Controls.Add(Settings_Save_Settings_Button);
            Settings_TabPage.Controls.Add(Settings_Acunetix_Api_Key_MaskedTextBox);
            Settings_TabPage.Controls.Add(Settings_Acunetix_Api_URL_MaskedTextBox);
            Settings_TabPage.Controls.Add(Settings_Acunetix_Api_Key_Label);
            Settings_TabPage.Controls.Add(Settings_Acunetix_Api_Url_Label);
            Settings_TabPage.Controls.Add(label51);
            Settings_TabPage.Controls.Add(numericUpDown2);
            Settings_TabPage.Controls.Add(Settings_Subfinder_Location_MaskedTextBox);
            Settings_TabPage.Controls.Add(Settings_CSE_ID_MaskedTextBox);
            Settings_TabPage.Controls.Add(Settings_CSE_Apikey_MaskedTextBox);
            Settings_TabPage.Controls.Add(label50);
            Settings_TabPage.Controls.Add(Settings_Subfinder_Location_Label);
            Settings_TabPage.Controls.Add(Settings_Google_CSE_ID_Label);
            Settings_TabPage.Controls.Add(Settings_Google_CSE_Api_Key_Label);
            Settings_TabPage.Location = new System.Drawing.Point(4, 24);
            Settings_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Settings_TabPage.Name = "Settings_TabPage";
            Settings_TabPage.Size = new System.Drawing.Size(1257, 678);
            Settings_TabPage.TabIndex = 7;
            Settings_TabPage.Text = "Settings";
            Settings_TabPage.UseVisualStyleBackColor = true;
            // 
            // Settings_Save_Settings_Button
            // 
            Settings_Save_Settings_Button.Location = new System.Drawing.Point(167, 201);
            Settings_Save_Settings_Button.Name = "Settings_Save_Settings_Button";
            Settings_Save_Settings_Button.Size = new System.Drawing.Size(139, 27);
            Settings_Save_Settings_Button.TabIndex = 37;
            Settings_Save_Settings_Button.Text = "Save Settings";
            Settings_Save_Settings_Button.UseVisualStyleBackColor = true;
            Settings_Save_Settings_Button.Click += Settings_Save_Settings_Button_Click;
            // 
            // Settings_Acunetix_Api_Key_MaskedTextBox
            // 
            Settings_Acunetix_Api_Key_MaskedTextBox.Location = new System.Drawing.Point(167, 119);
            Settings_Acunetix_Api_Key_MaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Settings_Acunetix_Api_Key_MaskedTextBox.Name = "Settings_Acunetix_Api_Key_MaskedTextBox";
            Settings_Acunetix_Api_Key_MaskedTextBox.Size = new System.Drawing.Size(453, 23);
            Settings_Acunetix_Api_Key_MaskedTextBox.TabIndex = 36;
            // 
            // Settings_Acunetix_Api_URL_MaskedTextBox
            // 
            Settings_Acunetix_Api_URL_MaskedTextBox.Location = new System.Drawing.Point(167, 90);
            Settings_Acunetix_Api_URL_MaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Settings_Acunetix_Api_URL_MaskedTextBox.Name = "Settings_Acunetix_Api_URL_MaskedTextBox";
            Settings_Acunetix_Api_URL_MaskedTextBox.Size = new System.Drawing.Size(453, 23);
            Settings_Acunetix_Api_URL_MaskedTextBox.TabIndex = 35;
            // 
            // Settings_Acunetix_Api_Key_Label
            // 
            Settings_Acunetix_Api_Key_Label.AutoSize = true;
            Settings_Acunetix_Api_Key_Label.Location = new System.Drawing.Point(9, 122);
            Settings_Acunetix_Api_Key_Label.Name = "Settings_Acunetix_Api_Key_Label";
            Settings_Acunetix_Api_Key_Label.Size = new System.Drawing.Size(100, 15);
            Settings_Acunetix_Api_Key_Label.TabIndex = 34;
            Settings_Acunetix_Api_Key_Label.Text = "Acunetix Api Key:";
            // 
            // Settings_Acunetix_Api_Url_Label
            // 
            Settings_Acunetix_Api_Url_Label.AutoSize = true;
            Settings_Acunetix_Api_Url_Label.Location = new System.Drawing.Point(9, 93);
            Settings_Acunetix_Api_Url_Label.Name = "Settings_Acunetix_Api_Url_Label";
            Settings_Acunetix_Api_Url_Label.Size = new System.Drawing.Size(102, 15);
            Settings_Acunetix_Api_Url_Label.TabIndex = 33;
            Settings_Acunetix_Api_Url_Label.Text = "Acunetix Api URL:";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new System.Drawing.Point(313, 174);
            label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label51.Name = "label51";
            label51.Size = new System.Drawing.Size(51, 15);
            label51.TabIndex = 32;
            label51.Text = "Seconds";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Location = new System.Drawing.Point(167, 172);
            numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDown2.Maximum = new decimal(new int[] { 2500, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(140, 23);
            numericUpDown2.TabIndex = 31;
            numericUpDown2.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // Settings_Subfinder_Location_MaskedTextBox
            // 
            Settings_Subfinder_Location_MaskedTextBox.Location = new System.Drawing.Point(167, 61);
            Settings_Subfinder_Location_MaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Settings_Subfinder_Location_MaskedTextBox.Name = "Settings_Subfinder_Location_MaskedTextBox";
            Settings_Subfinder_Location_MaskedTextBox.Size = new System.Drawing.Size(453, 23);
            Settings_Subfinder_Location_MaskedTextBox.TabIndex = 27;
            Settings_Subfinder_Location_MaskedTextBox.Text = "C:\\Users\\0000\\go\\bin\\subfinder.exe";
            // 
            // Settings_CSE_ID_MaskedTextBox
            // 
            Settings_CSE_ID_MaskedTextBox.Location = new System.Drawing.Point(167, 35);
            Settings_CSE_ID_MaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Settings_CSE_ID_MaskedTextBox.Name = "Settings_CSE_ID_MaskedTextBox";
            Settings_CSE_ID_MaskedTextBox.Size = new System.Drawing.Size(453, 23);
            Settings_CSE_ID_MaskedTextBox.TabIndex = 26;
            // 
            // Settings_CSE_Apikey_MaskedTextBox
            // 
            Settings_CSE_Apikey_MaskedTextBox.Location = new System.Drawing.Point(167, 8);
            Settings_CSE_Apikey_MaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Settings_CSE_Apikey_MaskedTextBox.Name = "Settings_CSE_Apikey_MaskedTextBox";
            Settings_CSE_Apikey_MaskedTextBox.Size = new System.Drawing.Size(453, 23);
            Settings_CSE_Apikey_MaskedTextBox.TabIndex = 25;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new System.Drawing.Point(9, 174);
            label50.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            label50.Name = "label50";
            label50.Size = new System.Drawing.Size(139, 15);
            label50.TabIndex = 24;
            label50.Text = "Statistics Update Interval:";
            // 
            // Settings_Subfinder_Location_Label
            // 
            Settings_Subfinder_Location_Label.AutoSize = true;
            Settings_Subfinder_Location_Label.Location = new System.Drawing.Point(9, 64);
            Settings_Subfinder_Location_Label.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            Settings_Subfinder_Location_Label.Name = "Settings_Subfinder_Location_Label";
            Settings_Subfinder_Location_Label.Size = new System.Drawing.Size(110, 15);
            Settings_Subfinder_Location_Label.TabIndex = 20;
            Settings_Subfinder_Location_Label.Text = "Subfinder Location:";
            // 
            // Settings_Google_CSE_ID_Label
            // 
            Settings_Google_CSE_ID_Label.AutoSize = true;
            Settings_Google_CSE_ID_Label.Location = new System.Drawing.Point(9, 38);
            Settings_Google_CSE_ID_Label.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            Settings_Google_CSE_ID_Label.Name = "Settings_Google_CSE_ID_Label";
            Settings_Google_CSE_ID_Label.Size = new System.Drawing.Size(85, 15);
            Settings_Google_CSE_ID_Label.TabIndex = 19;
            Settings_Google_CSE_ID_Label.Text = "Google CSE ID:";
            // 
            // Settings_Google_CSE_Api_Key_Label
            // 
            Settings_Google_CSE_Api_Key_Label.AutoSize = true;
            Settings_Google_CSE_Api_Key_Label.Location = new System.Drawing.Point(9, 12);
            Settings_Google_CSE_Api_Key_Label.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            Settings_Google_CSE_Api_Key_Label.Name = "Settings_Google_CSE_Api_Key_Label";
            Settings_Google_CSE_Api_Key_Label.Size = new System.Drawing.Size(110, 15);
            Settings_Google_CSE_Api_Key_Label.TabIndex = 18;
            Settings_Google_CSE_Api_Key_Label.Text = "Google CSE Apikey:";
            // 
            // About_TabPage
            // 
            About_TabPage.Location = new System.Drawing.Point(4, 24);
            About_TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            About_TabPage.Name = "About_TabPage";
            About_TabPage.Size = new System.Drawing.Size(1257, 678);
            About_TabPage.TabIndex = 8;
            About_TabPage.Text = "About";
            About_TabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1265, 706);
            Controls.Add(tabControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(1281, 745);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1281, 745);
            Name = "Form1";
            Text = "AcunetixHelperSoft";
            tabControl1.ResumeLayout(false);
            Google_CSE_Scraper_TabPage.ResumeLayout(false);
            Google_CSE_Scraper_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Google_CSE_Scraper_Export_To_Subfinder_PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Google_CSE_Scraper_Start_CSE_Search_PictureBox).EndInit();
            Google_CSE_Scraper_Settings_GroupBox.ResumeLayout(false);
            Google_CSE_Scraper_Settings_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown).EndInit();
            Subfinder_TabPage.ResumeLayout(false);
            Subfinder_TabPage.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Subfinder_Module_Start_Subdomain_Enumeration_PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Subfinder_Module_Threads_NumericUpDown).EndInit();
            Local_Database_TabPage.ResumeLayout(false);
            Local_Database_TabPage.PerformLayout();
            Local_Database_Other_Options.ResumeLayout(false);
            Acunetix_Importer_TabPage.ResumeLayout(false);
            Acunetix_Importer_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Acunetix_Importer_PictureBox).EndInit();
            Advanced_Acunetix_Operations_TabPage.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            Settings_TabPage.ResumeLayout(false);
            Settings_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Google_CSE_Scraper_TabPage;
        private System.Windows.Forms.TabPage Subfinder_TabPage;
        private System.Windows.Forms.TabPage Local_Database_TabPage;
        private System.Windows.Forms.TabPage Acunetix_Importer_TabPage;
        private System.Windows.Forms.TabPage Advanced_Acunetix_Operations_TabPage;
        private System.Windows.Forms.TabPage Settings_TabPage;
        private System.Windows.Forms.TabPage About_TabPage;
        private System.Windows.Forms.RichTextBox Google_CSE_Scraper_Keywords_RichTextBox;
        private System.Windows.Forms.Label Google_CSE_Scraper_Results_Label;
        private System.Windows.Forms.Label Google_CSE_Scraper_Keywords_Label;
        private System.Windows.Forms.Button Google_CSE_Scraper_Clear_Results_Button;
        private System.Windows.Forms.Button Google_CSE_Scraper_Clear_Keywords_Button;
        private System.Windows.Forms.Button Google_CSE_Scraper_Export_To_Subfinder_Button;
        private System.Windows.Forms.Button Google_CSE_Scraper_Start_CSE_Search_Button;
        private System.Windows.Forms.NumericUpDown Google_CSE_Scraper_Settings_Results_Per_Keyword_NumericUpDown;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Results_Per_Keyword_Label;
        private System.Windows.Forms.ComboBox Google_CSE_Scraper__Settings_Country_ComboBox;
        private System.Windows.Forms.ComboBox Google_CSE_Scraper_Settings_Language_ComboBox;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Country_Label;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Language_Label;
        private System.Windows.Forms.CheckedListBox Google_CSE_Scraper_Results_CheckedListBox;
        private System.Windows.Forms.GroupBox Google_CSE_Scraper_Settings_GroupBox;
        private System.Windows.Forms.Button Google_CSE_Scraper_Delete_Selected_Results_Button;
        private System.Windows.Forms.Label Google_CSE_Scraper_Query_Description_Label;
        private System.Windows.Forms.Label Google_CSE_Scraper_Dorking_Example_Label;
        private System.Windows.Forms.CheckedListBox Subfinder_Module_Domain_Results_CheckedListBox;
        private System.Windows.Forms.Label Subfinder_Module_Results_Label;
        private System.Windows.Forms.Label Subfinder_Module_Domains_Label;
        private System.Windows.Forms.RichTextBox Subfinder_Module_Domains_RichTextBox;
        private System.Windows.Forms.NumericUpDown Subfinder_Module_Threads_NumericUpDown;
        private System.Windows.Forms.Label Subfinder_Module_Threads_Amount_Label;
        private System.Windows.Forms.Button Subfinder_Module_Export_Subdomains_To_Httpx_Module_Button;
        private System.Windows.Forms.Button Subfinder_Module_Other_Options_Delete_Selected_Subdomains_Button;
        private System.Windows.Forms.Button Subfinder_Module_Clear_Subdomains_Button;
        private System.Windows.Forms.Button Subfinder_Module_Clear_Subfinder_Domains_Button;
        private System.Windows.Forms.Button Subfinder_Module_Start_Subfinder_Enumeration_Button;
        private System.Windows.Forms.Label Subfinder_Module_Domains_Processed_Label;
        private System.Windows.Forms.Button Subfinder_Module_Other_Options_Delete_gov_mil_arpa_Domains_Button;
        private System.Windows.Forms.Button Local_Database_Clear_Blacklist_Button;
        private System.Windows.Forms.Button Local_Database_Clear_Database_Button;
        private System.Windows.Forms.Button Local_Database_Export_All_Websites_To_Acunetix_Importer_Button;
        private System.Windows.Forms.Button Local_Database_Other_Options_Remove_Selected_Websites_From_Database_Button;
        private System.Windows.Forms.Button Local_Database_Other_Options_Export_Selected_Websits_To_Acunetix_Importer_Button;
        private System.Windows.Forms.Button Local_Database_Other_Options_Export_Selected_Websites_To_Blacklist_Button;
        private System.Windows.Forms.Button Local_Database_Other_Options_Export_Selected_Websites_To_Subfinder_Module_Button;
        private System.Windows.Forms.Button Local_Database_Other_Options_Export_All_Websites_To_Subfinder_Module_Button;
        private System.Windows.Forms.Label Acunetix_Importer_Targets_Count_Label;
        private System.Windows.Forms.RichTextBox Acunetix_Importer_Targets_RichTextBox;
        private System.Windows.Forms.Button Acunetix_Importer_Clear_Targets_Button;
        private System.Windows.Forms.ComboBox Acunetix_Importer_Scan_Profiles_ComboBox;
        private System.Windows.Forms.Button Acunetix_Importer_Add_To_Acunetix_And_Start_Selected_Scan_Button;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Label Local_Database_Blacklist_Label;
        private System.Windows.Forms.Label Settings_Subfinder_Location_Label;
        private System.Windows.Forms.Label Settings_Google_CSE_ID_Label;
        private System.Windows.Forms.Label Settings_Google_CSE_Api_Key_Label;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.MaskedTextBox Settings_Subfinder_Location_MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox Settings_CSE_ID_MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox Settings_CSE_Apikey_MaskedTextBox;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label Google_CSE_Scraper_Settings_Reminder_Label;
        private System.Windows.Forms.CheckedListBox Local_Database_Blacklist_CheckedListBox;
        private System.Windows.Forms.CheckedListBox Local_Database_Whitelist_CheckedListBox;
        private System.Windows.Forms.Button Subfinder_Module_Other_Options_Export_Selected_Subdomains_To_Local_Database_Button;
        private System.Windows.Forms.Button Subfinder_Module_Export_All_Subdomains_To_Local_Database_Button;
        private System.Windows.Forms.PictureBox Google_CSE_Scraper_Export_To_Subfinder_PictureBox;
        private System.Windows.Forms.PictureBox Google_CSE_Scraper_Start_CSE_Search_PictureBox;
        private System.Windows.Forms.PictureBox Subfinder_Module_Start_Subdomain_Enumeration_PictureBox;
        private System.Windows.Forms.PictureBox Subfinder_Module_Export_All_Subdomains_To_Local_Database_PictureBox;
        private System.Windows.Forms.GroupBox Local_Database_Other_Options;
        private System.Windows.Forms.PictureBox Acunetix_Importer_PictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Settings_Acunetix_Api_Url_Label;
        private System.Windows.Forms.MaskedTextBox Settings_Acunetix_Api_Key_MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox Settings_Acunetix_Api_URL_MaskedTextBox;
        private System.Windows.Forms.Label Settings_Acunetix_Api_Key_Label;
        private System.Windows.Forms.Button Settings_Save_Settings_Button;
    }
}

