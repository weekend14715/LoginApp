namespace LoginC
{
    partial class LoginForm
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
            passTbox = new TextBox();
            UsernameTbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            regBtn = new Button();
            LogBtn = new Button();
            SuspendLayout();
            // 
            // passTbox
            // 
            passTbox.Location = new Point(306, 226);
            passTbox.Name = "passTbox";
            passTbox.Size = new Size(173, 27);
            passTbox.TabIndex = 22;
            // 
            // UsernameTbox
            // 
            UsernameTbox.Location = new Point(307, 149);
            UsernameTbox.Name = "UsernameTbox";
            UsernameTbox.Size = new Size(173, 27);
            UsernameTbox.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 183);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 19;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 114);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 21;
            label1.Text = "Tài Khoản";
            // 
            // regBtn
            // 
            regBtn.Location = new Point(254, 303);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(134, 43);
            regBtn.TabIndex = 18;
            regBtn.Text = "Đăng ký";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(408, 303);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(134, 43);
            LogBtn.TabIndex = 18;
            LogBtn.Text = "Đăng nhập";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passTbox);
            Controls.Add(UsernameTbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogBtn);
            Controls.Add(regBtn);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passTbox;
        private TextBox UsernameTbox;
        private Label label2;
        private Label label1;
        private Button regBtn;
        private Button LogBtn;
    }
}