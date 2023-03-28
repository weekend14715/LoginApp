using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;


namespace LoginC
{
    public partial class RealApp : Form
    {
        public RealApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Hiển thị dialog chọn thư mục
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Đường dẫn đến file trên Google Drive
                string fileUrl = "https://public.dm.files.1drv.com/y4mQdccYQmfpDxTCDdpLYONa8YCRsH_aRMeIUctQ8tYtSs6DmVAAqM5tBvqhwQpLfNccfeukqPgaqGWDKIjTJJJ9fysDT-am5OqLMZju-6HvkzQfHcYFaquKMECRDabmwDhm8XsGY0TgnEVIX356-DHCsJdS4-TYb0mV5gO366zkaSPlc22Jn8SrRJdOfZ6jmk30dFwfLsDopf7jWoN8Iq6CDbNZfqBa_UWMTSgUlTPgag?AVOverride=1";

                // Đường dẫn đến thư mục chứa file trên máy tính
                string folderPath = dialog.SelectedPath;

                // Tải xuống file từ Google Drive
                using (var client = new WebClient())
                {
                    string filePath = Path.Combine(folderPath, "BAN GIAO TIEN.xlsm");
                    client.DownloadFile(fileUrl, filePath);
                }

                // Thông báo thành công
                MessageBox.Show("Cập nhật thành công!", "Thành công");
            }

        }
    }
}
