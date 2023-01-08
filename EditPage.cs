
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

        //Delegate
        public delegate void LoginHandler(object sender, UpdateLoginEventArgs e);

        //Event for Delegate 
        //Type CustomersHandler matches the Delegate above
        //UpdateCustomers is the variable used by Form1
        public event LoginHandler UpdateLogins;

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
            //Event Class which is used with the Delegate
            //This helps us pass the changes to the ArrayList Customers to the class 
            //and Retrieved from Form1 "CustomerUpdate" method
            UpdateLoginEventArgs args = new UpdateLoginEventArgs(Logins);

            //Event declared above
            UpdateLogins(this, args);
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

        private void lblFilename_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Logins.Remove(toedit);
            UpdateLoginEventArgs args = new UpdateLoginEventArgs(Logins);

            //Event declared above
            UpdateLogins(this, args);
            this.Close();
        }
    }
}
