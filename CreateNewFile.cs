using PassKeyp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PassKeyp
{
    public partial class CreateNewFile : Form
    {
        public List<Login> Logins = new List<Login>();

        string sPath = string.Empty;
        string sZip = string.Empty;
        string sFile = string.Empty;

        public CreateNewFile()
        {
            InitializeComponent();
        }

        private void CreateFile()
        {
            string sloc = sPath + "\\" + sFile;

            if (System.IO.File.Exists(sloc))
                System.IO.File.Delete(sloc);

            using (StreamWriter Strwriter = new StreamWriter(sloc))
            {
                Strwriter.Write("Hello");
                Strwriter.Flush();
                Strwriter.Close();
                Strwriter.Dispose();
            }
        }

        private void PerformZip()
        {
            //Delete if File Exists
            if (System.IO.File.Exists(sZip))
                System.IO.File.Delete(sZip);

            //Add file to Zip File
            using (var archive = ZipFile.Open(sZip, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(sPath + "\\" + sFile, sFile, CompressionLevel.Optimal);
            }
        }
        //sends user to file page
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!PerformValidation())
                return;

            sFile = this.txtFilename.Text.Trim() + ".txt";
            sPath = this.txtFileLocation.Text.Trim();
            sZip = sPath + "\\" + this.txtFilename.Text.Trim() + ".zip";

            this.CreateFile();
            this.PerformZip();
            
            FilePage myForm = new FilePage(sZip, txtPassword.Text, Logins);
                
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private bool PerformValidation()
        {
            if (String.IsNullOrEmpty(this.txtFilename.Text.Trim()))
            {
                //if no filename, give error
                Label Filenamewarning = new Label();
                Filenamewarning.Text = "Error! No filename!";
                Filenamewarning.Location = new Point(200, 400);
                Filenamewarning.AutoSize = true;
                Filenamewarning.Font = new Font("Segoe UI", 16);
                Filenamewarning.ForeColor = Color.Red;
                Filenamewarning.Padding = new Padding(6);
                this.Controls.Add(Filenamewarning);
                Console.WriteLine(Filenamewarning.Text);

                return false;
            }
            else if (String.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                //if no password, give error
                Label Passwordwarning = new Label();
                Passwordwarning.Text = "Error! No Password!";
                Passwordwarning.Location = new Point(400, 400);
                Passwordwarning.AutoSize = true;
                Passwordwarning.Font = new Font("Segoe UI", 16);
                Passwordwarning.ForeColor = Color.Red;
                Passwordwarning.Padding = new Padding(6);
                this.Controls.Add(Passwordwarning);
                Console.WriteLine(Passwordwarning.Text);

                return false;
            }

            return true;
        }

        //sends user back to login page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginPage myForm = new LoginPage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        //allows user to load a file from file explorer
        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            int size = -1;
            FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();
            DialogResult result = openFolderDialog1.ShowDialog(); // Show the dialog.
            txtFileLocation.Text = openFolderDialog1.SelectedPath;
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        //Ensures User can't mess with the form
        private void setControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CreateNewFile_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
        }
    }
}
