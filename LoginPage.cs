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
    public partial class LoginPage : Form
    {
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
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    this.txtFileLocation.Text = file; // <-- file location is added to text box
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
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
            FilePage myForm = new FilePage(txtFileLocation.Text);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
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
