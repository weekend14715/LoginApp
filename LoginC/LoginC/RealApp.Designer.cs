namespace LoginC
{
    partial class RealApp
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
            btnSend = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(253, 231);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(108, 34);
            btnSend.TabIndex = 0;
            btnSend.Text = "button1";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // button2
            // 
            button2.Location = new Point(413, 240);
            button2.Name = "button2";
            button2.Size = new Size(127, 34);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(395, 84);
            button3.Name = "button3";
            button3.Size = new Size(167, 47);
            button3.TabIndex = 3;
            button3.Text = "click ảnh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // RealApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSend);
            Name = "RealApp";
            Text = "RealApp";
            Load += RealApp_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSend;
        private Button button2;
        private Button button3;
    }
}