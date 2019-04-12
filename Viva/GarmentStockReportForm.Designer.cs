namespace Viva
{
    partial class GarmentStockReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_garmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GarmentStock = new Viva.GarmentStock();
            this.tbl_garmentTableAdapter = new Viva.GarmentStockTableAdapters.tbl_garmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_garmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GarmentStock)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "GarmentStock";
            reportDataSource1.Value = this.tbl_garmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Viva.GarmentStockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(768, 380);
            this.reportViewer1.TabIndex = 3;
            // 
            // tbl_garmentBindingSource
            // 
            this.tbl_garmentBindingSource.DataMember = "tbl_garment";
            this.tbl_garmentBindingSource.DataSource = this.GarmentStock;
            // 
            // GarmentStock
            // 
            this.GarmentStock.DataSetName = "GarmentStock";
            this.GarmentStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_garmentTableAdapter
            // 
            this.tbl_garmentTableAdapter.ClearBeforeFill = true;
            // 
            // GarmentStockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 460);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GarmentStockReportForm";
            this.Text = "Monthly Garment Stock Report";
            this.Load += new System.EventHandler(this.GarmentStockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_garmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GarmentStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_garmentBindingSource;
        private GarmentStock GarmentStock;
        private GarmentStockTableAdapters.tbl_garmentTableAdapter tbl_garmentTableAdapter;
    }
}