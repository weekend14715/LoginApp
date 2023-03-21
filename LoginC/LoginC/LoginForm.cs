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
                MessageBox.Show("No Internet or Connection Problem");
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();
        }
        private bool rememberMe = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rememberMe = checkBox1.Checked;
        }
        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (rememberMe)
            {
                string fileName = "user_accounts.txt";
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(UsernameTbox.Text);
                    writer.WriteLine(passTbox.Text);
                }
            }
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
                RealApp real = new RealApp();
                real.ShowDialog();
            }

            else
            {
                MyUser.ShowError();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
