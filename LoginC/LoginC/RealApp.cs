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
            Bitmap searchImage = new Bitmap(pictureBox1.Image);
            Point location = FindBitmap(searchImage);
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

        public class ZaloWindowOpener
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            static extern bool IsIconic(IntPtr hWnd);

            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            const int SW_RESTORE = 9;

            public static void OpenZaloWindow()
            {
                Process[] processes = Process.GetProcessesByName("Zalo");
                if (processes.Length == 0)
                {
                    // Nếu Zalo không đang chạy, thông báo lỗi hoặc tiến hành mở Zalo
                    // bằng đường dẫn thực thi Zalo.exe
                    MessageBox.Show("Zalo chưa được khởi động.");
                }
                else
                {
                    Process process = processes[0];
                    IntPtr mainWindowHandle = process.MainWindowHandle;
                    if (IsIconic(mainWindowHandle))
                    {
                        // Nếu cửa sổ đang minimized, phục hồi cửa sổ
                        ShowWindow(mainWindowHandle, SW_RESTORE);
                    }
                    // Đưa cửa sổ Zalo lên trước màn hình
                    SetForegroundWindow(mainWindowHandle);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZaloWindowOpener.OpenZaloWindow();
        }
    }

}

