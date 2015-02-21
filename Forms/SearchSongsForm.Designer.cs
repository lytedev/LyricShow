using System;
using System.Windows.Forms;

namespace LyricShow
{
    //public class MyTextBox : System.Windows.Forms.TextBox
    //{
    //    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    //    {
    //        const int WM_KEYDOWN = 0x100;
    //        const int WM_SYSKEYDOWN = 0x104;
    //        if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
    //        {
    //            switch (keyData)
    //            {
    //                case Keys.Down:
    //                case Keys.Left:
    //                    keyData = (System.Windows.Forms.Keys)241;
    //                    break;
    //                case Keys.Up:
    //                case Keys.Right:
    //                    keyData = (System.Windows.Forms.Keys)240;
    //                    break;
    //            }
    //        }
    //        return base.ProcessCmdKey(ref msg, keyData);
    //    }
    //}
    partial class SearchSongsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSongsForm));
            this.lstSongSearchResults = new System.Windows.Forms.ListBox();
            this.txtSongSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSongSearchResults
            // 
            this.lstSongSearchResults.FormattingEnabled = true;
            this.lstSongSearchResults.Location = new System.Drawing.Point(3, 62);
            this.lstSongSearchResults.Name = "lstSongSearchResults";
            this.lstSongSearchResults.Size = new System.Drawing.Size(281, 199);
            this.lstSongSearchResults.TabIndex = 2;
            this.lstSongSearchResults.DoubleClick += new System.EventHandler(this.lstSongSearchResults_DoubleClick);
            this.lstSongSearchResults.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lstSongSearchResults_PreviewKeyDown);
            // 
            // txtSongSearch
            // 
            this.txtSongSearch.Location = new System.Drawing.Point(3, 36);
            this.txtSongSearch.Name = "txtSongSearch";
            this.txtSongSearch.Size = new System.Drawing.Size(281, 20);
            this.txtSongSearch.TabIndex = 0;
            this.txtSongSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSongSearch.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search For Songs:";
            // 
            // SearchSongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSongSearch);
            this.Controls.Add(this.lstSongSearchResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchSongsForm";
            this.Text = "Song Search";
            this.Load += new System.EventHandler(this.SearchSongsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSongSearchResults;
        private System.Windows.Forms.TextBox txtSongSearch;
        private System.Windows.Forms.Label label1;
    }
}