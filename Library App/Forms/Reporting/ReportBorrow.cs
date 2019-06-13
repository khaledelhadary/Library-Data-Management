using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App.Forms.Reporting
{
    public partial class ReportBorrow : Form
    {
        public ReportBorrow()
        {
            InitializeComponent();
        }

        private void ReportBorrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'borrowDataSet.tbl_Borrow' table. You can move, or remove it, as needed.
            this.tbl_BorrowTableAdapter.Fill(this.borrowDataSet.tbl_Borrow);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
