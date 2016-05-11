using autoFilePrinter.Properties;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace autoFilePrinter
{
    public partial class frmFilePrinter : Form
    {
        private delegate void UpdateHistoryDel(string newText);

        private FileSystemWatcher fsWatcher;
        private static object fileLock = new object();

        public frmFilePrinter()
        {
            InitializeComponent();
        }

        private void frmFilePrinter_Load(object sender, EventArgs e)
        {
            if (Settings.Default.Properties.Cast<SettingsProperty>().Any(prop => prop.Name == "WatchDir"))
            {
                txtDirToWatch.Text = (string)Settings.Default["WatchDir"];
            }

            if (Settings.Default.Properties.Cast<SettingsProperty>().Any(prop => prop.Name == "WatchExt"))
            {
                txtWatchExt.Text = (string)Settings.Default["WatchExt"];
            }
            if (Settings.Default.Properties.Cast<SettingsProperty>().Any(prop => prop.Name == "PrintOnce"))
            {
                chkPrintOnce.Checked = (bool)Settings.Default["PrintOnce"];
            }
            addHistory("Application Started");
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            if (fsWatcher == null)
            {
                startWatching();
                btnWatch.Text = "Stop Watching";
            }
            else
            {
                fsWatcher.EnableRaisingEvents = false;
                fsWatcher = null;
                btnWatch.Text = "Watch";
            }
        }

        private void startWatching()
        {
            if (Directory.Exists(txtDirToWatch.Text))
            {
                Settings.Default["WatchDir"] = txtDirToWatch.Text;
                Settings.Default["WatchExt"] = txtWatchExt.Text;
                Settings.Default["PrintOnce"] = chkPrintOnce.Checked;

                Properties.Settings.Default.Save();

                fsWatcher = new FileSystemWatcher(txtDirToWatch.Text);

                fsWatcher.Created += new System.IO.FileSystemEventHandler(this.OnChanged);

                var withFSW = fsWatcher;
                withFSW.EnableRaisingEvents = true;
                withFSW.IncludeSubdirectories = false;

                withFSW.Filter = "*." + txtWatchExt.Text;

                this.BeginInvoke(new UpdateHistoryDel(addHistory), "Watching: " + txtDirToWatch.Text + " for: " + withFSW.Filter);
            }
            else
            {
                this.BeginInvoke(new UpdateHistoryDel(addHistory), "Directory Doesn't Exist!: " + txtDirToWatch.Text);
            }
        }

        public void OnChanged(object sender, FileSystemEventArgs e)
        {
            //print
            printFile(e.FullPath);
        }

        public void printFile(string fpath)
        {
            //should it check for dupes?
            bool isDupe = false;

            if (chkPrintOnce.Checked)
            {
                foreach (string file in File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\autoprintlog.txt"))
                {
                    if (fpath.ToLower() == file.ToLower())
                    {
                        isDupe = true;
                    }
                }
            }

            if (!isDupe)
            {
                //print the file:
                Process PrintProcess = new Process();
                PrintProcess.StartInfo.CreateNoWindow = false;
                PrintProcess.StartInfo.Verb = "print";
                PrintProcess.StartInfo.FileName = fpath;
                PrintProcess.Start();

                UpdateFile fileupdate = new UpdateFile { filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\autoprintlog.txt", lineData = fpath };
                //add the queue item
                ThreadPool.QueueUserWorkItem(UpdateFile, fileupdate);
                this.BeginInvoke(new UpdateHistoryDel(addHistory), "Printed: " + fpath);
            }
            else
            {
                this.BeginInvoke(new UpdateHistoryDel(addHistory), "Duplicate: " + fpath);
            }
        }

        public bool isDupe(string fname)
        {
            bool dupe = false;
            string lfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            return dupe;
        }

        public void saveLog(string fname)
        {
        }

        private static void UpdateFile(object fileData)
        {
            //set object to be locked
            lock (fileLock)
            {
                //get the file
                using (var fw = File.AppendText(((UpdateFile)fileData).filePath))
                {
                    //write the data
                    fw.WriteLine(((UpdateFile)fileData).lineData);
                }
            }
        }

        public void addHistory(string htxt)
        {
            lstHistory.Items.Insert(0, DateTime.Now.ToString() + " - " + htxt);
        }
    }

    public class UpdateFile
    {
        public string lineData { get; set; }

        public string filePath { get; set; }
    }
}