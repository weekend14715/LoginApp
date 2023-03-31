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
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelVersion = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passTbox
            // 
            passTbox.Location = new Point(458, 119);
            passTbox.Margin = new Padding(3, 2, 3, 2);
            passTbox.Name = "passTbox";
            passTbox.PasswordChar = '*';
            passTbox.Size = new Size(205, 23);
            passTbox.TabIndex = 2;
            // 
            // UsernameTbox
            // 
            UsernameTbox.Location = new Point(459, 63);
            UsernameTbox.Margin = new Padding(3, 2, 3, 2);
            UsernameTbox.Name = "UsernameTbox";
            UsernameTbox.Size = new Size(204, 23);
            UsernameTbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(458, 94);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 19;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(459, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 21;
            label1.Text = "Tài Khoản";
            // 
            // regBtn
            // 
            regBtn.Location = new Point(500, 270);
            regBtn.Margin = new Padding(3, 2, 3, 2);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(117, 32);
            regBtn.TabIndex = 4;
            regBtn.Text = "Đăng ký";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(500, 201);
            LogBtn.Margin = new Padding(3, 2, 3, 2);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(117, 32);
            LogBtn.TabIndex = 3;
            LogBtn.Text = "Đăng nhập";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(459, 144);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(145, 29);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Lưu tài khoản";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(49, 38);
            label3.Name = "label3";
            label3.Size = new Size(243, 65);
            label3.TabIndex = 23;
            label3.Text = "WEEKEND";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(75, 281);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 23;
            label4.Text = "HUỲNH HOÀNG TUẤN";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(105, 302);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 23;
            label5.Text = "0369647957";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(331, 308);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(31, 15);
            labelVersion.TabIndex = 24;
            labelVersion.Text = "1.0.3";
            labelVersion.Click += labelVersion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(469, 238);
            label7.Name = "label7";
            label7.Size = new Size(161, 21);
            label7.TabIndex = 25;
            label7.Text = "Bạn chưa có tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(497, 172);
            label6.Name = "label6";
            label6.Size = new Size(117, 21);
            label6.TabIndex = 26;
            label6.Text = "Quên mật khẩu";
            label6.Click += label6_Click_1;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseMove += label6_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GreenYellow;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(49, 139);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 125);
            panel1.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(10, 8);
            label10.Name = "label10";
            label10.Size = new Size(153, 19);
            label10.TabIndex = 23;
            label10.Text = "Đăng ký xác thực Gmail";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.GreenYellow;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(10, 80);
            label12.Name = "label12";
            label12.Size = new Size(207, 19);
            label12.TabIndex = 23;
            label12.Text = "Cập nhật ứng dụng Nhiệt ẩm kế";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.GreenYellow;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(10, 56);
            label11.Name = "label11";
            label11.Size = new Size(217, 19);
            label11.TabIndex = 23;
            label11.Text = "Cập nhật ứng dụng Bàn giao tiền ";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.GreenYellow;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(10, 34);
            label9.Name = "label9";
            label9.Size = new Size(258, 19);
            label9.TabIndex = 23;
            label9.Text = "Gửi mật khẩu về mail khi quên mật khảu";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(49, 116);
            label8.Name = "label8";
            label8.Size = new Size(139, 21);
            label8.TabIndex = 23;
            label8.Text = "Thông tin cập nhật";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // LoginForm
            // 
            AcceptButton = LogBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(labelVersion);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(passTbox);
            Controls.Add(UsernameTbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogBtn);
            Controls.Add(regBtn);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button regBtn;
        private Button LogBtn;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelVersion;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label11;
        public TextBox UsernameTbox;
        public TextBox passTbox;
        public CheckBox checkBox1;
    }
}