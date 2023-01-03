
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
        DataTable _dt = new DataTable();
        bool isXML = false;

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
        }

        private void PopulateDataGridView(object sender, UpdateDataGridViewEventArgs e)
        {
            //*****************************************************
            //This method is accessed from the ImportExcelData or
            //ImportXMLData form via the delegate
            //*****************************************************

            //First we want to store the DataSet from the Import Process
            //_ds = e.GetDataSet;

            //1st Process the DataSet then assign to "_dt"
            _dt = e.GetDataSet.Tables[0];
            this.RemoveLeadingTrailingSpaces();

            //2nd Set the DataSource of the DataGridView to the DataTable "_dt"
            if (!isXML)
                this.grdData.DataSource = _dt = ProcessDataSet(_dt);
            else
                this.grdData.DataSource = _dt;

            //Set record count
            //this.lblTotal.Text = _dt.Rows.Count.ToString();

            //Format columns in the DataGridView
            this.FormatDataGridViewColumns();
            this.FormatDataGridViewColumnHeaders();

            isXML = false;
        }

        private void RemoveLeadingTrailingSpaces()
        {
            var dataRows = _dt.AsEnumerable();
            foreach (var row in dataRows)
            {
                var cellList = row.ItemArray.ToList();
                row.ItemArray = cellList.Select(x => x.ToString().Trim()).ToArray();
            };

            _dt = dataRows.CopyToDataTable();
            _dt.AcceptChanges();
        }

        private void FormatDataGridViewColumnHeaders()
        {
            //Set the Background Color of the Column Header
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            this.grdData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            //Set the Font for the Column Header
            this.grdData.ColumnHeadersDefaultCellStyle.Font = new Font(new FontFamily("Arial"), 12, FontStyle.Bold);

            //Autosize the coulumns
            this.grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FormatDataGridViewColumns()
        {
            //Format Column as a Short Date Time. Example -> 9/11/21
            this.grdData.Columns["Expiry"].DefaultCellStyle.Format = String.Format("d");
            //Align Right
            this.grdData.Columns["Expiry"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Format Column as Currency
            this.grdData.Columns["InsuredValue"].DefaultCellStyle.Format = String.Format("C");
            //Align Right
            this.grdData.Columns["InsuredValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private DataTable ProcessDataSet(DataTable dt)
        {
            //Variable
            int index = 0;

            //Get Column Names from the DataTable
            foreach (DataColumn dc in dt.Columns)
            {
                dc.ColumnName = dt.Rows[0][index].ToString();
                index++;
            }

            //**********************************************
            //Delete first row which contains column headers
            //**********************************************
            //Create a DataRow and populate with the DataTable
            DataRow[] dr = dt.Select();
            //Delete The first Row
            dr[0].Delete();
            //Update the DataTable by Accept the Changes
            dt.AcceptChanges();

            dt = DataSetTableFunctions.FixDateTimeCol(dt);
            dt = DataSetTableFunctions.FixCurrencyCol(dt);

            return dt;
        }
    }
}
