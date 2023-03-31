namespace LoginC
{
    partial class Nhietamke
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
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(132, 100);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 31;
            label2.Text = "Thông tin cập nhật";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Location = new Point(132, 122);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 144);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(176, 18);
            label1.Name = "label1";
            label1.Size = new Size(303, 65);
            label1.TabIndex = 29;
            label1.Text = "Nhiệt ẩm kế";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.Location = new Point(184, 355);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(297, 22);
            button2.TabIndex = 33;
            button2.Text = "Thay đổi đường dẫn đến thư mục Ban giao tiền";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(218, 282);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(217, 57);
            button3.TabIndex = 32;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(491, 283);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 56);
            button1.TabIndex = 35;
            button1.Text = "RUN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Nhietamke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(700, 385);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Nhietamke";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhietamke";
            Load += Nhietamke_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        internal Label label1;
        private Button button2;
        private Button button3;
        private Button button1;
    }
}