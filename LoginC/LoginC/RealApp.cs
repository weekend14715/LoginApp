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
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace LoginC
{
    public partial class RealApp : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        public RealApp()
        {
            InitializeComponent();

        }


        private void RealApp_Load(object sender, EventArgs e)
        {

        }
        // Tạo phương thức tìm kiếm hình ảnh

        private void btnSend_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream stream = myAssembly.GetManifestResourceStream("LoginC.Resources.click.png");
            Image searchImage = Image.FromStream(stream);

            Bitmap searchBitmap = (Bitmap)searchImage.Clone();
            Point location = FindBitmap(searchBitmap);
            if (location != Point.Empty)
            {
                SetCursorPos(location.X, location.Y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, location.X, location.Y, 0, 0);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh!");
            }
        }
        private Point FindBitmap(Bitmap searchImage)
        {
            Bitmap screen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(screen);
            g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            g.Dispose();

            for (int y = 0; y < screen.Height - searchImage.Height; y++)
            {
                for (int x = 0; x < screen.Width - searchImage.Width; x++)
                {
                    bool match = true;
                    for (int i = 0; i < searchImage.Width; i++)
                    {
                        for (int j = 0; j < searchImage.Height; j++)
                        {
                            Color searchPixel = searchImage.GetPixel(i, j);
                            Color screenPixel = screen.GetPixel(x + i, y + j);
                            if (searchPixel != screenPixel)
                            {
                                match = false;
                                break;
                            }
                        }
                        if (!match)
                        {
                            break;
                        }
                    }
                    if (match)
                    {
                        return new Point(x, y);
                    }
                }
            }
            return Point.Empty;
        }

        public class OpenFrtPharmacy
        {
            [DllImport("user32.dll")]
            private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll")]
            private static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            private const int SW_RESTORE = 9;

            public void OpenPharmacy()
            {
                // Tìm handle của cửa sổ FRT Pharmacy
                IntPtr windowHandle = FindWindow(null, "FRT Pharmacy"); // Thay "FRT Pharmacy" bằng tiêu đề của cửa sổ FRT Pharmacy

                if (windowHandle != IntPtr.Zero)
                {
                    // Nếu cửa sổ đang minimized, hiển thị cửa sổ trước khi đưa lên phía trước
                    if (IsIconic(windowHandle))
                    {
                        ShowWindow(windowHandle, SW_RESTORE);
                    }

                    // Đưa cửa sổ FRT Pharmacy lên phía trước
                    SetForegroundWindow(windowHandle);
                }
                else
                {
                    // Xử lý lỗi không tìm thấy cửa sổ FRT Pharmacy
                }
            }

            [DllImport("user32.dll")]
            private static extern bool IsIconic(IntPtr hWnd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFrtPharmacy openFrtPharmacy = new OpenFrtPharmacy();
            openFrtPharmacy.OpenPharmacy();

        }
        Process[] processes = Process.GetProcessesByName("FRT Pharmacy");
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Process process in processes)
            {
                string path = process.MainModule.FileName;
                MessageBox.Show("Đường dẫn đến FRT Pharmacy.exe là:\n" + path, "Thông báo");
            }
        }
    }

}

