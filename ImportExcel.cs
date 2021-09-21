using ProjectSept13.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSept13
{
    public partial class ImportExcel : Form
    {

        string _file = string.Empty;

        public ImportExcel()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = "Data";

            this.txtFile.Enabled = false;
           // this.MaximizeBox = 
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            //Set title of the dialog
            openFile.Filter = "Excel 7.0 (*.xlsx)|*.xlsx" + "|" +
                "Excel < 7.0 (*.xls)|8.xls" + "|" +
                "CSV (*.csv)|*.csv" + "|" +
                "All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _file = openFile.FileName;
                this.txtFile.Text = _file;
            }
        }

        private void btnImportSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_file))
            {
                MessageBox.Show("There is no file to import");
                return;
            }
            DataSet ds = new DataSet();
            Cursor.Current = Cursors.WaitCursor;
            ds = ExcelImportService.GetExcelData(_file);
            Cursor.Current = Cursors.Default;
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
