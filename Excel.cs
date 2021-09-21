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
    public partial class Excel : Form
    {
        public Excel()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //label
            //this.lblUsername.Text = "hello";
            //button
            this.btnImport.Text = "Import";
            //button
            this.btnSearch.Text = "Search";
            //button
            this.btnExport.Text = "Export";
            //button
            this.btnClose.Text = "Close";

            //textbox
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.txtCriteria.Text = String.Empty;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = "Data";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportExcel frmExcel = new ImportExcel();
            frmExcel.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
