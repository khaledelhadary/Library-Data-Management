namespace Library_App.Forms.Reporting
{
    partial class ReportBorrow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblBorrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.borrowDataSet = new Library_App.BorrowDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_BorrowTableAdapter = new Library_App.BorrowDataSetTableAdapters.tbl_BorrowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblBorrowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblBorrowBindingSource
            // 
            this.tblBorrowBindingSource.DataMember = "tbl_Borrow";
            this.tblBorrowBindingSource.DataSource = this.borrowDataSet;
            // 
            // borrowDataSet
            // 
            this.borrowDataSet.DataSetName = "BorrowDataSet";
            this.borrowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tblBorrowBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Library_App.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(782, 426);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tbl_BorrowTableAdapter
            // 
            this.tbl_BorrowTableAdapter.ClearBeforeFill = true;
            // 
            // ReportBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportBorrow";
            this.Text = "ReportBorrow";
            this.Load += new System.EventHandler(this.ReportBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblBorrowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BorrowDataSet borrowDataSet;
        private System.Windows.Forms.BindingSource tblBorrowBindingSource;
        private BorrowDataSetTableAdapters.tbl_BorrowTableAdapter tbl_BorrowTableAdapter;
    }
}