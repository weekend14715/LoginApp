using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Newtonsoft.Json;
using learnFireBase;

namespace LoginC
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "KO6iXy2pRi7kkeZ5QxWyGgei2NHTQpgCuXQmMd3d",
            BasePath = "https://sever1-143bb-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void QuenMK_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Có vấn đề về kết nối");
            }




        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetAsync("Users");
            Dictionary<string, MyUser> users = response.ResultAs<Dictionary<string, MyUser>>();
            MyUser user = null;
            foreach (var u in users.Values)
            {
                if (u.Email == EmailTbox.Text)
                {
                    user = u;
                    break;
                }
            }
            if (user == null)
            {
                MessageBox.Show("Email không tồn tại!");
                return;
            }

            // send the user's password to their email address
            SendPasswordEmail(user.Email, user.Password);
            MessageBox.Show("Mật khẩu đã được gửi đến email của bạn!");
        }
        private void SendPasswordEmail(string emailAddress, string password)
        {
            // create a new email message
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hoàng Tuấn", "ctump147@gmail.com"));
            message.To.Add(new MailboxAddress("", emailAddress));
            message.Subject = "Lấy lại mật khẩu";
            message.Body = new TextPart("plain")
            {
                Text = "Mật khẩu của bạn là: " + password
            };

            // send the email using SMTP
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("ctump147@gmail.com", "dogzqaasxcubltwo");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
