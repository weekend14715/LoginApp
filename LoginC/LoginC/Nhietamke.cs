using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Microsoft.Win32;

namespace LoginC
{

    public partial class Nhietamke : Form

    {

        private string selectedFolderPath = null;
        public Nhietamke()
        {
            InitializeComponent();
            // Truy vấn đường dẫn từ AppData nếu đã lưu trước đó
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LoginC", "path1.txt");
            if (File.Exists(path))
            {
                selectedFolderPath = File.ReadAllText(path);
            }
        }
        private void Nhietamke_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Xác thực và tạo service
            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.Drive },
                    "user",
                    System.Threading.CancellationToken.None).Result;
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Drive API Sample",
            });

            // Đường dẫn đến thư mục trên Google Drive cần tải về
            var folderId = "1YWiEvzu-o9iRAPTMklvIAry109_AQple";

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
                // Tải xuống các file từ thư mục
                var request = service.Files.List();
                request.Q = $"'{folderId}' in parents";
                request.Fields = "nextPageToken, files(id, name)";
                var results = request.Execute();
                foreach (var file in results.Files)
                {
                    var fileId = file.Id;
                    var fileName = file.Name;
                    var requestDownload = service.Files.Get(fileId);
                    var streamDownload = new MemoryStream();
                    requestDownload.Download(streamDownload);
                    streamDownload.Position = 0;
                    var filePath = Path.Combine(selectedFolderPath, fileName);
                    var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    streamDownload.CopyTo(fileStream);
                    fileStream.Close();
                }

                MessageBox.Show("Cập nhật hoàn tất.");
                // Lưu đường dẫn vào AppData
                string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LoginC");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(Path.Combine(directory, "path1.txt"), selectedFolderPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            selectedFolderPath = dialog.SelectedPath;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
                string fileName = Path.Combine(selectedFolderPath, "Nhiet am ke.xlsm");
                string excelPath = "";
                RegistryKey excelKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\excel.exe");
                if (excelKey != null)
                {
                    object excelValue = excelKey.GetValue("");
                    if (excelValue != null)
                    {
                        excelPath = excelValue.ToString();
                    }
                }

                if (string.IsNullOrEmpty(excelPath))
                {
                    // File excel.exe không tồn tại trên máy tính
                }
                else
                {
                    // Sử dụng đường dẫn excelPath để thực thi file excel.exe
                }
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.FileName = excelPath;
                process.StartInfo.Arguments = "\"" + fileName + "\"";
                process.Start();
            

        }
    }
}


