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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSongDir.Text = LSGlobal.DefaultSongDir;
            txtSongIndex.Text = LSGlobal.DefaultSongIndexFile;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            LSGlobal.DefaultSongDir = txtSongDir.Text;
            LSGlobal.DefaultSongIndexFile = txtSongIndex.Text;
            this.Close();
        }

        private void btSongDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSongDir.Text = fbd.SelectedPath;
            }
        }

        private void btSongIndex_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSongIndex.Text = ofd.FileName;
            }
        }

    }
}
