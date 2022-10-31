namespace BetterDiscordPluginCleaner
{
    partial class GUI
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.fileListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedBtn = new System.Windows.Forms.Button();
            this.resetSelectedBtn = new System.Windows.Forms.Button();
            this.cleanUnusedBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.resetAllBtn = new System.Windows.Forms.Button();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.choosePathBtn = new System.Windows.Forms.Button();
            this.restoreDefaultBtn = new System.Windows.Forms.Button();
            this.closeSettingsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pluginPathTbx = new System.Windows.Forms.TextBox();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.fileListBoxContextMenu.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileListBox
            // 
            this.fileListBox.ContextMenuStrip = this.fileListBoxContextMenu;
            this.fileListBox.Enabled = false;
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(13, 13);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(286, 342);
            this.fileListBox.TabIndex = 0;
            // 
            // fileListBoxContextMenu
            // 
            this.fileListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.fileListBoxContextMenu.Name = "fileListBoxContextMenu";
            this.fileListBoxContextMenu.Size = new System.Drawing.Size(114, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // deleteSelectedBtn
            // 
            this.deleteSelectedBtn.Enabled = false;
            this.deleteSelectedBtn.Location = new System.Drawing.Point(12, 361);
            this.deleteSelectedBtn.Name = "deleteSelectedBtn";
            this.deleteSelectedBtn.Size = new System.Drawing.Size(93, 23);
            this.deleteSelectedBtn.TabIndex = 1;
            this.deleteSelectedBtn.Text = "Delete selected";
            this.deleteSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // resetSelectedBtn
            // 
            this.resetSelectedBtn.Enabled = false;
            this.resetSelectedBtn.Location = new System.Drawing.Point(111, 361);
            this.resetSelectedBtn.Name = "resetSelectedBtn";
            this.resetSelectedBtn.Size = new System.Drawing.Size(112, 23);
            this.resetSelectedBtn.TabIndex = 2;
            this.resetSelectedBtn.Text = "Reset selected data";
            this.resetSelectedBtn.UseVisualStyleBackColor = true;
            // 
            // cleanUnusedBtn
            // 
            this.cleanUnusedBtn.Enabled = false;
            this.cleanUnusedBtn.Location = new System.Drawing.Point(13, 390);
            this.cleanUnusedBtn.Name = "cleanUnusedBtn";
            this.cleanUnusedBtn.Size = new System.Drawing.Size(135, 23);
            this.cleanUnusedBtn.TabIndex = 3;
            this.cleanUnusedBtn.Text = "Clean unused config files";
            this.cleanUnusedBtn.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(224, 361);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(75, 23);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // resetAllBtn
            // 
            this.resetAllBtn.Enabled = false;
            this.resetAllBtn.Location = new System.Drawing.Point(12, 419);
            this.resetAllBtn.Name = "resetAllBtn";
            this.resetAllBtn.Size = new System.Drawing.Size(75, 23);
            this.resetAllBtn.TabIndex = 5;
            this.resetAllBtn.Text = "Reset All";
            this.resetAllBtn.UseVisualStyleBackColor = true;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.Enabled = false;
            this.deleteAllBtn.Location = new System.Drawing.Point(93, 419);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteAllBtn.TabIndex = 6;
            this.deleteAllBtn.Text = "Delete All";
            this.deleteAllBtn.UseVisualStyleBackColor = true;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.choosePathBtn);
            this.settingsPanel.Controls.Add(this.restoreDefaultBtn);
            this.settingsPanel.Controls.Add(this.closeSettingsBtn);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.pluginPathTbx);
            this.settingsPanel.Controls.Add(this.saveSettingsBtn);
            this.settingsPanel.Location = new System.Drawing.Point(29, 141);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(254, 90);
            this.settingsPanel.TabIndex = 7;
            this.settingsPanel.Visible = false;
            // 
            // choosePathBtn
            // 
            this.choosePathBtn.Location = new System.Drawing.Point(5, 61);
            this.choosePathBtn.Name = "choosePathBtn";
            this.choosePathBtn.Size = new System.Drawing.Size(57, 23);
            this.choosePathBtn.TabIndex = 5;
            this.choosePathBtn.Text = "Choose";
            this.choosePathBtn.UseVisualStyleBackColor = true;
            // 
            // restoreDefaultBtn
            // 
            this.restoreDefaultBtn.Location = new System.Drawing.Point(68, 61);
            this.restoreDefaultBtn.Name = "restoreDefaultBtn";
            this.restoreDefaultBtn.Size = new System.Drawing.Size(57, 23);
            this.restoreDefaultBtn.TabIndex = 4;
            this.restoreDefaultBtn.Text = "Default";
            this.restoreDefaultBtn.UseVisualStyleBackColor = true;
            // 
            // closeSettingsBtn
            // 
            this.closeSettingsBtn.Location = new System.Drawing.Point(192, 61);
            this.closeSettingsBtn.Name = "closeSettingsBtn";
            this.closeSettingsBtn.Size = new System.Drawing.Size(57, 23);
            this.closeSettingsBtn.TabIndex = 3;
            this.closeSettingsBtn.Text = "Close";
            this.closeSettingsBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BetterDiscord plugin directory";
            // 
            // pluginPathTbx
            // 
            this.pluginPathTbx.Location = new System.Drawing.Point(3, 20);
            this.pluginPathTbx.Multiline = true;
            this.pluginPathTbx.Name = "pluginPathTbx";
            this.pluginPathTbx.ReadOnly = true;
            this.pluginPathTbx.Size = new System.Drawing.Size(248, 35);
            this.pluginPathTbx.TabIndex = 1;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(129, 61);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(57, 23);
            this.saveSettingsBtn.TabIndex = 0;
            this.saveSettingsBtn.Text = "Save";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.deleteAllBtn);
            this.Controls.Add(this.resetAllBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.cleanUnusedBtn);
            this.Controls.Add(this.resetSelectedBtn);
            this.Controls.Add(this.deleteSelectedBtn);
            this.Controls.Add(this.fileListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BD Plugin Cleaner";
            this.fileListBoxContextMenu.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button deleteSelectedBtn;
        private System.Windows.Forms.Button resetSelectedBtn;
        private System.Windows.Forms.Button cleanUnusedBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button resetAllBtn;
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.ContextMenuStrip fileListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button choosePathBtn;
        private System.Windows.Forms.Button restoreDefaultBtn;
        private System.Windows.Forms.Button closeSettingsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pluginPathTbx;
        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

