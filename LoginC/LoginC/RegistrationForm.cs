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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "KO6iXy2pRi7kkeZ5QxWyGgei2NHTQpgCuXQmMd3d",
            BasePath = "https://sever1-143bb-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void RegistrationForm_Load(object sender, EventArgs e)
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

            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
               string.IsNullOrWhiteSpace(passTbox.Text) &&

               string.IsNullOrWhiteSpace(nameTbox.Text) &&
               string.IsNullOrWhiteSpace(NicTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion

            MyUser user = new MyUser()
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text,

                Fullname = nameTbox.Text,
                NICno = NicTbox.Text
            };

            SetResponse set = client.Set(@"Users/" + UsernameTbox.Text, user);

            MessageBox.Show("Successfully registered!");
        }
    }

}
