using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HentaiDownloaderV._2.Properties;

namespace HentaiDownloaderV._2
{
    public partial class Form1 : Form
    {
        private string[] links;
        private HDownloader HDownloader;
        public Form1()
        {
            InitializeComponent();
            HDownloader = new HDownloader();
            Path.Text = Settings.Default.DestinoDescargas;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            URLERROR.Visible = false;
            links = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < links.Length; i++)
            {
                if(int.TryParse(links[i], out var Code) && links[i].Length <= 7)
                {
                    links[i] = $"https://nhentai.net/g/{Code}/";
                }
                if (!links[i].StartsWith("https://nhentai.net/g/"))
                {
                    URLERROR.Visible = true;
                }
            }        
        }

        private async void Download_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < links.Length; i++)
            {
                await HDownloader.HentaiP(links[i], Path.Text);
            }
            MessageBox.Show(string.Format("Download Complete"));
        }
        private void Path_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Text))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = Path.Text,
                    FileName = "explorer.exe",
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", Path.Text));
            }
        }

        private void PathB_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Seleccione Carpeta de Destino";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Path.Text = fbd.SelectedPath;
                Settings.Default.DestinoDescargas = Path.Text;
                Settings.Default.Save();
                Settings.Default.Reload();
            }
        }
    }
}
