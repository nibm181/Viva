namespace Viva
{
    partial class used_mat_report_form
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
            this.Used_materials = new Viva.Used_materials();
            this.material_usedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material_usedTableAdapter = new Viva.Used_materialsTableAdapters.material_usedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Used_materials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.material_usedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "used_mat_dataset";
            reportDataSource1.Value = this.material_usedBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Viva.used_mat_report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(86, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(996, 766);
            this.reportViewer1.TabIndex = 0;
            // 
            // Used_materials
            // 
            this.Used_materials.DataSetName = "Used_materials";
            this.Used_materials.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // material_usedBindingSource
            // 
            this.material_usedBindingSource.DataMember = "material_used";
            this.material_usedBindingSource.DataSource = this.Used_materials;
            // 
            // material_usedTableAdapter
            // 
            this.material_usedTableAdapter.ClearBeforeFill = true;
            // 
            // used_mat_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 918);
            this.Controls.Add(this.reportViewer1);
            this.Name = "used_mat_report_form";
            this.Text = "Used Material Report Form";
            this.Load += new System.EventHandler(this.used_mat_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Used_materials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.material_usedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource material_usedBindingSource;
        private Used_materials Used_materials;
        private Used_materialsTableAdapters.material_usedTableAdapter material_usedTableAdapter;
    }
}