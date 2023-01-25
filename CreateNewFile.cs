using PassKeyp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeyp
{
    public partial class CreateNewFile : Form
    {
        public List<Login> Logins = new List<Login>();

        public CreateNewFile()
        {
            InitializeComponent();
        }

        //sends user to file page
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //if all fields are filled in, create new file
            if(txtFilename.Text != "" && txtPassword.Text != "")
            {
                string path = txtFileLocation.Text + "\\" + txtFilename.Text + ".zip";
                Console.WriteLine(txtFileLocation.Text);
                //using (StreamWriter sw = File.CreateText(txtFileLocation.Text + "\\" + txtFilename.Text + ".txt")) ;
                ZipFile.CreateFromDirectory(txtFileLocation.Text, path);
                using (FileStream zipToOpen = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        ZipArchiveEntry readmeEntry = archive.CreateEntry(txtFilename.Text + ".txt");
                    }
                }
                FilePage myForm = new FilePage(txtFileLocation.Text, txtPassword.Text, Logins);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }

            //if no filename, give error
            if(txtFilename.Text == "")
            {
                Label Filenamewarning = new Label();
                Filenamewarning.Text = "Error! No filename!";
                Filenamewarning.Location = new Point(200, 400);
                Filenamewarning.AutoSize = true;
                Filenamewarning.Font = new Font("Segoe UI", 16);
                Filenamewarning.ForeColor = Color.Red;
                Filenamewarning.Padding = new Padding(6);
                this.Controls.Add(Filenamewarning);
                Console.WriteLine(Filenamewarning.Text);
            }

            //if no password, give error
            if (txtPassword.Text == "")
            {
                Label Passwordwarning = new Label();
                Passwordwarning.Text = "Error! No Password!";
                Passwordwarning.Location = new Point(400, 400);
                Passwordwarning.AutoSize = true;
                Passwordwarning.Font = new Font("Segoe UI", 16);
                Passwordwarning.ForeColor = Color.Red;
                Passwordwarning.Padding = new Padding(6);
                this.Controls.Add(Passwordwarning);
                Console.WriteLine(Passwordwarning.Text);
            }
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
