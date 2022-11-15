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
            FilePage myForm = new FilePage(FileInfo.Filename);
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        //sends user ack to file page
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FilePage myForm = new FilePage(FileInfo.Filename);
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

        private void EditPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
            Label lblEditDataFor = new Label();
            lblEditDataFor.Text = lblEditDataFor.Text + FileInfo.Filename;
            this.Controls.Add(lblEditDataFor);
            Console.WriteLine(lblEditDataFor.Text);
        }

        private void lblEditDataFor_Click(object sender, EventArgs e)
        {
            lblEditDataFor.Text = lblEditDataFor.Text + FileInfo.Filename;
        }
    }
}
