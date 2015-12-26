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
using ShellObjects;

namespace WallWatch
{
    public partial class Form1 : Form
    {

        List<string> walls = new List<string>();
        IDesktopWallpaper desktopWallpaper = new DesktopWallpaper();

        public Form1()
        {
            InitializeComponent();

            this.Resize += new System.EventHandler(this.Form1_Resize);

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "WallWatch";
            notifyIcon1.BalloonTipText = "Woo running in tray :-)";

            // TODO: Load from settings file
            timeSpanBox.SelectedIndex = 0;

            // TODO: Load from settings file
            timeBox.Text = "zazaza";

            int time;
            if (!int.TryParse(timeBox.Text, out time))
            {
                time = 30;
                timeBox.Text = time.ToString();
            }

            UpdateTimer();

            TextBoxStreamWriter _writer = null;
            _writer = new TextBoxStreamWriter(consoleTextBox);
            Console.SetOut(_writer);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void addToWatchlist_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                watchListDirectories.Items.Add(folderBrowserDialog1.SelectedPath);
            }
        }

        private void minimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: save to config file
        }

        private void allowSameWall_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: save to config file
        }

        private void ignoreAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: save to config file
        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {
            // TODO: save to config file
            UpdateTimer();
        }

        private void timeSpanBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: save to config file
            UpdateTimer();
        }

        private void detectScreens_Click(object sender, EventArgs e)
        {
            // TODO: save screen IDs to config?
            foreach (Screen scr in Screen.AllScreens)
            {
                Console.WriteLine("Device Name: " + scr.DeviceName + (scr.Primary ? " (Primary)" : ""));
                Console.WriteLine("Bounds: " + scr.Bounds.ToString());
                Console.WriteLine("Working Area: " + scr.WorkingArea.ToString());
                Console.WriteLine("");
            }
        }

        private void fetchImages_Click(object sender, EventArgs e)
        {
            walls.Clear();

            if (watchListDirectories.Items.Count == 0)
            {
                MessageBox.Show(this, "Nothing to watch", "POI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var item in watchListDirectories.CheckedItems)
            {
                string[] fileEntries = Directory.GetFiles(item.ToString(), "*.*", (fetchFromSubdirectories.Checked) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                foreach (string fileName in fileEntries)
                {
                    // TODO: Cache in config/separate bin file?
                    Console.WriteLine(fileName);
                    ParseFile(fileName);
                }
            }
        }

        private void ParseFile(string fileName)
        {
            FileStream fs = File.OpenRead(fileName);
            BinaryReader reader = new BinaryReader(fs);

            byte[] magic = reader.ReadBytes(4);

            byte[][] magicbytes = new byte[][] {
                new byte[] { 0xff, 0xd8, 0xff, 0xe0 },
                new byte[] { 0xff, 0xd8, 0xff, 0xe1 },
                new byte[] { 0x89, 0x50, 0x4e, 0x47 }
            };

            if (!magicbytes.Any(bytes => bytes.SequenceEqual(magic)))
            {
                return;
            }

            walls.Add(fileName);
        }

        private void letsBegin_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            UpdateWallpaper();
        }

        private Random rnd = new Random();

        private string FindWallpaper(Screen screen)
        {
            if (ignoreAspectRatio.Checked)
            {
                return walls[rnd.Next(walls.Count)];
            }
            else
            {
                double screenAspect = (double)screen.Bounds.Width / screen.Bounds.Height;

                int idx = rnd.Next(walls.Count);
                int tries = 0;

                while (true)
                {
                    // check the image
                    try
                    {
                        using (var image = new System.Drawing.Bitmap(walls[idx]))
                        {
                            double imageAspect = (double)image.Width / image.Height;

                            if ((imageAspect - screenAspect) < 0.0002)
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: {0}", e);
                    }


                    // find the next one
                    idx = rnd.Next(walls.Count);
                    tries++;

                    // to not exhaust resources
                    if (tries >= 50)
                    {
                        break;
                    }
                }

                return walls[idx];
            }
        }

        private void UpdateWallpaper()
        {
            DateTime dt = DateTime.Now;
            string dt2 = String.Format("{0:HH:mm:ss}", dt);


            Console.WriteLine("[{0}] Changing wallpaper", dt2);

            HashSet<string> foundEntries = new HashSet<string>();

            foreach (Screen scr in Screen.AllScreens)
            {
                string wall;

                // for 'same' stuff
                while (true)
                {
                    wall = FindWallpaper(scr);

                    // early out if there's less wallpapers than screens
                    if (walls.Count < Screen.AllScreens.Length)
                    {
                        break;
                    }

                    // if we didn't find it already (or we're ignoring duplicates), go break as well
                    if (allowSameWall.Checked || !foundEntries.Contains(wall))
                    {
                        if (!allowSameWall.Checked)
                        {
                            foundEntries.Add(wall);
                        }

                        break;
                    }
                }

                uint displayIdx = uint.Parse(scr.DeviceName.Replace(@"\\.\DISPLAY", "")) - 1;

                string monitorID;
                desktopWallpaper.GetMonitorDevicePathAt(displayIdx, out monitorID);

                desktopWallpaper.SetWallpaper(monitorID, wall);
            }
        }

        private void UpdateTimer()
        {
            int span;

            if (int.TryParse(timeBox.Text, out span))
            {
                int multiplier = 0;

                switch (timeSpanBox.SelectedIndex)
                {
                    case 0: // seconds
                        multiplier = 1000;
                        break;

                    case 1: // minutes
                        multiplier = 1000 * 60;
                        break;

                    case 2: // hours
                        multiplier = 1000 * 60 * 60;
                        break;
                }

                timer1.Interval = multiplier * span;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateWallpaper();
        }
    }
}