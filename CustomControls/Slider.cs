using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControls
{
    public enum ControlSizingStyles { ResizeBoth, ResizeWidth, ResizeHeight };
    #region oldCode
    //private struct ControlSizing{

        
    //    private int _style = (int)Styles.ResizeBoth;
    //    public int Style
    //    {
    //        get { return _style; }
    //        set { _style = (int)value; }
    //    }
    //    private static byte _value = 0;
    //    private ControlSizing(byte StyleValue)
    //    {
    //        _value = StyleValue;
    //    }
    //    public byte ControlSizing()
    //    {
    //        return _value;
    //    }
    //}
#endregion
    public class ControlSlider : FlowLayoutPanel
    {
        Point mouseXY = new Point(0, 0);
        bool mouseIsDown = false;
        private System.ComponentModel.IContainer components = null;
        public ControlSizingStyles ControlSizing = ControlSizingStyles.ResizeBoth;
        public Orientation Orientation = Orientation.Horizontal;
        public delegate void ControlSliderHandler();
        private int _SelectedIndex = 0;
        public bool AnimateSlideSelection = true;
        public Control SelectedItem
        {
            get { return this.Controls[this.SelectedIndex]; }
        }
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
        }
        public int SelectedItemEnlargedDifference = 5;
        public ControlSlider()
        {
            InitializeComponent();
            this.SizeChanged += new EventHandler(ControlSlider_SizeChanged);
            this.ControlAdded += new ControlEventHandler(AddControlsOnPanel);
            this.ControlRemoved += new ControlEventHandler(CenterControlsOnPanel);
            //this.OnMouseDown += new MouseEventHandler(OnMouseDown);
            this.MouseDown += new MouseEventHandler(ControlSlider_MouseDown);
            this.MouseMove += new MouseEventHandler(ControlSlider_MouseMove);
            this.MouseUp += new MouseEventHandler(ControlSlider_MouseUp);
            this.KeyDown += new KeyEventHandler(ControlSlider_KeyDown);
            this.WrapContents = false;
            this.Margin = new Padding(0);
            this.Width = 0;
            this.AutoScroll = true;
            
            if (Orientation == Orientation.Horizontal) { this.HScroll = true; this.VScroll = false; } else { this.VScroll = true; this.HScroll = false; }
        }
        private void ControlSlider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1) 
            {
                mouseIsDown = true;
            }
            mouseXY = new Point(e.X, e.Y);
        }
        private void ControlSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                Point asp = this.AutoScrollPosition;
                Point newScrollPos = new Point(e.X - mouseXY.X + asp.X, 0 + asp.Y);
                this.AutoScrollPosition = newScrollPos;
                //this.AutoScrollOffset = new Point(e.X - mouseXY.X, 0);
                //need to adjust this for whatever is already scrolled
            }
        }
        private void ControlSlider_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        void ControlSlider_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                    //this.Select(true, false);
                    ChangeIndex(this.SelectedIndex - 1);
                    break;
                case Keys.Right:
                case Keys.Down:
                    //this.Select(true, false);
                    ChangeIndex(this.SelectedIndex + 1);
                    break;
            }
            //base.OnKeyDown(e);
        }

        void ControlSlider_SizeChanged(object sender, EventArgs e)
        {
            for (int i = Controls.Count - 1; i >= 0 ; i-- )
            {
                Control c = Controls[i];
                int cx = 0;
                int csx = 0;
                if (Orientation == Orientation.Horizontal)
                {
                    cx = c.Size.Height + c.Margin.Vertical;
                    csx = this.ClientSize.Height;
                }
                else
                {
                    cx = c.Size.Width + c.Margin.Horizontal;
                    csx = this.ClientSize.Width;
                }
                if (cx != csx)
                {
                    int size = csx - cx;
                    bool CanSize = false;
                    if (Orientation == Orientation.Horizontal)
                    {
                        CanSize = c.Size.Height + c.Margin.Vertical + size <= this.ClientSize.Height;
                    }
                    else
                    {
                        CanSize = c.Size.Width + c.Margin.Horizontal + size <= this.ClientSize.Width;
                    }
                    if (CanSize)
                    {
                        if (size > 0)
                        {
                            if (size < GetSmallestMargin(c.Margin))
                            {
                                c.Size += new Size(size * 2, size * 2);
                            }
                        }
                        else
                        {
                            c.Size -= new Size(size * -1 * 2, size * -1 * 2);
                        }
                    }
                    else
                    {
                        ResizeControl(c, size - 1);
                    }
                }

            }
            this.PerformLayout();
        }
        public event ControlSliderHandler ControlSliderMove;

        private void CenterControlsOnPanel(object oControlSlider, ControlEventArgs e)
        {
            ControlSlider cs = (ControlSlider)oControlSlider;
            #region oldCode
            //int w = cs.Width;
            //int m = cs.Margin.Top;
            //if (cs.Parent.Width > cs.Width)
            //{
            //    cs.Controls[0].Margin = new Padding((cs.Parent.Width - cs.Width) / 2, m, m, m);
            //}
            //else
            //{
            //    cs.Margin = new Padding(m);
            //}
            //cs.Width += e.Control.Width + e.Control.Margin.Horizontal + cs.Margin.Horizontal + cs.Padding.Horizontal;
            //            cs.Width = ((cs.Height) * cs.Controls.Count) + 5;   // Need to adjust this for cases where the user changes the margin settings
            #endregion
        }
        private void AddControlsOnPanel(object oControlSlider, ControlEventArgs e)
        {
            ControlSlider cs = (ControlSlider)oControlSlider;
            int cnt = cs.Controls.Count;
            CenterControlsOnPanel(oControlSlider, e);
            int w = SelectedItemEnlargedDifference;
            e.Control.KeyDown += new KeyEventHandler(ControlSlider_KeyDown);
            e.Control.MouseDown += new MouseEventHandler(ControlSlider_MouseDown);
            e.Control.MouseMove += new MouseEventHandler(ControlSlider_MouseMove);
            e.Control.MouseUp += new MouseEventHandler(ControlSlider_MouseUp);
            e.Control.Click += new EventHandler(Control_Click);
            if (cnt >= 3)
            {
                if (cs.Controls[cnt - 1].Right > cs.Width & cs.Controls[cnt - 2].Right <= cs.Width)
                {
                    ControlSlider_SizeChanged(this, null);
                }
            }
            ChangeIndex(cnt - 1);
            this.ScrollControlIntoView(cs.Controls[cs.Controls.Count - 1]);
        }

        void Control_Click(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ChangeIndex(this.Controls.GetChildIndex(ctrl));
        }
        private void ChangeIndex(int index)
        {
            if (this.SelectedIndex != index & 0 <= index & index < this.Controls.Count )
            {
                int w = SelectedItemEnlargedDifference;
                if (AnimateSlideSelection)
                {
                    for (int i = 0; i <= w; i++)
                    {
                        ResizeControl(this.Controls[this.SelectedIndex], -1);
                        ResizeControl(this.Controls[index], 1);
                        System.Threading.Thread.Sleep(8);
                        this.Invalidate();
                    }
                }
                else
                {
                    ResizeControl(this.Controls[this.SelectedIndex],w * -1);
                    ResizeControl(this.Controls[index], w);
                }
                //this.Controls[index].Select();
                _SelectedIndex = index;
            }
        }

        private void ResizeControl(Control c, int size)
        {
            // NEED TO ACCOUNT FOR ControlSizingStyles here

            bool CanSize = false;
            if (Orientation == Orientation.Horizontal) { 
                CanSize = c.Size.Height + c.Margin.Vertical + size <= this.ClientSize.Height; 
            } else {
                CanSize = c.Size.Width + c.Margin.Horizontal + size <= this.ClientSize.Width; 
            }
            if (CanSize)
            {
                if (size > 0)
                {
                    if (size <= GetSmallestMargin(c.Margin))
                    {
                        c.Margin -= new Padding(size);
                        c.Size += new Size(size * 2, size * 2);
                    }
                }
                else
                {
                    c.Size -= new Size(size * -1 * 2, size * -1 * 2);
                    c.Margin += new Padding(size * -1);
                }
            }
            else
            {
                ResizeControl(c, size - 1);
            }
        }

        private int GetSmallestMargin(Padding p)
        {
            int sm = p.Top;
            if (p.Left < sm) { sm = p.Left; }
            if (p.Right < sm) {sm = p.Right;}
            if (p.Bottom < sm) {sm = p.Bottom;}
            return sm;
        }

        protected virtual void OnControlSliderMove()
        {
            if (ControlSliderMove != null) { ControlSliderMove(); }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
    }
 
//    public class ControlSliderMoveArgs {
//        public Point Location = 
//    }
}
