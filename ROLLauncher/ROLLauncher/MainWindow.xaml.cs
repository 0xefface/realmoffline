using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ROLLauncher.Hep;
using System.IO;
using WinForms = System.Windows;
using System.Diagnostics;
using System.Threading.Tasks;
namespace ROLLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        public static MainWindow Main { get; set; }
        private string RealmDirectory = string.Empty; // Where to look for sciw.exe
        private bool IsHepWritten { get; set; } // So we can tell if we wrote a hep file.
        private bool IsLiveConnect { get; set; } // if we want to connect to live servers instead
        private bool IsEmuConnect { get; set; }
        /// <summary>
        /// If we save a hepfile, this is where we keep the path
        /// </summary>
        private string SavedHepFile { get; set; }

        private System.Windows.Forms.FolderBrowserDialog openRealmDir { get; set; }


        public MainWindow()
        {
            Main = this;
            IsHepWritten = false;
            //RealmDirectory = string.Empty;
            InitializeComponent();
            openRealmDir = new WinForms.Forms.FolderBrowserDialog();
            openRealmDir.ShowNewFolderButton = false;
            openRealmDir.Description = "Select your Realm 3x Directory.";
            this.IsLiveConnect = false;
            this.IsEmuConnect = false;
            if(Directory.Exists(XmlManager.GetLastUsedDirectory))
            this.RealmDirectory = XmlManager.GetLastUsedDirectory;
            this.SetEvents();
        }
        public void SetEvents()
        {
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            this.chk_ConnectToLive.Checked += new RoutedEventHandler(chk_ConnectToLive_Checked);
            this.chk_ConnectToLive.Unchecked += new RoutedEventHandler(chk_ConnectToLive_Unchecked);
            this.connectToEmu.Checked += new RoutedEventHandler(connectToEmu_Checked);
            this.connectToEmu.Unchecked += new RoutedEventHandler(connectToEmu_Unchecked);
        }
        public void UnSetEvents()
        {
            this.Closing -= new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
            this.chk_ConnectToLive.Checked -= new RoutedEventHandler(chk_ConnectToLive_Checked);
            this.chk_ConnectToLive.Unchecked -= new RoutedEventHandler(chk_ConnectToLive_Unchecked);
        }
        public void Dispose()
        {
            UnSetEvents();
        }
        private void btn_Set_Click(object sender, RoutedEventArgs e)
        {
            
            if (IsEmuConnect)
            {
                // Then we are set already just rungame
                if (RealmDirectory == string.Empty)
                {
                    CheckDirAndFinish();
                }
                else RunGame();
                return;
            }
            #region NoValueCheck
            if (txt_ServerIP.Text.Length == 0)
            {
                MessageBox.Show("You must enter a server ip.");
                return;
            }
            if (txt_ServerPort.Text.Length == 0)
            {
                MessageBox.Show("You must enter a server port.");
                return;
            }
            #endregion
            #region Server/Port Validation
            // We need to make sure, this is an ip they entered
           // if (!HepFile.IsInDottedIpFormat(txt_ServerIP.Text))
           // {
                // Bad Ip format
            //    MessageBox.Show("Server Ip must be in dotted ip format, EX: 127.0.0.1", "Error not in dotted ip format!!", MessageBoxButton.OK, MessageBoxImage.Error);
             //   return;
           // }
            // Make sure this is a valid port
           // if (!HepFile.IsValidPort(txt_ServerPort.Text))
           // {
           //     // Bad Port format
            //    MessageBox.Show("Port must be a 5 char or less numeric value, EX: 7002, or 45321", "Error Inalid Port!!", MessageBoxButton.OK, MessageBoxImage.Error);
            //    return;
           // }
            #endregion
            #region Exsiting Realm Dir Check
            //if (Directory.Exists(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Norseman Games\\The Realm Online")))
           // {
               // openRealmDir.SelectedPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Norseman Games\\The Realm Online");
          //  }
            #endregion
            #region FileChecks
            // Ok lets see if we have a value for realmdirectory
            if (RealmDirectory == string.Empty)
            {
                CheckDirAndFinish();
            }
            else
            {
                // We have a realm dir
                if(!IsLiveConnect)
                if (!AdminCheck(RealmDirectory)) { return; }
                // Try to delete any prior hep file
                if (!DeleteHepFile) { } // Dont worry about it, just try to delete it
                RunGame();
            }
             
        }
        private void ClearSavedGameDir(object sender, System.Windows.RoutedEventArgs e)
        {
            // Need admin prives
            XmlManager.SetLastDir(string.Empty);
            this.RealmDirectory = string.Empty;
        }
           // #endregion
        public void CheckDirAndFinish()
        {
            System.Windows.Forms.DialogResult result = openRealmDir.ShowDialog();
            
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (!IsLiveConnect)
                    if (!AdminCheck(openRealmDir.SelectedPath)) { return; }

                if (!File.Exists(System.IO.Path.Combine(openRealmDir.SelectedPath, "sciw.exe")))
                {
                    // Sciw.exe does not exist in the path the user selected.
                    MessageBox.Show("Sciw.exe does not exist in selected folder, please select the folder with sciw.exe.",
                        "Sciw.exe not present!!!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                RealmDirectory = openRealmDir.SelectedPath;
                if (!XmlManager.SetLastDir(openRealmDir.SelectedPath))
                {
                    //System.Windows.Forms.MessageBox.Show("Unable to save last used directory !", "Save Error!", 
                       // WinForms.Forms.MessageBoxButtons.OK, WinForms.Forms.MessageBoxIcon.Error);
                    //return;
                }
                // Try to delete any prior hep file
                if (!DeleteHepFile) { } // Dont worry about it, just try to delete it
                // Now are we going to connect to live servers or not ?
                if (IsLiveConnect)
                {
                    try
                    {
                        string exePath = System.IO.Path.Combine(RealmDirectory, "sciw.exe");
                        ProcessStartInfo realm = new ProcessStartInfo(exePath);
                        realm.WorkingDirectory = RealmDirectory;
                        Process.Start(realm);
                    }
                    catch { }
                }
                else
                    RunGame();
            }
        }
            #endregion
        #region RunGame
        /// <summary>
        /// Takes all of our gatherd information
        /// Creates and writes a new hep file
        /// runs sciw.exe
        /// </summary>
        private void RunGame()
        {
            if (RealmDirectory == string.Empty )
            {
                MessageBox.Show("Error selecting Realm Directory.");
                return;
            }

            try
            {
                // Generate a default hep file
                //byte[] bytesHepFile = HepFile.GenerateDefaultHepFile();

                // Now we need to add our server and ip in place of the default
                //byte[] newInfo = ;
               // if (newInfo == null) { return; }
                byte[] fixedFile = HepFile.CreateNewHepFile(txt_ServerIP.Text, txt_ServerPort.Text);//HepFile.ReplaceHep(newInfo);
                if (fixedFile == null) { return; }
                    // need to save it as 45012
                SavedHepFile = System.IO.Path.Combine(RealmDirectory, "45012.hep");
                // Our path to the exe for the game
                string exePath = System.IO.Path.Combine(RealmDirectory, "sciw.exe");
                // Writing the new hep file
                if (!IsLiveConnect)
                {
                    HepFile.ByteArrayToFile(SavedHepFile, fixedFile);
                    // We wrote a new file, so lets set our write flag to true
                    IsHepWritten = true;
                }
                // Now Run the game
                ProcessStartInfo inf = new ProcessStartInfo(exePath);
                inf.WorkingDirectory = RealmDirectory;
                Process.Start(inf);
                // Now that we started realm, minimize us
                //this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                //MessageBox.Show(e.Message, "Internal Error, Please send this error to the Creator.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        #endregion
        private void MainWindow_Closing(object sender, EventArgs e)
        {
            if (IsHepWritten)
            {
                // We must have a value for where we saved the hep file, otherwise we cannot do anything
                if (string.IsNullOrEmpty(SavedHepFile)) { return; }

                // Ok we have a value, try to delete it
                try
                {
                    File.Delete(SavedHepFile);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }
        #region Connect to Live Server CheckBox
        private void connectToEmu_Checked(object sender, RoutedEventArgs e)
        {
            this.chk_ConnectToLive.IsChecked = false;
            this.txt_ServerIP.IsEnabled = false;
            this.txt_ServerPort.IsEnabled = false;
            this.txt_ServerIP.Text = "kaven.noip.me";
            this.txt_ServerPort.Text = "7002";
            // Set live connect to true
            this.IsLiveConnect = false;
            this.IsEmuConnect = true;
            

        }
        private void connectToEmu_Unchecked(object sender, RoutedEventArgs e)
        {
            this.txt_ServerIP.IsEnabled = true;
            this.txt_ServerPort.IsEnabled = true;
            this.txt_ServerIP.Text = "localhost";
            this.txt_ServerPort.Text = "7002";
            this.IsEmuConnect = false;
        }
        private void chk_ConnectToLive_Unchecked(object sender, RoutedEventArgs e)
        {
            // First unlock all other interfaces
            this.txt_ServerIP.IsEnabled = true;
            this.txt_ServerPort.IsEnabled = true;
            // Set live connect to false
            this.IsLiveConnect = false;

        }
        private void chk_ConnectToLive_Checked(object sender, RoutedEventArgs e)
        {
            this.connectToEmu.IsChecked = false;
            // First Lock all other interfaces
            this.txt_ServerIP.IsEnabled = false;
            this.txt_ServerPort.IsEnabled = false;
            // Set live connect to true
            this.IsLiveConnect = true;
            Task task = Task.Factory.StartNew(() =>
            {
                if (!string.IsNullOrEmpty(SavedHepFile))
                {
                    if (!DeleteHepFile)
                    {
                        Stopwatch wait = new Stopwatch();
                        wait.Start();
                        // Then kick off a timer, gotta delete this file
                        while (!DeleteHepFile)
                        {
                            if (DeleteHepFile) break;
                            if (wait.Elapsed.Seconds >= 10) break; // break after 10 seconds if we cant delete
                        }
                        wait.Stop();
                    }
                }
            });

        }
        #endregion
        private bool DeleteHepFile
        {
            get
            {
                if (File.Exists(System.IO.Path.Combine(RealmDirectory, "45012.hep")))
                {
                    try
                    {
                        File.Delete(System.IO.Path.Combine(RealmDirectory, "45012.hep"));
                        this.IsHepWritten = false;
                        this.SavedHepFile = string.Empty;
                        return true;
                    }
                    catch { }
                }
                return false;
            }
        }
        private bool AdminCheck(string path)
        {
            // If we need admin privs for this dir, we have to restart
            if (!Globals.WriteTestFile(path))
            {
                Application.Current.Shutdown();
                Globals.RestartAsAdmin(this.txt_ServerIP.Text, this.txt_ServerPort.Text, openRealmDir.SelectedPath);
                return false;
            }
            return true;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (App.Args.Length > 0)
            {
                // Set up Values
                string worker = string.Empty;
                string ip = string.Empty;
                string port = string.Empty;
                string dir = string.Empty;

                // When this was split, it was split by spaces, which we need back
                StringBuilder build = new StringBuilder();
                foreach (string arg in App.Args)
                    build.Append(string.Format("{0} ", arg));
                try
                {
                    // So now we split our string the way we want it split
                    worker = build.ToString().Trim();
                    ip = worker.Split(' ').First();
                    worker = worker.Remove(0, ip.Length).Trim();
                    port = worker.Split(' ').First().Trim();
                    dir = worker.Remove(0, port.Length).Trim();
                    // Set our values
                    this.txt_ServerIP.Text = ip;
                    this.txt_ServerPort.Text = port;
                    this.RealmDirectory = dir;
                }
                catch { }
            }
        }
    }
}
