using PassKeyp.Events;
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
    public partial class AddNewPage : Form
    {
        //Delegate
        public delegate void LoginHandler(object sender, UpdateLoginEventArgs e);

        //Event for Delegate 
        //Type CustomersHandler matches the Delegate above
        //UpdateCustomers is the variable used by Form1
        public event LoginHandler UpdateLogins;

        public List<Login> Logins;

        public AddNewPage()
        {
            InitializeComponent();
        }

        //Ensures User can't mess with the form
        private void setControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        //sends user back to file page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sends user back to file page
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //label for no website is hidden
            Label Websitewarning = new Label();
            Websitewarning.Text = "Error! No website!";
            Websitewarning.Location = new Point(50, 400);
            Websitewarning.AutoSize = true;
            Websitewarning.Font = new Font("Segoe UI", 16);
            Websitewarning.ForeColor = Color.Red;
            Websitewarning.Padding = new Padding(6);
            //Websitewarning.Hide();
            Websitewarning.Visible = false;
            this.Controls.Add(Websitewarning);

            //label for no username is hidden
            Label Usernamewarning = new Label();
            Usernamewarning.Text = "Error! No Username!";
            Usernamewarning.Location = new Point(250, 400);
            Usernamewarning.AutoSize = true;
            Usernamewarning.Font = new Font("Segoe UI", 16);
            Usernamewarning.ForeColor = Color.Red;
            Usernamewarning.Padding = new Padding(6);
            //Usernamewarning.Hide();
            Usernamewarning.Visible = false;
            this.Controls.Add(Usernamewarning);

            //label for no password is hidden
            Label Passwordwarning = new Label();
            Passwordwarning.Text = "Error! No Password!";
            Passwordwarning.Location = new Point(500, 400);
            Passwordwarning.AutoSize = true;
            Passwordwarning.Font = new Font("Segoe UI", 16);
            Passwordwarning.ForeColor = Color.Red;
            Passwordwarning.Padding = new Padding(6);
            //Passwordwarning.Hide();
            Usernamewarning.Visible = false;
            this.Controls.Add(Passwordwarning);

            if (txtPassword.Text.Trim() != "" && txtUsername.Text.Trim() != "" && txtWebsite.Text.Trim() != "")
            {
                Logins.Add(new Login()
                {
                    Website = this.txtWebsite.Text.Trim(),
                    Username = this.txtUsername.Text.Trim(),
                    Password = this.txtPassword.Text.Trim()
                });
                //Event Class which is used with the Delegate
                //This helps us pass the changes to the ArrayList Customers to the class 
                //and Retrieved from Form1 "CustomerUpdate" method
                UpdateLoginEventArgs args = new UpdateLoginEventArgs(Logins);

                //Event declared above
                UpdateLogins(this, args);
                this.Close();
            }

            //if no filename, give error
            if (txtWebsite.Text.Trim() == "")
            {
                Websitewarning.Visible = true;
                Console.WriteLine("lmao");
            }
            else if(txtWebsite.Text.Trim() != "")
            {
                Websitewarning.Visible = false;
                Console.WriteLine("these");
            }

            //if no username, give error
            if (txtUsername.Text.Trim() == "")
            {
                Usernamewarning.Show();
                Console.WriteLine(Usernamewarning.Text);
            }
            else if(txtUsername.Text.Trim() != "")
            {
                Usernamewarning.Hide();
            }

            //if no password, give error
            if (txtPassword.Text.Trim() == "")
            {
                Passwordwarning.Show();
                Console.WriteLine(Passwordwarning.Text);
            }
            else if(txtPassword.Text.Trim() != "")
            {
                Passwordwarning.Hide();
            }
        }

        private void AddNewPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
            //creates title and updates it based on the name of the file
            Label lblDataFor = new Label();
            lblDataFor.Text = "Data For: " + Keyp.Filename;
            lblDataFor.Location = new Point(250, 20);
            lblDataFor.AutoSize = true;
            lblDataFor.Font = new Font("Segoe UI", 24);
            lblDataFor.Padding = new Padding(6);
            this.Controls.Add(lblDataFor);
        }
    }
}
