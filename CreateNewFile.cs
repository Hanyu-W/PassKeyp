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

namespace PassKeyp
{
    public partial class CreateNewFile : Form
    {
        public CreateNewFile()
        {
            InitializeComponent();
        }

        //sends user to file page
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtFilename.Text != "")
            {
                FilePage myForm = new FilePage(txtFilename.Text);
                this.Hide();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                Label warning = new Label();
                warning.Text = "Error! No filename!";
                warning.Location = new Point(200, 400);
                warning.AutoSize = true;
                warning.Font = new Font("Segoe UI", 16);
                warning.ForeColor = Color.Red;
                warning.Padding = new Padding(6);
                this.Controls.Add(warning);
                Console.WriteLine(warning.Text);
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
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
