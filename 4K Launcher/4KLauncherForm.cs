using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace _4K_Launcher
{

    public partial class Form1 : Form
    {

        string downloadurl = ("https://www.dropbox.com/sh/klyttakbdpn1pac/AAD1yJtHkEkegmA0jNFcx9JZa?dl=1"); // download url, requries a forced download
        string zipfile = @".\downloading\update.zip"; // this is also a Path where the file saves but it only saves at the 4K Launcher rn 
        string serverversionurl = ""; // use pastebin, type the current number as "001" not "0.0.1"
        string clientversionpath = @"..\game\version.txt"; // same with the serverversionurl string but use a txt file instead
        string gamepath = @"..\game";
        string gameexecutable = @"..\game\game.exe"; // it can be also a steamid launch, a lnk file or whatever.
        string gamename = "game";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            // TODO: Make a shared code function or smth from update_beans_Click
        }

        private void beans_logo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start(gameexecutable);
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't find " + gamename, "Launch Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
         private void update_beans_Click(object sender, EventArgs e)
         {
             WebClient client = new WebClient();
             int server = int.Parse(client.DownloadString(serverversionurl));
             int clientversion = int.Parse(File.ReadAllText(clientversionpath));
             if (server > clientversion)
             {
                 client.DownloadFile(downloadurl, zipfile);
                 try
                 {

                     {
                         if (File.Exists(@".downloading\update.zip")) ;
                            String ZipPath = zipfile;
                            String extractPath = gamepath;
                            ZipFile.ExtractToDirectory(ZipPath, extractPath);
                        if (MessageBox.Show(gamename + " has been successfully updated", "4K Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            File.Delete(@".downloading\update.zip");
                        }

                    }

                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Unable to download update or extract Zip file", "4K Game Launcher",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

             }
             else
             {
                 MessageBox.Show(gamename + "is already up-to-date", "4K Game Launcher",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
             } 
    }
}
}