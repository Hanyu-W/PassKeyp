using PassKeyp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassKeyp
{
    public partial class EditPage : Form
    {
        public EditPage()
        {
            InitializeComponent();
        }

        //sends user back to file page
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sends user back to file page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ensures User can't mess with the form
        private void setControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        
        //changes the title of the app to match the name of the file
        private void EditPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
            Label lblEditDataFor = new Label();
            lblEditDataFor.Text = "Editing Data For: " + Keyp.Filename;
            lblEditDataFor.Location = new Point(200, 20);
            lblEditDataFor.AutoSize = true;
            lblEditDataFor.Font = new Font("Segoe UI", 24);
            lblEditDataFor.Padding = new Padding(6);
            this.Controls.Add(lblEditDataFor);
            Console.WriteLine(lblEditDataFor.Text);
        }
    }
}
