/// LyricShow Project
/// Summary: Church Presentation Platform
/// 
/// by Daniel Flanagan [wraithx2@gmail.com]
/// and Michael Read [ikenread@gmail.com]
/// Version 1.0
/// 
/// Revision History
/// 1.0         Initial Version
/// 1.0.1       Michael Added:
///                 preferences page
///                 multiple display windows
///                 app settings
///
/// ---------------------------------------------------
/// 
/// Features
/// - Display formattable text on another monitor
/// - Easily switch to a different line using a listbox
/// - Shortcut keys for almost everything
/// - Define 'variables' in songs for easier mapping
/// - Create a list of songs for organization
/// - Song > Map / Verse > Text

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;


namespace LyricShow
{
    public partial class MainForm : Form
    {
        bool bScreensBlanked;
        Song song;
        List<ScreenForm> ScreenForms = new List<ScreenForm>();
        public MainForm()
        {
            InitializeComponent();
            AppSettings.LoadSettings();
            addDisplayOutputX("MainDisplay");
            if (LSGlobal.DefaultSongDir != null & LSGlobal.DefaultSongDir != "") {
                LSGlobal.si.BuildSongIndex(LSGlobal.DefaultSongDir);
            }
        }
        #region oldCode
        //private void MainForm_KeyDown(object sender, KeyEventArgs e)
        //{

        //}

        //private void MainForm_KeyUp(object sender, KeyEventArgs e)
        //{
            
