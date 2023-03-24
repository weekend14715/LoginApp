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
            AuthSecret = "KO6iXy2pRi7kkeZ5QxWyGgei2NHTQpgCuXQmMd3d",
            BasePath = "https://sever1-143bb-default-rtdb.firebaseio.com/"
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
                }
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

                // Tắt cửa sổ đăng nhập
                this.Hide();

                // Mở cửa sổ RealApp
                RealApp realAppForm = new RealApp();
                realAppForm.Show();
            }

            else
            {
                MyUser.ShowError();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }
        // Lưu thông tin đăng nhập vào cài đặt ứng dụng nếu người dùng đã chọn "Lưu thông tin đăng nhập"





    }

}
