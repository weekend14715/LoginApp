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
            txtEmailTo = new TextBox();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(476, 190);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(108, 34);
            btnSend.TabIndex = 0;
            btnSend.Text = "button1";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtEmailTo
            // 
            txtEmailTo.Location = new Point(209, 187);
            txtEmailTo.Name = "txtEmailTo";
            txtEmailTo.Size = new Size(254, 27);
            txtEmailTo.TabIndex = 1;
            // 
            // RealApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmailTo);
            Controls.Add(btnSend);
            Name = "RealApp";
            Text = "RealApp";
            Load += RealApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtEmailTo;
    }
}