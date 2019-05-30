namespace Viva
{
    partial class MaterialStockReportForm
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
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaterialDataSet = new Viva.MaterialDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.materialsTableAdapter = new Viva.MaterialDataSetTableAdapters.materialsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.MaterialDataSet;
            // 
            // MaterialDataSet
            // 
            this.MaterialDataSet.DataSetName = "MaterialDataSet";
            this.MaterialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.materialsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Viva.MaterialStockReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(47, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(730, 630);
            this.reportViewer1.TabIndex = 0;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // MaterialStockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 736);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(826, 736);
            this.MinimumSize = new System.Drawing.Size(826, 736);
            this.Name = "MaterialStockReportForm";
            this.Text = "Material Stock Report";
            this.Load += new System.EventHandler(this.MaterialStockReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private MaterialDataSet MaterialDataSet;
        private MaterialDataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
    }
}