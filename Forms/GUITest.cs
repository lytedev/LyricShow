using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LyricShow
{
    public partial class GUITest : Form
    {
        FlowLayoutPanel pnlSlides = new FlowLayoutPanel();
        CustomControls.ControlSlider cs = new CustomControls.ControlSlider();
        public GUITest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pnlSlides.AutoSize = true;
            //pnlSlides.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //SplitContainer.Panel2
            //SplitContainer.Resize += new EventHandler(ResizePanel);
            cs.Dock = DockStyle.Bottom;
            cs.Top = 50;
            cs.Height = 200;
            cs.Width = 350;
            cs.BorderStyle = BorderStyle.Fixed3D;
            cs.BackColor = Color.White;
            cs.AnimateSlideSelection = false;
            cs.ControlSizing = CustomControls.ControlSizingStyles.ResizeBoth;
            //this.SplitContainer.Panel1.AutoScroll = true;
            this.Controls.Add(cs);
        }
        #region oldCode
        //pnlPreview.AutoScroll = true;
            //pnlSlides.ControlAdded += new ControlEventHandler(ResizePanel);
            //pnlSlides.ControlRemoved += new ControlEventHandler(ResizePanel);
            //pnlSlides.BackColor = Color.Turquoise;
            //pnlSlides.Margin = new Padding(0, 0, 0, 0);
            //pnlSlides.WrapContents = false;
            //pnlPreview.Controls.Add(pnlSlides);
        //}

        //private void ResizePanel(object oPanel, ControlEventArgs e)
        //{
        //    FlowLayoutPanel pnl = (FlowLayoutPanel)oPanel;
        //    int w = pnl.Width;
        //    int m = pnl.Margin.Top;
        //    if (pnl.Parent.Width > pnl.Width)  // make sure we don't adjust position if it fills entire space
        //    {
        //        pnl.Margin = new Padding((pnl.Parent.Width - pnl.Width) / 2, m, m, m);
        //    }
        //    else
        //    {
        //        pnl.Margin = new Padding(m);
        //    }
        //    pnl.Width = ((pnl.Height) * pnl.Controls.Count) + 5;
        //}
#endregion

        private void button1_Click(object sender, EventArgs e)
        {
            addSlide();
        }

        private void addSlide()
        {
            lbPreview lbP = new lbPreview();
            int i = cs.ClientSize.Height - 8;
            lbP.Size = new Size(i, i);
            lbP.BackColor = Color.Black;
            lbP.ForeColor = Color.White;
            lbP.Text = "Text - " + cs.Controls.Count;
            lbP.Margin = new Padding(1,0,1,0);
            #region oldCode // Got rid of this code because you can't set location for items in a panel
            //                  Besides...it puts it where I want it anyway (for now)
            //if (pnlSlides.Controls.Count > 0)
            //{
            //    Point prevLoc = pnlSlides.Controls[pnlSlides.Controls.Count - 1].Location;
            //    lbP.Location = new Point(prevLoc.X + i + 5, prevLoc.Y);
            //}
            #endregion
            cs.Controls.Add(lbP);
        }
    }
}
