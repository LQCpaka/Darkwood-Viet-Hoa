using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DarkwoodVH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private string selectedPath;


        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog browse = new CommonOpenFileDialog();
            browse.IsFolderPicker = true;
            if (browse.ShowDialog() == CommonFileDialogResult.Ok)
            {
                selectedPath = browse.FileName;
                lbfolderPath.Text = selectedPath;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseM_MouseLeave(object sender, EventArgs e)
        {
            btnBrowseM.Visible = false;
            BtnBrowseB.Visible = true;

        }

        private void BtnBrowseB_MouseEnter(object sender, EventArgs e)
        {
            btnBrowseM.Visible = true;
            BtnBrowseB.Visible = false;
        }

        private void btnInstallM_MouseLeave(object sender, EventArgs e)
        {
            btnInstallM.Visible = false;
            btnInstallB.Visible = true;
        }

        private void btnInstallB_MouseEnter(object sender, EventArgs e)
        {
            btnInstallM.Visible = true;
            btnInstallB.Visible = false;
        }

        private void btnBrowseM_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog browse = new CommonOpenFileDialog();
            browse.IsFolderPicker = true;
            if (browse.ShowDialog() == CommonFileDialogResult.Ok)
            {
                selectedPath = browse.FileName;
                lbPath.Text = selectedPath;
            }
        }

        private void btnInstallM_Click(object sender, EventArgs e)
        {
            string sourceFilePath = Path.Combine(Application.StartupPath, "Resource.bin");
            
            if (!string.IsNullOrEmpty(sourceFilePath))
            {

                try
                {
                    using (ZipArchive archive = ZipFile.OpenRead(sourceFilePath))
                    {
                        foreach (ZipArchiveEntry entry in archive.Entries)
                        {
                            string fullPath = Path.Combine(selectedPath, entry.FullName);

                            // Create directory if needed
                            if (entry.FullName.EndsWith("/") || entry.FullName.EndsWith("\\"))
                            {
                                Directory.CreateDirectory(fullPath);
                                continue;
                            }

                            // Extract the file
                            entry.ExtractToFile(fullPath, true);
                        }
                    }

                    pSucceded.Visible = true;
                    timer1.Start();

                }
                catch
                {

                    pFail.Visible = true;
                    timer1.Start();
                }


            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pFail.Visible = false;
            pSucceded.Visible = false;
            timer1.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbPath_MouseHover(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(lbPath, selectedPath);
        }
    }
}
