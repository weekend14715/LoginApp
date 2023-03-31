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
using learnFireBase;
using LoginC.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Net;
using System.Reflection;
using System.Resources;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Download;
using System.IO.Compression;
using System.Diagnostics;






namespace LoginC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "8MeOiBZn7FO7MYzZyOkPJhxpgM7gMgl7oNXQa77l",
            BasePath = "https://loginc-7193c-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        private void LoginForm_Load(object sender, EventArgs e)

        {


            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Có vấn đề về kết nối Internet");

            }
            {
                // Tải thông tin đăng nhập từ đối tượng lưu trữ cục bộ
                string username = Properties.Settings.Default.Username;
                string password = Properties.Settings.Default.Password;

                // Điền thông tin đăng nhập vào các ô tương ứng trên form đăng nhập
                UsernameTbox.Text = username;
                passTbox.Text = password;

                // Chọn CheckBox nếu đã lưu thông tin đăng nhập
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    checkBox1.Checked = true;

                    // Nếu cả ô tài khoản và mật khẩu đều có giá trị thì tự động đăng nhập
                    // Tắt cửa sổ đăng nhập

                    // Mở cửa sổ RealApp





                }

            }
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, "login.txt");

            if (File.Exists(filePath))
            {
                string[] loginInfo = File.ReadAllText(filePath).Split(',');
                string username1 = loginInfo[0];
                string password1 = loginInfo[1];

                // Sử dụng tên đăng nhập và mật khẩu để đăng nhập
                UsernameTbox.Text = username1;
                passTbox.Text = password1;
                // Đồng thời kiểm tra CheckBox để đánh dấu ô nhớ mật khẩu
                checkBox1.Checked = true;
            }



        }



        private static Settings GetDefault()
        {
            return Properties.Settings.Default;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();
        }
        private bool rememberMe = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Lưu thông tin đăng nhập vào đối tượng lưu trữ cục bộ
                Properties.Settings.Default.Username = UsernameTbox.Text;
                Properties.Settings.Default.Password = passTbox.Text;
                Properties.Settings.Default.Save();
                string tempPath = Path.GetTempPath();
                string filePath = Path.Combine(tempPath, "login.txt");
                string username = UsernameTbox.Text;
                string password = passTbox.Text;
                File.WriteAllText(filePath, $"{username},{password}");

            }
            else
            {
                // Xóa thông tin đăng nhập từ đối tượng lưu trữ cục bộ
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }
        private void LogBtn_Click(object sender, EventArgs e)
        {

            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
           string.IsNullOrWhiteSpace(passTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion







            FirebaseResponse res = client.Get(@"Users/" + UsernameTbox.Text);
            MyUser ResUser = res.ResultAs<MyUser>();// database result

            MyUser CurUser = new MyUser() // USER GIVEN INFO
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text
            };

            if (MyUser.IsEqual(ResUser, CurUser))
            {
                string tempPath = Path.GetTempPath();
                string filePath = Path.Combine(tempPath, "login1.txt");
                string username = UsernameTbox.Text;
                string password = passTbox.Text;
                File.WriteAllText(filePath, $"{username},{password}");
                // Tắt cửa sổ đăng nhập
                this.Hide();

                // Mở cửa sổ RealApp
                Chon_Ung_Dung realAppForm = new Chon_Ung_Dung();
                realAppForm.Show();
            }

            else
            {
                MyUser.ShowError();
            }
        }






        private async void label6_Click_1(object sender, EventArgs e)
        {
            {
                // Lấy thông tin người dùng từ Firebase
                FirebaseResponse res = client.Get(@"Users/" + UsernameTbox.Text);
                MyUser ResUser = res.ResultAs<MyUser>();

                // Kiểm tra xem người dùng có tồn tại trong Firebase không
                if (ResUser == null)
                {
                    MessageBox.Show("Username không tồn tại");
                    return;
                }

                // Khởi tạo một email message
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Hoàng Tuấn", "weekend147258@gmail.com"));
                message.To.Add(new MailboxAddress("Tên người nhận", ResUser.Email + "@gmail.com"));
                message.Subject = "Thông tin mật khẩu";

                // Tạo nội dung email
                string body = "Mật khẩu của bạn là: " + ResUser.Password;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                // Gửi email
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("weekend147258@gmail.com", "lxylgmbbwecbbzez");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                MessageBox.Show("Mật khẩu đã được gửi về email của bạn");
            }
        }
        private void label6_MouseMove(object sender, MouseEventArgs e)
        {

            label6.Cursor = Cursors.Hand;
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Cyan;

        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<Chon_Ung_Dung>().Any())
            {
                // Nếu form Chon_Ung_Dung đang được hiển thị thì đóng form LoginForm
                this.Hide();
            }
        }


    }

}
