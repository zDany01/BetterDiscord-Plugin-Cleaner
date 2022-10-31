using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterDiscordPluginCleaner
{
    public partial class GUI : Form
    {
        const string APP_NAME = "BetterDiscord Plugin Checker";
        private readonly string bdDefaultPluginPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BetterDiscord\\plugins";
        private string _bdplugindirectory = null;
        public string BDPluginDirectory
        {
            get => Directory.Exists(_bdplugindirectory) ? _bdplugindirectory : null;
            set
            {
#if DEBUG
                Debug.WriteLine($"[DEBUG] Changing directory from \"{_bdplugindirectory ?? "NULL"}\" to \"{value}\"");
#endif
                _bdplugindirectory = value;
                pluginPathTbx.Text = value;
#if DEBUG
                int DEBUG_pluginNumber = Directory.GetFiles(value).Where<string>(fileName => fileName.EndsWith(".plugin.js")).Count();
                if (DEBUG_pluginNumber > 0)
                {
                    Debug.WriteLine($"[DEBUG] Valid directory found, plugin number: {DEBUG_pluginNumber}");
                    SetEnableStatus(true);
                }
#else
                if(Directory.GetFiles(value).Where<string>(fileName => fileName.EndsWith(".plugin.js")).Count() > 0) SetEnableStatus(true);
#endif
                else
                {

#if DEBUG
                    Debug.WriteLine("[DEBUG] Invalid Directory");
#endif
                    MessageBox.Show("No plugins found\nMake sure to have selected the right directory!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetEnableStatus(false);
                }
            }
        }
        public GUI()
        {
            InitializeComponent();
            this.KeyDown += GUI_KeyDown;
            this.Load += GUI_Load;
            settingsBtn.Click += (_, _2) => settingsPanel.Show();
            closeSettingsBtn.Click += CancelSettingsBtn_Click;
            restoreDefaultBtn.Click += RestoreDefaultBtn_Click;
            choosePathBtn.Click += ChoosePathBtn_Click;
            saveSettingsBtn.Click += SaveSettingsBtn_Click;

        }

        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("I will be in the next commit :)");
        }

        private void ChoosePathBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) BDPluginDirectory = folderBrowserDialog.SelectedPath;
        }

        private void RestoreDefaultBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(bdDefaultPluginPath))
            {
                BDPluginDirectory = bdDefaultPluginPath;
                pluginPathTbx.Text = bdDefaultPluginPath;
                MessageBox.Show("Restored default directory.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelSettingsBtn_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void SetEnableStatus(bool enableStatus)
        {
            fileListBox.Enabled = enableStatus;
            cleanUnusedBtn.Enabled = enableStatus;
            deleteAllBtn.Enabled = enableStatus;
            deleteSelectedBtn.Enabled = enableStatus;
            resetAllBtn.Enabled = enableStatus;
            resetSelectedBtn.Enabled = enableStatus;
        }

        private void GUI_Load(object sender, EventArgs e)
        {

            if (Directory.Exists(bdDefaultPluginPath)) BDPluginDirectory = bdDefaultPluginPath;
#if DEBUG
            PrintDebugInfo();
#endif



        }

        private void GUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) if (settingsPanel.Visible) settingsPanel.Hide(); else Close();
#if DEBUG
            if (e.KeyData == Keys.F6) PrintDebugInfo();
            else if (e.KeyData == Keys.F7) PrintFoundPlugin();
#endif
        }




#if DEBUG
        void PrintDebugInfo()
        {
            Debug.WriteLine($@"
[DEBUG INFO]
App Version: {Application.ProductVersion}
BetterDiscord Default Path: {(Directory.Exists(bdDefaultPluginPath) ? bdDefaultPluginPath : "❌")}
BetterDiscord Folder: {BDPluginDirectory ?? "NOT SET (All disabled)"}
Plugins number: {(BDPluginDirectory is null ? "❌" : Directory.GetFiles(BDPluginDirectory).Where<string>(fileName => fileName.EndsWith(".plugin.js")).Count().ToString())}
            ");
        }

        void PrintFoundPlugin()
        {
            Debug.Write("\n[DEBUG INFO]\nPlugin List:\n");
            foreach (string pluginFileName in Directory.GetFiles(BDPluginDirectory).Where<string>(fileName => fileName.EndsWith(".plugin.js"))) Debug.WriteLine(pluginFileName.Substring(pluginFileName.LastIndexOf('\\') + 1, pluginFileName.Length - 11 - pluginFileName.LastIndexOf('\\')));
        }
#endif
    }
}
