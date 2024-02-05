
namespace QConverter {
    partial class FileActionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.int32Label = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.createPatternBtn = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // int32Label
            // 
            this.int32Label.AutoSize = true;
            this.int32Label.Location = new System.Drawing.Point(13, 16);
            this.int32Label.Name = "int32Label";
            this.int32Label.Size = new System.Drawing.Size(247, 19);
            this.int32Label.TabIndex = 1;
            this.int32Label.Text = "You\'re trying to load a file. Quick actions.";
            this.int32Label.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.int32Label.UseCustomBackColor = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroCheckBox1.Location = new System.Drawing.Point(13, 50);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(118, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox1.TabIndex = 2;
            this.metroCheckBox1.Text = "Convert to base64";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(13, 92);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(118, 15);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton1.TabIndex = 5;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Copy to clipboard";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton2.Location = new System.Drawing.Point(137, 92);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(80, 15);
            this.metroRadioButton2.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton2.TabIndex = 6;
            this.metroRadioButton2.Text = "Save as file";
            this.metroRadioButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton2.UseSelectable = true;
            // 
            // createPatternBtn
            // 
            this.createPatternBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createPatternBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.createPatternBtn.Location = new System.Drawing.Point(134, 119);
            this.createPatternBtn.Name = "createPatternBtn";
            this.createPatternBtn.Size = new System.Drawing.Size(115, 25);
            this.createPatternBtn.Style = MetroFramework.MetroColorStyle.Black;
            this.createPatternBtn.TabIndex = 65;
            this.createPatternBtn.Text = "Proceed";
            this.createPatternBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.createPatternBtn.UseSelectable = true;
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton6.Location = new System.Drawing.Point(271, 92);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(127, 15);
            this.metroRadioButton6.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton6.TabIndex = 66;
            this.metroRadioButton6.Text = "Load to QConverter";
            this.metroRadioButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton6.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.metroCheckBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroCheckBox3.Location = new System.Drawing.Point(137, 50);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(134, 15);
            this.metroCheckBox3.Style = MetroFramework.MetroColorStyle.White;
            this.metroCheckBox3.TabIndex = 70;
            this.metroCheckBox3.Text = "Convert to byte array";
            this.metroCheckBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton3.Location = new System.Drawing.Point(137, 71);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(76, 15);
            this.metroRadioButton3.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton3.TabIndex = 8;
            this.metroRadioButton3.Text = "Compress";
            this.metroRadioButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton3_CheckedChanged);
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton5.Location = new System.Drawing.Point(271, 71);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(88, 15);
            this.metroRadioButton5.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton5.TabIndex = 9;
            this.metroRadioButton5.Text = "Decompress";
            this.metroRadioButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton5.UseSelectable = true;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.metroRadioButton4.Location = new System.Drawing.Point(13, 71);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(52, 15);
            this.metroRadioButton4.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton4.TabIndex = 7;
            this.metroRadioButton4.Text = "None";
            this.metroRadioButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton4.UseSelectable = true;
            // 
            // FileActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 162);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroRadioButton4);
            this.Controls.Add(this.metroRadioButton5);
            this.Controls.Add(this.metroRadioButton3);
            this.Controls.Add(this.metroRadioButton6);
            this.Controls.Add(this.createPatternBtn);
            this.Controls.Add(this.metroRadioButton2);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.int32Label);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileActionForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "S";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FileActionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel int32Label;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroButton createPatternBtn;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
    }
}