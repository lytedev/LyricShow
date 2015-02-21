using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LyricShow
{
    class InputBox
    {
        int InputBoxReturn = -1;
        public Form f = new Form();

        public String Show(String Prompt)
        {
            Label l = new Label();
            l.Text = Prompt;
            l.AutoSize = true;
            l.MinimumSize = new System.Drawing.Size(150, 20);
            l.Top = 5;
            TextBox t = new TextBox();
            t.Size = l.Size;
            t.Top = l.Top + l.Height + 5;
            f.Width = l.Width;
            t.Width = f.Width;
            t.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(inputKeyPress);
            Button b = new Button();
            b.Size = new System.Drawing.Size(50, 24);
            b.Text = "Ok";
            b.Click += new System.EventHandler(InputBoxRet);
            b.Left = f.Width / 2 - (b.Width / 2);
            b.Top = t.Top + t.Height + 5;
            b.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(inputKeyPress);
            //b.Dock = DockStyle.Bottom;
            f.Size = new System.Drawing.Size(40, 40);
            f.AutoSize = true;
            f.Controls.Add(l);
            f.Controls.Add(t);
            f.Controls.Add(b);
            f.KeyPreview = true;
            f.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(inputKeyPress);
            f.ShowDialog();
            if (InputBoxReturn == 0) { return t.Text; } else { return ""; }

        }
        public void InputBoxRet(object sender, EventArgs e)
        {
            InputBoxReturn = 0;
            this.f.Close();
        }

        public void inputKeyPress(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.f.Close();
            }
            if (e.KeyCode == Keys.Return)
            {
                InputBoxRet(this.f, null);
            }
        }
    }
}
