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
            SuspendLayout();
            // 
            // NicTbox
            // 
            NicTbox.Location = new Point(313, 304);
            NicTbox.Name = "NicTbox";
            NicTbox.Size = new Size(173, 27);
            NicTbox.TabIndex = 4;
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(314, 227);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(173, 27);
            nameTbox.TabIndex = 3;
            // 
            // passTbox
            // 
            passTbox.Location = new Point(314, 156);
            passTbox.Name = "passTbox";
            passTbox.Size = new Size(173, 27);
            passTbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 261);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 10;
            label4.Text = "Inside";
            // 
            // UsernameTbox
            // 
            UsernameTbox.Location = new Point(315, 79);
            UsernameTbox.Name = "UsernameTbox";
            UsernameTbox.Size = new Size(173, 27);
            UsernameTbox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(313, 192);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(54, 20);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 113);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 11;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 44);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 13;
            label1.Text = "Tài Khoản";
            // 
            // regBtn
            // 
            regBtn.Location = new Point(336, 363);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(134, 43);
            regBtn.TabIndex = 9;
            regBtn.Text = "Đăng ký";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NicTbox);
            Controls.Add(nameTbox);
            Controls.Add(passTbox);
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
    }
}