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
    }
}
