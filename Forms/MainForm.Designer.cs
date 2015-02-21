using System.Windows.Forms;
namespace LyricShow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openSavedDisplaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDisplaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDisplayOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endSlideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betaInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstSong = new System.Windows.Forms.ListBox();
            this.lstPlaylist = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem1,
            this.playlistToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.searchSongsToolStripMenuItem,
            this.toolStripSeparator2,
            this.savePlaylistToolStripMenuItem,
            this.openPlaylistToolStripMenuItem,
            this.toolStripSeparator1,
            this.openSavedDisplaysToolStripMenuItem,
            this.saveDisplaySettingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // searchSongsToolStripMenuItem
            // 
            this.searchSongsToolStripMenuItem.Name = "searchSongsToolStripMenuItem";
            this.searchSongsToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.searchSongsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.searchSongsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.searchSongsToolStripMenuItem.Text = "&Find Song";
            this.searchSongsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripSearchSongs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // savePlaylistToolStripMenuItem
            // 
            this.savePlaylistToolStripMenuItem.Name = "savePlaylistToolStripMenuItem";
            this.savePlaylistToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.savePlaylistToolStripMenuItem.Text = "Save Playlist";
            this.savePlaylistToolStripMenuItem.Click += new System.EventHandler(this.savePlaylistToolStripMenuItem_Click);
            // 
            // openPlaylistToolStripMenuItem
            // 
            this.openPlaylistToolStripMenuItem.Name = "openPlaylistToolStripMenuItem";
            this.openPlaylistToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openPlaylistToolStripMenuItem.Text = "Open Playlist";
            this.openPlaylistToolStripMenuItem.Click += new System.EventHandler(this.openPlaylistToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // openSavedDisplaysToolStripMenuItem
            // 
            this.openSavedDisplaysToolStripMenuItem.Name = "openSavedDisplaysToolStripMenuItem";
            this.openSavedDisplaysToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.openSavedDisplaysToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openSavedDisplaysToolStripMenuItem.Text = "Open Saved Displays";
            this.openSavedDisplaysToolStripMenuItem.Click += new System.EventHandler(this.ToolStripOpenSavedDisplays_Click);
            // 
            // saveDisplaySettingsToolStripMenuItem
            // 
            this.saveDisplaySettingsToolStripMenuItem.Name = "saveDisplaySettingsToolStripMenuItem";
            this.saveDisplaySettingsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveDisplaySettingsToolStripMenuItem.Text = "Save Display Settings";
            this.saveDisplaySettingsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripSaveDisplaySettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(199, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.changeFontToolStripMenuItem,
            this.switchScreenToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.editToolStripMenuItem1.Text = "&Song";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.F)));
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.changeFontToolStripMenuItem.Text = "Change &Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // switchScreenToolStripMenuItem
            // 
            this.switchScreenToolStripMenuItem.Name = "switchScreenToolStripMenuItem";
            this.switchScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.switchScreenToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.switchScreenToolStripMenuItem.Text = "&Switch Screen";
            this.switchScreenToolStripMenuItem.Visible = false;
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.ToolStripPreferences_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.addDisplayOutputToolStripMenuItem,
            this.playSlideShowToolStripMenuItem,
            this.endSlideShowToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.toolStripMenuItem1.Text = "&View";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.songToolStripMenuItem.Text = "Song";
            this.songToolStripMenuItem.Click += new System.EventHandler(this.ToolStripSong_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.ToolStripPlaylist_Click);
            // 
            // addDisplayOutputToolStripMenuItem
            // 
            this.addDisplayOutputToolStripMenuItem.Name = "addDisplayOutputToolStripMenuItem";
            this.addDisplayOutputToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addDisplayOutputToolStripMenuItem.Text = "Add Display Output";
            this.addDisplayOutputToolStripMenuItem.Click += new System.EventHandler(this.ToolStripAddDisplayOutput_Click);
            // 
            // playSlideShowToolStripMenuItem
            // 
            this.playSlideShowToolStripMenuItem.Name = "playSlideShowToolStripMenuItem";
            this.playSlideShowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.playSlideShowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.playSlideShowToolStripMenuItem.Text = "Play SlideShow";
            this.playSlideShowToolStripMenuItem.Click += new System.EventHandler(this.ToolStripPlaySlideShow_Click);
            // 
            // endSlideShowToolStripMenuItem
            // 
            this.endSlideShowToolStripMenuItem.Name = "endSlideShowToolStripMenuItem";
            this.endSlideShowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.endSlideShowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.endSlideShowToolStripMenuItem.Text = "End Slide Show";
            this.endSlideShowToolStripMenuItem.Visible = false;
            this.endSlideShowToolStripMenuItem.Click += new System.EventHandler(this.ToolStripEndSlideShow_Click);
            // 
            // playlistToolStripMenuItem1
            // 
            this.playlistToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedToolStripMenuItem,
            this.reloadSongsToolStripMenuItem});
            this.playlistToolStripMenuItem1.Name = "playlistToolStripMenuItem1";
            this.playlistToolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.playlistToolStripMenuItem1.Text = "&Playlist";
            this.playlistToolStripMenuItem1.Visible = false;
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.removeSelectedToolStripMenuItem.Text = "Remove Selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.ToolStripRemoveSelected_Click);
            // 
            // reloadSongsToolStripMenuItem
            // 
            this.reloadSongsToolStripMenuItem.Name = "reloadSongsToolStripMenuItem";
            this.reloadSongsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadSongsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reloadSongsToolStripMenuItem.Text = "Reload Songs";
            this.reloadSongsToolStripMenuItem.Click += new System.EventHandler(this.reloadSongsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.betaInterfaceToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ToolStripAbout_Click);
            // 
            // betaInterfaceToolStripMenuItem
            // 
            this.betaInterfaceToolStripMenuItem.Name = "betaInterfaceToolStripMenuItem";
            this.betaInterfaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.Z)));
            this.betaInterfaceToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.betaInterfaceToolStripMenuItem.Text = "Beta Interface";
            this.betaInterfaceToolStripMenuItem.Click += new System.EventHandler(this.betaInterfaceToolStripMenuItem_Click);
            // 
            // lstSong
            // 
            this.lstSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSong.FormattingEnabled = true;
            this.lstSong.ItemHeight = 15;
            this.lstSong.Location = new System.Drawing.Point(0, 24);
            this.lstSong.Margin = new System.Windows.Forms.Padding(0);
            this.lstSong.Name = "lstSong";
            this.lstSong.Size = new System.Drawing.Size(290, 502);
            this.lstSong.TabIndex = 1;
            this.lstSong.SelectedIndexChanged += new System.EventHandler(this.lstSong_SelectedIndexChanged);
            this.lstSong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSong_KeyDown);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylist.FormattingEnabled = true;
            this.lstPlaylist.ItemHeight = 15;
            this.lstPlaylist.Location = new System.Drawing.Point(0, 24);
            this.lstPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(290, 502);
            this.lstPlaylist.TabIndex = 1;
            this.lstPlaylist.Visible = false;
            this.lstPlaylist.SelectedIndexChanged += new System.EventHandler(this.lstPlaylist_SelectedIndexChanged);
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(290, 526);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.lstSong);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "LSProjection";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void MainForm_Load(object sender, System.EventArgs e)
        {
            bScreensBlanked = false;
        }

        void lstSong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left)
            {
                if (lstSong.Items.Count > 0 & lstSong.SelectedIndex != lstSong.Items.Count - 1) { lstSong.SelectedIndex = lstSong.SelectedIndex + 1; }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.PageUp || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right)
            {
                if (lstSong.Items.Count > 0 & lstSong.SelectedIndex != 0) { lstSong.SelectedIndex = lstSong.SelectedIndex - 1; }
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Pause)
            {
                if (bScreensBlanked)
                {
                    foreach (ScreenForm s in ScreenForms)
                    {
                        s.remBlankScreen();
                        bScreensBlanked = false;
                    }
                }
                else
                {
                    foreach (ScreenForm s in ScreenForms)
                    {
                        s.blankScreen();
                        bScreensBlanked = true;
                    }
                }
                e.Handled = true;
            }
            //prevent keys from switching items in the list
            e.Handled = true;
        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListBox lstSong;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchSongsToolStripMenuItem;
        private System.Windows.Forms.ListBox lstPlaylist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSlideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endSlideShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDisplayOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDisplaySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSavedDisplaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem savePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betaInterfaceToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem quitToolStripMenuItem;

    }
}

