using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace peerflixUI
{
    public partial class peerflix : Form
    {

        System.Object[] playersNames = new System.Object[3];
        string[] playerFlags = new string[3];
        public peerflix()
        {
            InitializeComponent();
            if (!Directory.Exists("node_modules"))
            {
                enableStart(false);
            }
            playersNames[0] = "VLC media player";
            playersNames[1] = "AirPlay";
            playersNames[2] = "mplayer";
            playerFlags[0] = "-v";
            playerFlags[1] = "-s";
            playerFlags[2] = "-m";
            player.Items.AddRange(playersNames);
            enableAdvanced(false);
        }

        private void enableAdvanced(bool boolean)
        {
            aditionalFlags.Enabled = boolean;
            additionalLabel.Enabled = boolean;
            advancedTooltip.Enabled = boolean;
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

            string command = "/K "+cmd+" \"" + input.Text + "\"" + cPlayerFlag;
            if (advanced.Checked)
            {
                command += " " + aditionalFlags.Text;
            }
            Process p = new Process();
            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = command;
            p.Start();
        }

        private void openWebsite(string url)
        {
            var startInfo = new ProcessStartInfo("explorer.exe", url);
            Process.Start(startInfo);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            Flags.Show("ola",null);
        }

        private void downloadNodejsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWebsite(@"https://nodejs.org/en/");
        }

        private void gitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWebsite(@"https://github.com/mafintosh/peerflix");
        }

        private void peerflixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWebsite(@"https://github.com/mafintosh/peerflix");
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void downloadModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = "/K npm install";
            p.Start();
        }

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
    }
}
