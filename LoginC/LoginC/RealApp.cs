using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LoginC
{
    public partial class RealApp : Form
    {
        public RealApp()
        {
            InitializeComponent();
        }

        private void RealApp_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = "ctump147@hotmail.com";
            string password = "Violeter14715@";

            // Thông tin người nhận và nội dung email
            string toEmail = "hoangtuan.th484@gmail.com";
            string subject = "Test email";
            string body = "This is a test email sent from C#";

            // Tạo đối tượng MailMessage để chứa nội dung email
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(email);
            msg.To.Add(toEmail);
            msg.Subject = subject;
            msg.Body = body;

            // Thiết lập thông tin SMTP cho tài khoản Hotmail của bạn
            SmtpClient smtpClient = new SmtpClient("smtp.live.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(email, password);

            // Gửi email
            smtpClient.Send(msg);
        }
    }
}
