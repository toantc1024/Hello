namespace Hello
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
            btnClick = new Button();
            txtSang = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnClick
            // 
            btnClick.Location = new Point(202, 127);
            btnClick.Margin = new Padding(3, 4, 3, 4);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(86, 31);
            btnClick.TabIndex = 0;
            btnClick.Text = "Click me";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // txtSang
            // 
            txtSang.AutoSize = true;
            txtSang.Location = new Point(565, 174);
            txtSang.Name = "txtSang";
            txtSang.Size = new Size(98, 20);
            txtSang.TabIndex = 1;
            txtSang.Text = "Sang dep trai";
            txtSang.Click += txtSang_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(524, 267);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(76, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(linkLabel1);
            Controls.Add(txtSang);
            Controls.Add(btnClick);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClick;
        private Label txtSang;
        private LinkLabel linkLabel1;
    }
}
