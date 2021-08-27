using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Flight_Simulator_Livery_installer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //MoveForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // --EndMoveForm-- \\

        public string NEW_VERSION = "";
        public string APP_VERSION = "";
        private void Main_Load(object sender, EventArgs e)
        {
            CheckVersion();
            CheckInstallationVersion();
        }

        private void CheckInstallationVersion()
        {
            if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalCache\Packages\Community\"))
            {
                if (!Directory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Microsoft Flight Simulator\Packages\Community"))
                {
                    while (true)
                    {
                        downloadFolderPath = Microsoft.VisualBasic.Interaction.InputBox("Could not find the community folder, please input the file path.\nIt should end with " + @"'Community\'" + "\n", "Not found.", @"Community\");
                        if (downloadFolderPath.Length > 0)
                        {
                            if (downloadFolderPath.Substring(downloadFolderPath.Length - 1) == @"\")
                            {
                                downloadFolderPath += @"\";
                            }
                            downloadPath = downloadFolderPath + "liveries.zip";
                            if (!Directory.Exists(downloadFolderPath))
                            {
                                DialogResult dialogResult = MessageBox.Show("Wrong folder, would you like to view instructions?", "Wrong path", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    Process.Start("https://pastebin.com/j8exYqRt");
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            DialogResult continueResult = MessageBox.Show(null, "You need to select a directory.", "Select a directory", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            if (continueResult == DialogResult.Cancel)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                }
                else
                {
                    downloadPath = @"C:\Users\" + Environment.UserName + @"\AppData\Microsoft Flight Simulator\Packages\Community\liveries.zip";
                    downloadFolderPath = @"C:\Users\" + Environment.UserName + @"\AppData\Microsoft Flight Simulator\Packages\Community\";
                }
            }
            else
            {
                downloadPath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalCache\Packages\Community\liveries.zip";
                downloadFolderPath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalCache\Packages\Community\";
            }
        }
        private void CheckVersion()
        {
            try
            {
                APP_VERSION = new WebClient().DownloadString("https://o11.se/FlightSimulator/applicationVersion.txt");
                NEW_VERSION = new WebClient().DownloadString("https://o11.se/FlightSimulator/liveriesVersion.txt");
            }
            catch
            {
                MessageBox.Show("Could not get the latest version", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if (Properties.Settings.Default.applicationVersion != APP_VERSION)
            {
                DialogResult dialogResult = MessageBox.Show("There is a new version of this installer.\nNew: " + APP_VERSION + "\nCurrent: " + Properties.Settings.Default.applicationVersion + "\nWould you like to update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    _ = Process.Start("https://o11.se/FlightSimulator/Flight%20Simulator%20Livery%20installer.exe");
                    Application.Exit();
                }
            }

            currentInstalledlbl.Text = Properties.Settings.Default.currentVersion.Length == 0 ? "Unknown" : Properties.Settings.Default.currentVersion;

            if (currentInstalledlbl.Text == NEW_VERSION)
            {
                currentInstalledlbl.ForeColor = Color.FromArgb(0, 192, 0);
                installbtn.Text = "Reinstall";
            }
            currentVersionlbl.Text = NEW_VERSION;
            currentVersionlbl.ForeColor = Color.FromArgb(0, 192, 0);
            currentVersionlbl.Font = new Font(currentVersionlbl.Font.FontFamily, 24);
        }
        private void Main_Paint(object sender, PaintEventArgs e)
        {
            int width = Width - 1;
            int height = Height - 1;
            Pen pen = new Pen(Color.FromArgb(60, 157, 185), 1);
            e.Graphics.DrawRectangle(pen, 0, 0, width, height);
        }

        private void Titlelbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Installbtn_Click(object sender, EventArgs e)
        {
            refreshbtn.Visible = false;
            downloadbar.Visible = true;
            installbtn.Enabled = false;
            currentVersionlbl.Text = "";
            progressbarAnimation.Start();
        }

        private void ProgressbarAnimation_Tick(object sender, EventArgs e)
        {
            if (downloadbar.Location.Y > 142)
            {
                downloadbar.Location = new Point(downloadbar.Location.X, downloadbar.Location.Y - 1);
            }
            else
            {
                progressbarAnimation.Stop();
                currentVersionlbl.ForeColor = Color.FromArgb(60, 157, 185);
                currentVersionlbl.Font = new Font(currentVersionlbl.Font.FontFamily, 18);
                currentTitlelbl.Text = "Downloading";
                StartDownload();
            }
        }

        private string downloadPath = "";
        private string downloadFolderPath = "";
        private void StartDownload()
        {
            Thread thread = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
                client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);
                client.DownloadFileAsync(new Uri("https://o11.se/FlightSimulator/liveries.zip"), downloadPath);
            });
            thread.Start();
            networkSpeed.Start();
        }

        private int speedMegabytes = 0;
        private int seconds = 1;
        private int downloaded = 0;
        static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                downloaded = (int)Math.Round(ConvertBytesToMegabytes(e.BytesReceived));
                currentVersionlbl.Text = Math.Round(ConvertBytesToMegabytes(e.BytesReceived)) + "/" + Math.Round(ConvertBytesToMegabytes(e.TotalBytesToReceive)) + "MB (" + speedMegabytes + "MB/s)";
                downloadbar.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                progressbarAnimationHide.Start();
                networkSpeed.Stop();
            });
        }


        private void Install()
        {
            currentTitlelbl.Text = "Installing";
            currentVersionlbl.Text = "Unzipping files...";
            currentTitlelbl.Refresh();
            currentVersionlbl.Refresh();
            Thread.Sleep(1000);

            FileStream zipToOpen = new FileStream(downloadPath, FileMode.Open);
            ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update);
            ZipArchiveExtensions.ExtractToDirectory(archive, downloadFolderPath, true);
            GC.Collect();

            currentInstalledlbl.ForeColor = Color.FromArgb(0, 192, 0);
            currentInstalledlbl.Text = NEW_VERSION;
            Properties.Settings.Default.currentVersion = NEW_VERSION;
            Properties.Settings.Default.Save();

            currentTitlelbl.Text = "Finalizing";
            currentVersionlbl.Text = "Removing ZIP file";
            currentTitlelbl.Refresh();
            currentVersionlbl.Refresh();
            zipToOpen.Close();
            Thread.Sleep(1000);

            try
            {
                File.Delete(downloadPath);
            }
            catch
            {

            }
            GC.Collect();

            zipToOpen.Close();
            zipToOpen.Dispose();

            currentTitlelbl.Text = "Installation done";
            currentVersionlbl.Text = "Done!";
            currentTitlelbl.Refresh();
            currentVersionlbl.Refresh();
            Thread.Sleep(250);
            installbtn.Text = "Reinstall";
            installbtn.Enabled = true;
            refreshbtn.Visible = true;
            GC.Collect();
            MessageBox.Show("Installation successful!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProgressbarAnimationHide_Tick(object sender, EventArgs e)
        {
            if (downloadbar.Location.Y < 171)
            {
                downloadbar.Location = new Point(downloadbar.Location.X, downloadbar.Location.Y + 1);
            }
            else
            {
                progressbarAnimationHide.Stop();
                Install();
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            CheckVersion();
        }

        private void NetworkSpeed_Tick(object sender, EventArgs e)
        {
            speedMegabytes = downloaded / seconds;
            seconds++;
        }
    }
}
