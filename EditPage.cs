
using PassKeyp.Events;
using PassKeyp.Models;
using PassKeyp.Processes;
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
        public List<Login> Logins;
        public Login toedit;

        public EditPage(Login toEdit)
        {
            InitializeComponent();
            this.toedit = toEdit;
            Console.WriteLine(toedit);
        }

        //sends user back to file page
        private void btnSave_Click(object sender, EventArgs e)
        {
            Logins[Logins.IndexOf(toedit)] = new Login(txtWebsite.Text, txtUsername.Text, txtPassword.Text);
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
        
        private void EditPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
            //changes the title of the app to match the name of the file
            Label lblEditDataFor = new Label();
            lblEditDataFor.Text = "Editing Data For: " + Keyp.Filename;
            lblEditDataFor.Location = new Point(250, 20);
            lblEditDataFor.AutoSize = true;
            lblEditDataFor.Font = new Font("Segoe UI", 24);
            lblEditDataFor.Padding = new Padding(6);
            this.Controls.Add(lblEditDataFor);
            Console.WriteLine(lblEditDataFor.Text);
            this.txtWebsite.Text = toedit.Website;
            this.txtUsername.Text = toedit.Username;
            this.txtPassword.Text = toedit.Password;
        }
    }
}
