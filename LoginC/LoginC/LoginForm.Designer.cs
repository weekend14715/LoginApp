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
            SuspendLayout();
            // 
            // passTbox
            // 
            passTbox.Location = new Point(524, 159);
            passTbox.Name = "passTbox";
            passTbox.PasswordChar = '*';
            passTbox.Size = new Size(234, 27);
            passTbox.TabIndex = 2;
            // 
            // UsernameTbox
            // 
            UsernameTbox.Location = new Point(525, 84);
            UsernameTbox.Name = "UsernameTbox";
            UsernameTbox.Size = new Size(233, 27);
            UsernameTbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(524, 125);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 19;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(525, 50);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 21;
            label1.Text = "Tài Khoản";
            // 
            // regBtn
            // 
            regBtn.Location = new Point(565, 360);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(134, 43);
            regBtn.TabIndex = 4;
            regBtn.Text = "Đăng ký";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(565, 260);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(134, 43);
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
            checkBox1.Location = new Point(525, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 35);
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
            label3.Location = new Point(53, 85);
            label3.Name = "label3";
            label3.Size = new Size(303, 81);
            label3.TabIndex = 23;
            label3.Text = "WEEKEND";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(86, 375);
            label4.Name = "label4";
            label4.Size = new Size(213, 28);
            label4.TabIndex = 23;
            label4.Text = "HUỲNH HOÀNG TUẤN";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(117, 403);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 23;
            label5.Text = "0369647957";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(359, 426);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(64, 20);
            labelVersion.TabIndex = 24;
            labelVersion.Text = "Ver 1.0.1";
            labelVersion.Click += labelVersion_Click;
            // 
            // LoginForm
            // 
            AcceptButton = LogBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(labelVersion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelVersion;
    }
}