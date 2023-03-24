namespace LoginC
{
    partial class QuenMK
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
            EmailTbox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // EmailTbox
            // 
            EmailTbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTbox.Location = new Point(91, 67);
            EmailTbox.Name = "EmailTbox";
            EmailTbox.Size = new Size(284, 38);
            EmailTbox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(147, 126);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 1;
            button1.Text = "Lấy mật khẩu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 70);
            label1.Name = "label1";
            label1.Size = new Size(70, 31);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // QuenMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 221);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(EmailTbox);
            Name = "QuenMK";
            Text = "QuenMK";
            Load += QuenMK_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmailTbox;
        private Button button1;
        private Label label1;
    }
}