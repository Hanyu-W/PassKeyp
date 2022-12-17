using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassKeyp.Events;
using PassKeyp.Models;

namespace PassKeyp
{
    public partial class FilePage : Form
    {
        public List<Login> Logins = new List<Login>();

        public FilePage(string filename, string password)
        {
            InitializeComponent();
            Keyp.Filename = filename;
            Console.WriteLine();
        }

        //send user to edit file page
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPage myForm = new EditPage();
            myForm.ShowDialog();
        }

        //sends user to add new page
        private void btnAddNew_Click(object sender, EventArgs e)
        {
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
            Logins = Login.GetLogins();
            Console.WriteLine(Logins);
            this.PopulateLogins();
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
            //calls merge to sort the array
            Logins = Merge(Logins, 0, Logins.Count - 1);

            //list box is updated with correctly sorted array of logins
            this.PopulateLogins();
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

    }
}
