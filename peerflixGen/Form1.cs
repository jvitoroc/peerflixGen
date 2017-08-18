using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace peerflixUI
{
    public partial class peerflix : Form
    {

        private string[] playersNames = new string[10];
        private string[] playerFlags = new string[10];

        public peerflix()
        {
            InitializeComponent();
        }

        private void peerflix_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("node_modules"))
            {
                enableStart(false);
            }

            //Adding the flags
            playersNames[0] = "VLC media player";
            playerFlags[0] = "-v";

            playersNames[1] = "AirPlay";
            playerFlags[1] = "-s";

            playersNames[2] = "mplayer";
            playerFlags[2] = "-m";

            playersNames[3] = "smplayer";
            playerFlags[3] = "-g";

            playersNames[4] = "MPC-HC player";
            playerFlags[4] = "--mpchc";

            playersNames[5] = "Potplayer";
            playerFlags[5] = "--potplayer";

            playersNames[6] = "mpv";
            playerFlags[6] = "-k";

            playersNames[7] = "omx";
            playerFlags[7] = "-o";

            playersNames[8] = "webplay";
            playerFlags[8] = "-w";

            playersNames[9] = "omx using audio jack";
            playerFlags[9] = "-j";

            //Add the players to the "Pick a player" combobox
            player.Items.AddRange(playersNames);
            enableAdvanced(false);
        }

        private void enableAdvanced(bool boolean)
        {
            aditionalFlags.Enabled = boolean;
            additionalLabel.Enabled = boolean;
        }

        private void enableStart(bool boolean)
        {
            input.Enabled = boolean;
            browse.Enabled = boolean;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            //string remoteUri = "https://github.com/mafintosh/peerflix/archive/";
            //string fileName = "master.zip";

            //if (File.Exists("peerflix-master"))
            //    File.Delete(fileName);
            //if (Directory.Exists("peerflix-master"))
            //    Directory.Delete("peerflix-master", true);

            //// Create a new WebClient instance.
            //WebClient myWebClient = new WebClient();
            //// Concatenate the domain with the Web resource filename.
            //string myStringWebResource = remoteUri + fileName;
            //MessageBox.Show("Downloading File \"{0}\" from \"{1}\" .......\n\n");
            //// Download the Web resource and save it into the current filesystem folder.
            //myWebClient.DownloadFile(myStringWebResource, fileName);
            //MessageBox.Show("Successfully Downloaded File \"{0}\" from \"{1}\"");
            //MessageBox.Show("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath); 
            //ZipFile.ExtractToDirectory(Application.StartupPath+"\\"+fileName, Application.StartupPath);
            //DirectoryInfo d = new DirectoryInfo(@"peerflix-master\");
            //List<FileInfo> files = d.GetFiles().ToList();
            //foreach(FileInfo file in files)
            //{
            //    if (File.Exists(Application.StartupPath+"\\"+file.Name))
            //        File.Delete(Application.StartupPath + "\\" + file.Name);
            //    File.Move(file.FullName, Application.StartupPath);
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Open a .torrent file
        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*|torrent files (*.torrent)|*.torrent";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        input.Text = openFileDialog1.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        //Play
        private void button1_Click_1(object sender, EventArgs e)
        {
            int selectedPlayer = player.SelectedIndex;
            string cPlayerFlag;
            string cmd = "";

            switch (globalMode.Checked)
            {
                case true:
                    cmd = "peerflix";
                    break;
                case false:
                    cmd = "node app";
                    break;
            }

            if(selectedPlayer == -1) 
                cPlayerFlag = "";
            else
                cPlayerFlag = " " + playerFlags[selectedPlayer];

            string command = cmd+" \"" + input.Text + "\"" + cPlayerFlag;
            if (advanced.Checked)
            {
                command += " " + aditionalFlags.Text;
            }

            UsefulMethods.runCommand(Application.StartupPath, command, false);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Enable advanced options
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            enableAdvanced(advanced.Checked);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Open the Node.js homepage
        private void downloadNodejsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsefulMethods.openWebsite(@"https://nodejs.org/en/");
        }

        //Oen the GitHub of this project
        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsefulMethods.openWebsite(@"https://github.com/jvitoroc/peerflixGen");
        }

        //Open the GitHub of the original peerflix
        private void peerflixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsefulMethods.openWebsite(@"https://github.com/mafintosh/peerflix");
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        //Download the modules locally
        private void downloadModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Run "peerflix" instead of "node app"
        private void globalMode_CheckedChanged(object sender, EventArgs e)
        {
            if (Directory.Exists("node_modules") && !globalMode.Checked)
            {
                enableStart(true);
            }else if (globalMode.Checked)
            {
                enableStart(true);
            }
            else
            {
                enableStart(false);
            }
        }

        private void locallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsefulMethods.runCommand(Application.StartupPath, "npm install", true);
        }

        private void globallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsefulMethods.runCommand(Application.StartupPath, "npm install -g peerflix", false);
        }
    }

    static class UsefulMethods
    {

        //Run a given command
        public static void runCommand(string where, string command, bool admin = false)
        {
            const int ERROR_CANCELLED = 1223;

            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            if (admin)
            {
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.Verb = "runas";
            }
            p.StartInfo.Arguments = "/c cd " + where + " & " + command;

            if (admin)
            {
                try
                {
                    p.Start();
                    p.WaitForExit();
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == ERROR_CANCELLED)
                        MessageBox.Show("This operation needs administrator permission.", "peerflixGen");
                    else
                        throw;
                }
            }
            else
            {
                p.Start();
                p.WaitForExit();
            }
        }

        //Open a given website
        public static void openWebsite(string url)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", url);
            Process.Start(startInfo);
        }
    }
}
