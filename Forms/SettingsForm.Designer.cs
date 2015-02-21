namespace LyricShow
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btSongDir = new System.Windows.Forms.Button();
            this.btSongIndex = new System.Windows.Forms.Button();
            this.txtSongIndex = new System.Windows.Forms.TextBox();
            this.txtSongDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 40);
            this.panel1.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(170, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(46, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 0;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSongDir
            // 
            this.btSongDir.Location = new System.Drawing.Point(268, 11);
            this.btSongDir.Name = "btSongDir";
            this.btSongDir.Size = new System.Drawing.Size(31, 23);
            this.btSongDir.TabIndex = 0;
            this.btSongDir.Text = "...";
            this.btSongDir.UseVisualStyleBackColor = true;
            this.btSongDir.Click += new System.EventHandler(this.btSongDir_Click);
            // 
            // btSongIndex
            // 
            this.btSongIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSongIndex.Location = new System.Drawing.Point(268, 40);
            this.btSongIndex.Name = "btSongIndex";
            this.btSongIndex.Size = new System.Drawing.Size(31, 23);
            this.btSongIndex.TabIndex = 0;
            this.btSongIndex.Text = "...";
            this.btSongIndex.UseVisualStyleBackColor = true;
            this.btSongIndex.Click += new System.EventHandler(this.btSongIndex_Click);
            // 
            // txtSongIndex
            // 
            this.txtSongIndex.Location = new System.Drawing.Point(63, 40);
            this.txtSongIndex.Name = "txtSongIndex";
            this.txtSongIndex.Size = new System.Drawing.Size(199, 20);
            this.txtSongIndex.TabIndex = 1;
            // 
            // txtSongDir
            // 
            this.txtSongDir.Location = new System.Drawing.Point(63, 11);
            this.txtSongDir.MaximumSize = new System.Drawing.Size(1000, 20);
            this.txtSongDir.Name = "txtSongDir";
            this.txtSongDir.Size = new System.Drawing.Size(199, 20);
            this.txtSongDir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.MaximumSize = new System.Drawing.Size(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Index File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.MaximumSize = new System.Drawing.Size(54, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Song Dir :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btSongDir);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btSongIndex);
            this.panel3.Controls.Add(this.txtSongDir);
            this.panel3.Controls.Add(this.txtSongIndex);
            this.panel3.Location = new System.Drawing.Point(2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 83);
            this.panel3.TabIndex = 3;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 171);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSongDir;
        private System.Windows.Forms.Button btSongIndex;
        private System.Windows.Forms.TextBox txtSongIndex;
        private System.Windows.Forms.TextBox txtSongDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}