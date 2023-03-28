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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LoginC
{
    public partial class RealApp : Form
    {
        private string selectedFolderPath = null;

        public RealApp()
        {
            InitializeComponent();

            // Truy vấn đường dẫn từ AppData nếu đã lưu trước đó
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LoginC", "path.txt");
            if (File.Exists(path))
            {
                selectedFolderPath = File.ReadAllText(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedFolderPath == null)
            {
                var dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedFolderPath = dialog.SelectedPath;
                }

            }

            if (selectedFolderPath != null)
            {
                // Đường dẫn đến file trên Google Drive
                string fileUrl = "https://public.dm.files.1drv.com/y4mlOsIPKltWonFgy0boii-9aKRyCb4UivT-n_C9oekpILo2CkiiVz4QibGartojQW00QC1zHINfIQiQmSZhzZjHdHE18PtPFGiOOjWLUAzgCTC43FWSGWr-2fGQ3-UPHTkWgYKLKmpa6NwfLLYyMJwgY6_bcvfoJ3ahhvnmhQbnzGzmDf_Cf-sdUW1OT1r4ByaIN6tJSFoLGNRCFfnnfiQc82fooJ2wWV7cH-ro1nJPiQ?AVOverride=1";

                // Tải xuống file từ Google Drive
                using (var client = new WebClient())
                {
                    string filePath = Path.Combine(selectedFolderPath, "BAN GIAO TIEN.xlsm");
                    client.DownloadFile(fileUrl, filePath);
                }

                // Thông báo thành công
                MessageBox.Show("Cập nhật thành công!", "Thành công");

                // Lưu đường dẫn vào AppData
                string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LoginC");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(Path.Combine(directory, "path.txt"), selectedFolderPath);
            }
        }

        private void RealApp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            selectedFolderPath = dialog.SelectedPath;
        }
    }
}
