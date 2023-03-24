namespace LoginC
{
    partial class RegistrationForm
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
            NicTbox = new TextBox();
            nameTbox = new TextBox();
            passTbox = new TextBox();
            label4 = new Label();
            UsernameTbox = new TextBox();
            nameLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            regBtn = new Button();
            EmailTbox = new Label();
            Sendbtn = new Button();
            OTP = new Label();
            OtpTbox = new TextBox();
            otpBtn = new Button();
            MailTbox = new TextBox();
            label3 = new Label();
            otpLabel = new Label();
            SuspendLayout();
            // 
            // NicTbox
            // 
            NicTbox.BackColor = Color.FromArgb(255, 224, 192);
            NicTbox.Location = new Point(95, 283);
            NicTbox.Name = "NicTbox";
            NicTbox.Size = new Size(173, 27);
            NicTbox.TabIndex = 4;
            // 
            // nameTbox
            // 
            nameTbox.BackColor = Color.FromArgb(255, 224, 192);
            nameTbox.Location = new Point(96, 206);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(173, 27);
            nameTbox.TabIndex = 3;
            // 
            // passTbox
            // 
            passTbox.BackColor = Color.FromArgb(255, 224, 192);
            passTbox.Location = new Point(96, 135);
            passTbox.Name = "passTbox";
            passTbox.Size = new Size(173, 27);
            passTbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(95, 249);
            label4.Name = "label4";
            label4.Size = new Size(75, 31);
            label4.TabIndex = 10;
            label4.Text = "Inside";
            // 
            // UsernameTbox
            // 
            UsernameTbox.BackColor = Color.FromArgb(255, 224, 192);
            UsernameTbox.Location = new Point(97, 58);
            UsernameTbox.Name = "UsernameTbox";
            UsernameTbox.Size = new Size(173, 27);
            UsernameTbox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(97, 172);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(82, 31);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 101);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 11;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 23);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 13;
            label1.Text = "Tài Khoản";
            // 
            // regBtn
            // 
            regBtn.BackColor = Color.MediumSpringGreen;
            regBtn.Location = new Point(110, 491);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(134, 43);
            regBtn.TabIndex = 9;
            regBtn.Text = "Đăng ký";
            regBtn.UseVisualStyleBackColor = false;
            regBtn.Click += regBtn_Click;
            // 
            // EmailTbox
            // 
            EmailTbox.Location = new Point(0, 0);
            EmailTbox.Name = "EmailTbox";
            EmailTbox.Size = new Size(100, 23);
            EmailTbox.TabIndex = 16;
            // 
            // Sendbtn
            // 
            Sendbtn.Location = new Point(296, 358);
            Sendbtn.Name = "Sendbtn";
            Sendbtn.Size = new Size(59, 27);
            Sendbtn.TabIndex = 14;
            Sendbtn.Text = "Gửi";
            Sendbtn.UseVisualStyleBackColor = true;
            Sendbtn.Click += Sendbtn_Click;
            // 
            // OTP
            // 
            OTP.AutoSize = true;
            OTP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            OTP.Location = new Point(95, 392);
            OTP.Name = "OTP";
            OTP.Size = new Size(55, 31);
            OTP.TabIndex = 10;
            OTP.Text = "OTP";
            // 
            // OtpTbox
            // 
            OtpTbox.BackColor = Color.FromArgb(255, 224, 192);
            OtpTbox.Location = new Point(95, 426);
            OtpTbox.Name = "OtpTbox";
            OtpTbox.Size = new Size(173, 27);
            OtpTbox.TabIndex = 4;
            // 
            // otpBtn
            // 
            otpBtn.Location = new Point(287, 426);
            otpBtn.Name = "otpBtn";
            otpBtn.Size = new Size(79, 27);
            otpBtn.TabIndex = 14;
            otpBtn.Text = "Xác thực";
            otpBtn.UseVisualStyleBackColor = true;
            otpBtn.Click += otpBtn_Click;
            // 
            // MailTbox
            // 
            MailTbox.BackColor = Color.FromArgb(255, 224, 192);
            MailTbox.Location = new Point(95, 358);
            MailTbox.Name = "MailTbox";
            MailTbox.Size = new Size(175, 27);
            MailTbox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 324);
            label3.Name = "label3";
            label3.Size = new Size(70, 31);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // otpLabel
            // 
            otpLabel.AutoSize = true;
            otpLabel.Location = new Point(95, 456);
            otpLabel.Name = "otpLabel";
            otpLabel.Size = new Size(50, 20);
            otpLabel.TabIndex = 17;
            otpLabel.Text = "label5";
            otpLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            AcceptButton = regBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(432, 600);
            Controls.Add(otpLabel);
            Controls.Add(MailTbox);
            Controls.Add(otpBtn);
            Controls.Add(OtpTbox);
            Controls.Add(Sendbtn);
            Controls.Add(NicTbox);
            Controls.Add(OTP);
            Controls.Add(nameTbox);
            Controls.Add(EmailTbox);
            Controls.Add(passTbox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(UsernameTbox);
            Controls.Add(nameLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(regBtn);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NicTbox;
        private TextBox nameTbox;
        private TextBox passTbox;
        private Label label4;
        private TextBox UsernameTbox;
        private Label nameLabel;
        private Label label2;
        private Label label1;
        private Button regBtn;
        private Label EmailTbox;
        private Button Sendbtn;
        private Label OTP;
        private TextBox OtpTbox;
        private Button otpBtn;
        private TextBox MailTbox;
        private Label label3;
        private Label otpLabel;
    }
}