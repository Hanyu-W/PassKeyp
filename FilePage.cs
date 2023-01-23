using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HowTo.Processes;
using PassKeyp.Events;
using PassKeyp.Models;

namespace PassKeyp
{
    public partial class FilePage : Form
    {
        public List<Login> Logins = new List<Login>();

        public int opentimes = 0;

        public int previousWebsiteIndex;

        public int previousUsernameIndex;

        public int previousPasswordIndex;

        public bool elseclick { get; set; }

        public FilePage(string filepath, string password, List<Login> logins)
        {
            InitializeComponent();
            Keyp.Pathname = filepath;
            //Gets the name of the file by taking the 
            //part of the path after the last backslash
            //in .txt form
            string tmp = filepath.Substring(filepath.LastIndexOf("\\")+1);
            Keyp.Filename = tmp.Substring(0, tmp.IndexOf(".")) + ".txt";
            Console.WriteLine();
            this.Logins = logins;
        }

        //send user to edit file page
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //EditPage myForm = new EditPage();
            //myForm.Logins = this.Logins;
            //myForm.ShowDialog();
        }

        //sends user to add new page
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            elseclick = true;
            lstUsernames.Enabled = false;
            lstPasswords.Enabled = false;
            lstWebsites.Enabled = false;

            AddNewPage myForm = new AddNewPage();
            myForm.Logins = this.Logins;
            //Access the Event which is used by the Delegate
            //Pass in a method on THIS FORM 
            //This will cause the Deletegate on the "Add Customers" Form
            //To access the method on this Form (Customers)
            //UpdateCustomers is the Variable declared in "Add Customers" form
            //CustomersHandler is the delegate declared in "Add Customers" form
            myForm.UpdateLogins += new AddNewPage.LoginHandler(LoginsUpdate);

            myForm.ShowDialog();
            PopulateLogins();


            lstWebsites.SelectedIndex = -1;
            lstUsernames.SelectedIndex = -1;
            lstPasswords.SelectedIndex = -1;

