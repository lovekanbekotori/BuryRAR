using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuryRAR
{
    public partial class buryRAR : Form
    {
        string rarFileName = null;
        string baseFileName = null;
        public buryRAR()
        {
            InitializeComponent();
        }

        private void rarFileBtn_Click(object sender, EventArgs e)
        {
            rarFileDialog.Filter = "Rar Files (*.rar) | *.rar" ;
            rarFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rarFileDialog.FileName = "";
            DialogResult result = rarFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                rarFileName = rarFileDialog.FileName;
                rarFileTxtBox.Text = rarFileName;
            }
        }

        private void baseFileBtn_Click(object sender, EventArgs e)
        {
            baseFileDialog.Filter = "All Files (*.*) | *.*";
            baseFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            baseFileDialog.FileName = "";
            DialogResult result = baseFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                baseFileName = baseFileDialog.FileName;
                baseFileTxtBox.Text = baseFileName;
            }
        }

        private void buryRarBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process cmdProcess = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo cmdProcessInfo = new System.Diagnostics.ProcessStartInfo();
            cmdProcessInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            cmdProcessInfo.FileName = "cmd.exe";
            string newFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                + "\\" + newFileTxtBox.Text;
            string arguments = "/C copy /b [baseFile] + [rarFile] [newFile]"
                .Replace("[baseFile]", baseFileName)
                .Replace("[rarFile]", rarFileName)
                .Replace("[newFile]", newFileLocation);
            cmdProcessInfo.Arguments = arguments;
            cmdProcess.StartInfo = cmdProcessInfo;
            cmdProcess.Start();
            MessageBox.Show("New file saved to " + newFileLocation 
                + "!", "BuryRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buryRAR_Load(object sender, EventArgs e) { }

        private void githubOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sufficey/BuryRAR/");
        }
    }
}
