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
            FilePage myForm = new FilePage(FileInfo.Filename);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        //sends user back to file page
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FilePage myForm = new FilePage(FileInfo.Filename);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void AddNewPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
        }
    }
}