            lstUsernames.Enabled = true;
            lstPasswords.Enabled = true;
            lstWebsites.Enabled = true;
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
            //creates title and updates it based on the name of the file
            Label lblDataFor = new Label();
            lblDataFor.Text = "Data For: " + Keyp.Filename;
            lblDataFor.Location = new Point(250, 20);
            lblDataFor.AutoSize = true;
            lblDataFor.Font = new Font("Segoe UI", 24);
            lblDataFor.Padding = new Padding(6);
            this.Controls.Add(lblDataFor);
            if(Logins.Count == 0)
            {
                Logins = Login.GetLogins();
            }
            Console.WriteLine(Logins);
            this.PopulateLogins();
            lstWebsites.SelectedIndex = -1;
            lstUsernames.SelectedIndex = -1;
            lstPasswords.SelectedIndex = -1;
            previousWebsiteIndex = 1;
            previousUsernameIndex = 1;
            previousPasswordIndex = 1;
            elseclick = false;
        }

        private void PopulateLogins()
        {
            //Use LINQ to get logins from the Login
            var websites = (from c in Logins select c.Website).ToList();
            Console.WriteLine(websites.ToString());
            //Set the DataSource of the listbox to the logins  collection
            this.lstWebsites.DataSource = websites;

            var usernames = (from c in Logins select c.Username).ToList();
            this.lstUsernames.DataSource = usernames;

            var passwords = (from c in Logins select c.Password).ToList();
            this.lstPasswords.DataSource = passwords;
        }

        private void LoginsUpdate(object s, UpdateLoginEventArgs e)
        {
            //Get the customers from "Add Customers" form which was passed to the
            //UpdateCustomersEventArg Class that we created for this
            Logins = e.GetLogins;

            //Populate the listbox with new changes to Customers
            this.PopulateLogins();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            elseclick = true;
            lstUsernames.Enabled = false;
            lstPasswords.Enabled = false;
            lstWebsites.Enabled = false;
            //calls merge to sort the array
            Logins = Merge(Logins, 0, Logins.Count - 1);

            //list box is updated with correctly sorted array of logins
            this.PopulateLogins();

            lstWebsites.SelectedIndex = -1;
            lstUsernames.SelectedIndex = -1;
            lstPasswords.SelectedIndex = -1;

            lstUsernames.Enabled = true;
            lstPasswords.Enabled = true;
            lstWebsites.Enabled = true;
        }

        //implements merge sort
        public List<Login> Merge(List<Login> array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                Console.WriteLine(middle);
                Merge(array, left, middle);
                Merge(array, middle + 1, right);
                Mergesort(array, left, middle, right);
            }
            return array;

        }

        //arrary is merged back together
        public void Mergesort(List<Login> array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            Console.WriteLine(leftArrayLength);
            Console.WriteLine(rightArrayLength);
            var leftTempArray = new Login[leftArrayLength];
            var rightTempArray = new Login[rightArrayLength];

            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];

            i = 0;
            j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i].Website.Trim().CompareTo(rightTempArray[j].Website.Trim()) <= 0)
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }

            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
            foreach (var a in array)
            {
                Console.WriteLine(a.Website);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            elseclick = true;
            lstUsernames.Enabled = false;
            lstPasswords.Enabled = false;
            lstWebsites.Enabled = false;
            foreach(Login o in Logins)
            {
                Console.WriteLine(o.ToString());
            }
            TextFileInputOutput.ExportDataToTextFile(Logins, Keyp.Pathname);
            lstUsernames.Enabled = true;
            lstPasswords.Enabled = true;
            lstWebsites.Enabled = true;
        }

        private void lstWebsites_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWebsites.SelectedIndex == -1 || opentimes == 0)
            {
                Console.WriteLine("One");
                opentimes++;
                previousWebsiteIndex = lstWebsites.SelectedIndex;
                return;
            }

            /* else if(previousWebsiteIndex == lstWebsites.SelectedIndex)
            {
                Console.WriteLine("Two");
                return;
            }
            */
            else if (opentimes > 1)
            {
                Console.WriteLine("Three");
                Console.WriteLine(opentimes);
                opentimes = 0;
                return;
            }
            /*
            else if(lstWebsites.SelectedIndex == lstUsernames.SelectedIndex || lstWebsites.SelectedIndex == lstPasswords.SelectedIndex)
            {
                Console.WriteLine("Four");
                return;
            } */

            else if (elseclick)
            {
                elseclick = false;
                return;
            }
            previousWebsiteIndex = lstWebsites.SelectedIndex;
            opentimes++;
            elseclick = true;


            Console.WriteLine("five");
            Console.WriteLine(opentimes);
            //Console.WriteLine(lstWebsites.SelectedIndex);
            //Console.WriteLine(this.Logins[lstWebsites.SelectedIndex].ToString());

            lstUsernames.Enabled = false;
            lstPasswords.Enabled = false;
            lstWebsites.Enabled = false;

            //send user to edit page
            EditPage myForm = new EditPage(this.Logins[lstWebsites.SelectedIndex]);
            myForm.Logins = this.Logins;
            myForm.UpdateLogins += new EditPage.LoginHandler(LoginsUpdate);
            myForm.ShowDialog();
            this.PopulateLogins();
            lstWebsites.SelectedIndex = -1;
            lstUsernames.SelectedIndex = -1;
            lstPasswords.SelectedIndex = -1;

            lstUsernames.Enabled = true;
            lstPasswords.Enabled = true;
            lstWebsites.Enabled = true;
        }

        private void lstUsernames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstWebsites.SelectedIndex = -1;
            lstUsernames.SelectedIndex = -1;
            lstPasswords.SelectedIndex = -1;
        }

        private void lstPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstWebsites.SelectedIndex = -1;
            lstUsernames.SelectedIndex = -1;
            lstPasswords.SelectedIndex = -1;
        }
    }
}
