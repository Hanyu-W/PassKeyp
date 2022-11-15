using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKeyp.Models;

namespace PassKeyp
{
    public partial class FilePage : Form
    {
        Keyp keyp1;

        public FilePage(Keyp keyp)
        {
            InitializeComponent();
            keyp1 = keyp;
            Console.WriteLine(keyp1.Filename);
        }

        //send user to edit file page
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPage myForm = new EditPage();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        //sends user to add new page
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewPage myForm = new AddNewPage();
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

        private void FilePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
            Label lblDataFor = new Label();
            lblDataFor.Text = "Data For: " + keyp1.Filename;
            lblDataFor.Location = new Point(250, 50);
            lblDataFor.AutoSize = true;
            lblDataFor.Font = new Font("Segoe UI", 24);
            lblDataFor.Padding = new Padding(6);
            this.Controls.Add(lblDataFor);
        }
    }
}
