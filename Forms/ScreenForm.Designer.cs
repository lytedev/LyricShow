using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows;
using System.Windows.Forms;

namespace LyricShow
{
    public class myLabel : System.Windows.Forms.Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            ScreenForm parent = (ScreenForm)this.Parent;
            if (parent.EnableBackground == false) { Text = _SongText; }
            else
            {
                GraphicsPath path = new GraphicsPath();
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                Graphics g = e.Graphics;
                Brush br = new SolidBrush(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                int fx = this.Width;
                int fy = this.Height;
                path.AddString(_SongText, LSFont.FontFamily, (int)FontStyle.Bold, LSFont.SizeInPoints, new Rectangle(0, 0, fx, fy), sf);
                Pen pen = new Pen(Color.Black, 3);
                g.DrawPath(pen, path);
                g.FillPath(br, path);
                pen.Dispose();
                br.Dispose();
                path.Dispose();
            }
            base.OnPaint(e);
        }
        public System.Drawing.Font LSFont
        {
            get { return Font; }
            set
            {
                //use a base of 800x600, calculate percentage of that, that the current screen resolution is, and divide
                //by 100, then set font size to that in EMs.  get % of height AND width, and use smaller value

                System.Drawing.Font tmpFont = value;
                double pc = 0;
                double w = this.Width;
                double h = this.Height;
                double widthPercent = w / 800;
                double heightPercent = h / 600;
                if (widthPercent > heightPercent) {pc = heightPercent;} else {pc = widthPercent;}
                float tmpSize = System.Convert.ToSingle( pc / 0.02);
                Font = new System.Drawing.Font(tmpFont.FontFamily,tmpSize, tmpFont.Style,tmpFont.Unit,tmpFont.GdiCharSet,tmpFont.GdiVerticalFont);
            }
        }
        private string _SongText = "";
        public string SongText
        {
            get { return _SongText; }
            set { _SongText = value.Replace("I�m", "I'm").Replace("There�s", "There's").Replace("there�s", "there's").Replace("Who�s", "Who's").Replace("who�s", "who's").Replace("�", ""); }
        }
    }
    partial class ScreenForm
    {
        private string _LSBGImgPath = "";

        public string LSBackgroundImage
        {
            get { return _LSBGImgPath; }
            set {
                if (EnableBackground == true) {
                    _LSBGImgPath = value;
                    try { BackgroundImage = new System.Drawing.Bitmap(value); }
                    catch { _LSBGImgPath = ""; }
                }
            } 
        }
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
            this.lblText = new LyricShow.myLabel();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.LSFont = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(800, 600);
            this.lblText.TabIndex = 0;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText.DoubleClick += new System.EventHandler(this.lblText_DoubleClick);
            this.lblText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblText_MouseDown);
            this.lblText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblText_MouseMove);
            this.lblText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblText_MouseUp);
            // 
            // ScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ScreenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "y";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScreenForm_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public myLabel lblText;
     }
}