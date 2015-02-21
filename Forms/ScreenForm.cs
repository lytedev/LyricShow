using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LyricShow
{
    public partial class ScreenForm : Form
    {
        //oldCode private bool onScreen = false;

        public ScreenForm(String sScreenName, Boolean bEnableBackground)
        {
            ScreenName = sScreenName;
            EnableBackground = bEnableBackground;
            InitializeComponent();
            if (EnableBackground) { LSBackgroundImage = LSGlobal.DefaultBackgroundImage; }
        }

        Point mouseXY = new Point(0, 0);
        bool mouseIsDown = false;
        public bool EnableBackground;
        public String ScreenName;

        #region oldCode
        //public void ChangeScreen()
        //{
        //    if (onScreen)
        //    {
        //        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 0);
        //        onScreen = false;
        //    }
        //    else
        //    {
        //        this.Location = new Point(Screen.PrimaryScreen.Bounds.Width, 0);
        //        onScreen = true;
        //    }
        //}
        #endregion
        public void blankScreen()
        {
            Label BlankingLabel = new Label();
            BlankingLabel.BackColor = Color.Black;
            BlankingLabel.Dock = DockStyle.Fill;
            BlankingLabel.Name = "BlankingLabel";
            this.Controls.Add(BlankingLabel);
            Control[] BlankingControl = this.Controls.Find("BlankingLabel", true);
            foreach (Label l in BlankingControl)
            {
                l.BringToFront();
            }
        }
        public void remBlankScreen()
        {
            Control[] BlankingControl = this.Controls.Find("BlankingLabel", true);
            foreach (Control ctl in BlankingControl)
            {
                this.Controls.Remove(ctl);
            }
            
        }
        private void lblText_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1 ) //this will cause the form to move slightly before maximizing, but hardly noticeable
            {
                mouseIsDown = true;
            }
            mouseXY = new Point(e.X, e.Y);
        }
        private void lblText_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                this.Left += (e.X - mouseXY.X);
                this.Top += (e.Y - mouseXY.Y);
            }
        }
        private void lblText_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void lblText_DoubleClick(object sender, EventArgs e)
        {
            this.Location = Screen.FromPoint(this.Location).WorkingArea.Location;
            //this.Top = 0;
            //this.Left = 0;
            this.Width = Screen.FromPoint(this.Location).WorkingArea.Width;
            this.Height = Screen.FromPoint(this.Location).WorkingArea.Height;
            AdjustLabels();
        }
        public void AdjustLabels()
        {
            //this.lblShadow.Height = this.lblText.Height - 3;
            //this.lblShadow.Width = this.lblText.Width - 3;
            //this.lblShadow.Left = this.lblText.Left + 3;
            //this.lblShadow.Top = this.lblText.Top + 3;
            this.lblText.Size = this.ClientSize;
            this.lblText.LSFont = this.lblText.Font;
            this.Invalidate();
        }
        private void ScreenForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    this.Width = Convert.ToInt32(this.Width * .95);
                    this.Height = Convert.ToInt32(this.Height * .95);
                    AdjustLabels();
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    this.Width = Convert.ToInt32(this.Width * 1.05);
                    this.Height = Convert.ToInt32(this.Height * 1.05);
                    AdjustLabels();
                    break;
            }
        }
    }
}
