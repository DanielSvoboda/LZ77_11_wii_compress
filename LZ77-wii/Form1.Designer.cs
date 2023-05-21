namespace LZ77_wii
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_compress = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button_compress
            // 
            button_compress.Location = new Point(36, 12);
            button_compress.Name = "button_compress";
            button_compress.Size = new Size(82, 23);
            button_compress.TabIndex = 0;
            button_compress.Text = "Choose File";
            button_compress.UseVisualStyleBackColor = true;
            button_compress.Click += button_compress_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(39, 57);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Open Github";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(154, 81);
            Controls.Add(linkLabel1);
            Controls.Add(button_compress);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LZ11 wii Compress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_compress;
        private LinkLabel linkLabel1;
    }
}