        //}
        //private void switchScreenToolStripMenuItem_Click(object sender, EventArgs e) {
        //    ScreenForms[0].ChangeScreen();
        //}
#endregion
        private void addDisplayOutputX(String sfName)
        {
            DisplayScreenSettings dss = new DisplayScreenSettings();
            dss.EnableBackground = true;
            dss.ScreenLoc = new Point(Screen.PrimaryScreen.WorkingArea.Width - 800, 0);
            dss.ScreenSize = new Size(800, 600);
            dss.ScreenName = sfName;
            openScreen(dss);
        }
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e) {
            fontDialog.Font = ScreenForms[0].lblText.Font;
            if (fontDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                updateScreensFont(fontDialog.Font);
            }
        }
        private void changeVerseList(Song song)
        {
            lstSong.Items.Clear();
            if (lstPlaylist.SelectedIndex > 0) { lstSong.Items.Add("<-Previous Song->"); }
            for (int i = 0; i < song.Verses.Count; i++)
            {
                lstSong.Items.Add(/*song.VerseKeys[i] + " - " + */song.Verses[i]);
            }
            /*foreach (string s in song.Verses)
            {
                lstSong.Items.Add(s);
            }*/
            lstSong.SelectedIndex = 1;
            if (lstPlaylist.SelectedIndex < lstPlaylist.Items.Count - 1) { lstSong.Items.Add("<-Next Song->"); }

            ToolStripSong_Click(this, null);
        }
        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            changeVerseList((Song)lstPlaylist.SelectedItem);
        }
        private void lstSong_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstSong.SelectedItem.ToString() == "<-Previous Song->") { 
                lstPlaylist.SelectedIndex = lstPlaylist.SelectedIndex - 1;
                changeVerseList((Song)lstPlaylist.SelectedItem);
                lstSong.SelectedIndex = lstSong.Items.Count - 2;
            }
            if (lstSong.SelectedItem.ToString() == "<-Next Song->")
            { 
                lstPlaylist.SelectedIndex = lstPlaylist.SelectedIndex + 1;
                changeVerseList((Song)lstPlaylist.SelectedItem);
            }

            updateScreens();
        }
        #region deadCode
        //private void MainForm_GotFocus(object sender, EventArgs e)
        //{
        //    if (isSettingFocus ==false)
        //    {
        //        isSettingFocus = true;
        //        foreach (ScreenForm sf in ScreenForms)
        //        {
        //            sf.Focus();
        //        }
        //        //should check this to see which label needs the focus
        //        if (lstSong.Visible == true)
        //        {
        //            this.lstSong.Focus();
        //        }
        //        else
        //        {
        //            this.lstPlaylist.Focus();
        //        }
        //        isSettingFocus = false;
        //    }
        //}
        #endregion
        private void openScreen(DisplayScreenSettings dss)
        {
            ScreenForm sf = new ScreenForm(dss.ScreenName, dss.EnableBackground);
            sf.Size = dss.ScreenSize;
            sf.Location = dss.ScreenLoc;
            sf.Visible = LSGlobal.ScreensVisible;
            sf.Size = dss.ScreenSize;
            sf.Location = dss.ScreenLoc;
            sf.lblText.LSFont = sf.lblText.Font;

            sf.LSBackgroundImage = LSGlobal.DefaultBackgroundImage;

            ScreenForms.Add(sf);
            if (lstSong.Items.Count > 0){ updateScreens(); }
        }
        private void openSongFile(String FileName) {
            song = new Song();
            song.Open(FileName);
            
            if (song.Name != "")
            {
                int iPlayIndex = lstPlaylist.Items.Add(song);
                lstPlaylist.SelectedIndex = iPlayIndex;
                changeVerseList(song);
            }
        }
        private void ScreenShow(ScreenForm s)
        {
            if (s.IsDisposed == false)
            {
                s.Show();
            }
            this.Focus();
        }
        private void ScreenHide(ScreenForm s)
        {
            s.Hide();
        }
        private void ScreenClose(ScreenForm s)
        {
            s.Close();
        }
        private void ToolStripAbout_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }
        private void ToolStripAddDisplayOutput_Click(object sender, EventArgs e)
        {
            InputBox input = new InputBox();
            string sfName = input.Show("Please Enter a unique name for the window.");
            addDisplayOutputX(sfName);
            ToolStripPlaySlideShow_Click(this, null);
        }
        private void ToolStripEndSlideShow_Click(object sender, EventArgs e)
        {
            ScreenForms.ForEach(delegate(ScreenForm s) { ScreenHide(s); });
            LSGlobal.ScreensVisible = false;
            playSlideShowToolStripMenuItem.Visible = true;
            endSlideShowToolStripMenuItem.Visible = false;
        }
        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                openSongFile(ofd.FileName);
            }
        }
        private void ToolStripOpenSavedDisplays_Click(object sender, EventArgs e)
        {
            List<DisplayScreenSettings> dss = LSGlobal.SavedDisplayScreens;
            LSGlobal.ScreensVisible = true;
            ScreenForms.ForEach(delegate(ScreenForm s) { ScreenClose(s); });
            ScreenForms = new List<ScreenForm>();
            foreach (DisplayScreenSettings ss in dss)
            {
                openScreen(ss);
            }
            ToolStripPlaySlideShow_Click(this, null);
        }
        private void ToolStripPlaylist_Click(object sender, EventArgs e)
        {
            lstSong.Hide();
            lstPlaylist.Show();
            playlistToolStripMenuItem1.Visible = true;
        }
        private void ToolStripPlaySlideShow_Click(object sender, EventArgs e)
        {
            ScreenForms.ForEach(delegate(ScreenForm s) { ScreenShow(s); });
            LSGlobal.ScreensVisible = true;
            ScreenForms.ForEach(delegate(ScreenForm s) { if (lstSong.Items.Count > 0) { s.lblText.SongText = /*lstSong.SelectedItem.ToString();*/ song.Verses[lstSong.SelectedIndex]; } });
            playSlideShowToolStripMenuItem.Visible = false;
            endSlideShowToolStripMenuItem.Visible = true;
        }
        private void ToolStripPreferences_Click(object sender, EventArgs e)
        {
            SettingsForm f = new SettingsForm();
            f.ShowDialog();
        }
        private void ToolStripRemoveSelected_Click(object sender, EventArgs e)
        {
            int x = lstPlaylist.SelectedIndex;
            int y = lstPlaylist.Items.Count;
            if (y == 1) { lstSong.Items.Clear(); }
            lstPlaylist.Items.Remove(lstPlaylist.SelectedItem);
            if (lstPlaylist.Items.Count > 0)
            {
                lstPlaylist.SelectedIndex = x - 1;
            }
        }
        private void ToolStripSaveDisplaySettings_Click(object sender, EventArgs e)
        {
            List<DisplayScreenSettings> dss = getCurrentScreenSettings();
            LSGlobal.SavedDisplayScreens = dss;
        }
        private void ToolStripSearchSongs_Click(object sender, EventArgs e)
        {
            SearchSongsForm ssf = new SearchSongsForm();
            ssf.ShowDialog();
            String ss = ssf.SelectedSongFile;
            if (ss != "")
            {
                openSongFile(ss);
            }
            ssf.Close();
        }
        private void ToolStripSong_Click(object sender, EventArgs e)
        {
            lstPlaylist.Hide();
            lstSong.Show();
            playlistToolStripMenuItem1.Visible = false;
        }
        private void updateScreens()
        {
            for (int i = 0; i < ScreenForms.Count; i++)
            {
                ScreenForms[i].lblText.SongText = lstSong.SelectedItem.ToString();
                Song currentSong = (Song)lstPlaylist.SelectedItem;
                ScreenForms[i].LSBackgroundImage = getFullBackgroundPath(currentSong.BackgroundPath);
                ScreenForms[i].AdjustLabels();
            }
        }
        private void updateScreensFont(Font f)
        {
            for (int i = 0; i < ScreenForms.Count; i++)
            {
                ScreenForms[i].lblText.LSFont = f;
            }
        }
        private List<DisplayScreenSettings> getCurrentScreenSettings()
        {
            List<DisplayScreenSettings> dss = new List<DisplayScreenSettings>();
            for (int i = 0; i < ScreenForms.Count; i++)
            {
                DisplayScreenSettings dssX = new DisplayScreenSettings();
                dssX.ScreenIndex = i;
                dssX.ScreenLoc = ScreenForms[i].Location;
                dssX.ScreenName = ScreenForms[i].ScreenName;
                dssX.ScreenSize = ScreenForms[i].Size;
                dssX.EnableBackground = ScreenForms[i].EnableBackground;
                if (ScreenForms[i].Visible == true) {
                dss.Add(dssX);
                }
            }
            return dss;
        }
        private string getFullBackgroundPath(String s)
        {
            if (s.Length > 0)
            {
                FileInfo fi = new FileInfo(s);

                if (fi.Exists == true)
                {
                    return fi.FullName;
                }
                else
                {
                    fi = new FileInfo(LSGlobal.DefaultBackgroundDir + s);
                    if (fi.Exists == true) { return fi.FullName; } else { return null; }
                }
            }
            else
            {
                return null;
            }
        }
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Song currentSong = (Song)lstPlaylist.SelectedItem;
            if (currentSong != null) {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = currentSong.FileName;
                p.Start();
            }
        }

        private void reloadSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstPlaylist.Items.Count; i++)
            {
                Song s = new Song();
                s.Open(((Song)lstPlaylist.Items[i]).FileName);
                lstPlaylist.Items[i] = s;
                changeVerseList(s);
            }
        }

        private void savePlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream outFile;
            String fiName = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "LyricShow Playlist (*.plt)|*.plt|All Files (*.*)|*.*";
            sfd.RestoreDirectory = true; 
            if (sfd.ShowDialog() == DialogResult.OK) 
            {
                if ((outFile = sfd.OpenFile()) != null)
                {
                    //  do something here to make sure the file doesn't already 
                    //exist as a different type of file.
                    for (int i = 0; i < lstPlaylist.Items.Count; i++)
                    {
                        fiName += ((Song)lstPlaylist.Items[i]).FileName;
                        fiName += "\r\n";
                        
                    }
                    StreamWriter xWriter = new StreamWriter(outFile);
                    xWriter.WriteLine(fiName);
                    xWriter.Close();
                }
            }
        }

        private void betaInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUITest BetaUI = new GUITest();
            BetaUI.ShowDialog();
            this.Close();
        }

        private void openPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "LyricShow Playlist (*.plt)|*.plt|All Files (*.*)|*.*";
            if (ofd.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                openSongFile(ofd.FileName);
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                lstPlaylist.Items.Clear();
                while (!(sr.EndOfStream))
                {
                    string sLine = sr.ReadLine().Trim();
                    Song s = new Song();
                    s.Open(sLine);
                    lstPlaylist.Items.Add(s);
                }
                sr.Close();
                fs.Close();

            }
            lstPlaylist.SelectedIndex = 0;
            changeVerseList((Song)lstPlaylist.Items[0]);
        }

        private void lstPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
