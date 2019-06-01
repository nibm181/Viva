namespace Viva
{
    partial class RecutReportForm
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
            this.ReCutDataSet = new Viva.ReCutDataSet();
            this.tbl_garmentTableAdapter = new Viva.ReCutDataSetTableAdapters.tbl_garmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_garmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReCutDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_garmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Viva.ReCutReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(675, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_garmentBindingSource
            // 
            this.tbl_garmentBindingSource.DataMember = "tbl_garment";
            this.tbl_garmentBindingSource.DataSource = this.ReCutDataSet;
            // 
            // ReCutDataSet
            // 
            this.ReCutDataSet.DataSetName = "ReCutDataSet";
            this.ReCutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_garmentTableAdapter
            // 
            this.tbl_garmentTableAdapter.ClearBeforeFill = true;
            // 
            // RecutReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 736);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(721, 736);
            this.MinimumSize = new System.Drawing.Size(721, 736);
            this.Name = "RecutReportForm";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Recut Report";
            this.Load += new System.EventHandler(this.RecutReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_garmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReCutDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_garmentBindingSource;
        private ReCutDataSet ReCutDataSet;
        private ReCutDataSetTableAdapters.tbl_garmentTableAdapter tbl_garmentTableAdapter;
    }
}