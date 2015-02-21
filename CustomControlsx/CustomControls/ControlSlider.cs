using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace CustomControls
{
    public class ControlSliderMoveArgs {
//        public Point Location = 
    }
    public class ControlSlider : System.Windows.Forms.Panel
    {
        public delegate void ControlSliderHandler();
        public ControlSlider()
        {
            InitializeComponent();
        }

private void InitializeComponent()
{
 	//throw new NotImplementedException();
}
        public event ControlSliderHandler ControlSliderMove;
        protected virtual void OnControlSliderMove()
        {
            if (ControlSliderMove != null) { ControlSliderMove(); }
        }
    }
}
