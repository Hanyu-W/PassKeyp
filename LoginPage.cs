using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HowTo.Processes;
using PassKeyp.Models;

namespace PassKeyp
{
    public partial class LoginPage : Form
    {
        public List<Login> Logins = new List<Login>();

        public LoginPage()
        {
            InitializeComponent();
        }

        //allows user to load a file from file explorer
        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string file = openFileDialog1.FileName;
            txtFileLocation.Text = file;
            
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
             // <-- For debugging use.
        }

        //sends user to add new page
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            CreateNewFile myForm = new CreateNewFile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        //sends user to file page
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtFileLocation.Text != "")
            {
                string name = txtFileLocation.Text;
                Logins = TextFileInputOutput.GetData(name);
                FilePage myForm = new FilePage(txtFileLocation.Text, txtPassword.Text, Logins);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                Label warning = new Label();
                warning.Text = "Error! No filename!";
                warning.Location = new Point(200, 300);
                warning.AutoSize = true;
                warning.Font = new Font("Segoe UI", 16);
                warning.ForeColor = Color.Red;
                warning.Padding = new Padding(6);
                this.Controls.Add(warning);
                Console.WriteLine(warning.Text);
            }
            
        }

        //Ensures User can't mess with the form
        private void setControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
        }
    }
}
