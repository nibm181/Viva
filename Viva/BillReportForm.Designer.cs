namespace Viva
{
    partial class BillReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GarmentStock = new Viva.GarmentStock();
            this.tbl_garmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_garmentTableAdapter = new Viva.GarmentStockTableAdapters.tbl_garmentTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Bill = new Viva.Bill();
            this.DataTable1TableAdapter = new Viva.BillTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GarmentStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_garmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Viva.BillReport1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(690, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // GarmentStock
            // 
            this.GarmentStock.DataSetName = "GarmentStock";
            this.GarmentStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_garmentBindingSource
            // 
            this.tbl_garmentBindingSource.DataMember = "tbl_garment";
            this.tbl_garmentBindingSource.DataSource = this.GarmentStock;
            // 
            // tbl_garmentTableAdapter
            // 
            this.tbl_garmentTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Bill;
            // 
            // Bill
            // 
            this.Bill.DataSetName = "Bill";
            this.Bill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // BillReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 736);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(730, 736);
            this.MinimumSize = new System.Drawing.Size(730, 736);
            this.Name = "BillReportForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.BillReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GarmentStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_garmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Bill Bill;
        private BillTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource tbl_garmentBindingSource;
        private GarmentStock GarmentStock;
        private GarmentStockTableAdapters.tbl_garmentTableAdapter tbl_garmentTableAdapter;
    }
}