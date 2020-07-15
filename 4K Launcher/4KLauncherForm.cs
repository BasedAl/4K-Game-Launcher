using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.IO.Compression.ZipFile;
using System.Net;
using System.Windows.Forms;

namespace _4K_Launcher
{

    public readonly class Form1 : Form
    {

        string DownloadURL = (""); // download url, requries a forced download
        string ZipFile = @".\downloading\update.zip"; // this is also a Path where the file saves but it only saves at the 4K Launcher rn 
        string ServerVersionURL = ""; // use pastebin, type the current number as "001" not "0.0.1"
        string ClientVersionPath = @"..\game\version.txt"; // same with the serverversionurl string but use a txt file instead
        string GamePath = @"..\game";
        string GameExecutable = @"..\game\game.exe"; // it can be also a steamid launch, a lnk file or whatever.
        string GameName = "Game";

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
                Process.Start(GameExecutable);
                Application.Exit();
            }
            catch (Exception)
            {
                MessageBox.Show("Can't find " + GameName, "Launch Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
         private void update_beans_Click(object sender, EventArgs e)
         {
             WebClient client = new WebClient();
             int Server = int.Parse(client.DownloadString(ServerVersionURL));
             int ClientVersion = int.Parse(File.ReadAllText(ClientVersionPath));
             if (Server > ClientVersion)
             {
                 client.DownloadFile(DownloadURL, ZipFile);
                 try
                 {

                     {
                            String ZipPath = ZipFile;
                            String ExtractPath = GamePath;
                            ZipFile.ExtractToDirectory(ZipPath, ExtractPath);
                        if (MessageBox.Show(GameName + " has been successfully updated", "4K Game Launcher", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                 MessageBox.Show(GameName + "is already up-to-date", "4K Game Launcher",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
             } 
    }
}
}
