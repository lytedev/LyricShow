using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LyricShow
{


    public partial class SearchSongsForm : Form
    {
        public SearchSongsForm()
        {
            InitializeComponent();
        }
        private String _SelectedSongFile = "";
        public String SelectedSongFile
        {
            get { return _SelectedSongFile; }
        }

        private void SearchSongsForm_Load(object sender, EventArgs e)
        {

        }

        private void lstSongSearchResults_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    _SelectedSongFile = "";
                    this.Hide();
                    break;
                case Keys.Return:
                    lstSongSearchResults_DoubleClick(sender, null);
                    break;
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Right:
                    if (lstSongSearchResults.SelectedIndex < lstSongSearchResults.Items.Count - 1)
                    {
                        lstSongSearchResults.SelectedIndex = (lstSongSearchResults.SelectedIndex + 1);
                        lstSongSearchResults.Select();
                    }
                    break;
                case Keys.Up:
                case Keys.Left:
                    if (lstSongSearchResults.SelectedIndex > 0)
                    {
                        lstSongSearchResults.SelectedIndex = (lstSongSearchResults.SelectedIndex - 1);
                        lstSongSearchResults.Select();
                    }
                    break;
            }
            lstSongSearchResults_PreviewKeyDown(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                String t = txtSongSearch.Text;
                Song[] SearchResults = LSGlobal.si.Songs.FindAll(FindSong).ToArray();
                lstSongSearchResults.DataSource =  SearchResults;
                lstSongSearchResults.DisplayMember = "Name";
        }
        private bool FindSong(Song sng)
        {
            if (sng.Name.ToUpper().Contains(txtSongSearch.Text.ToUpper()) == true) { return true; } { return false; }
        }

        private void lstSongSearchResults_DoubleClick(object sender, EventArgs e)
        {
            Song lsSelectedSong = (Song)lstSongSearchResults.SelectedValue;
            if (lsSelectedSong != null) { _SelectedSongFile = lsSelectedSong.FileName; }
            this.Hide();
        }
    }
}
