namespace Viva
{
    partial class used_material_report_form
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
            this.um_rv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_garmentTableAdapter1 = new Viva.GarmentStockTableAdapters.tbl_garmentTableAdapter();
            this.Used_materials = new Viva.Used_materials();
            this.material_usedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.material_usedTableAdapter = new Viva.Used_materialsTableAdapters.material_usedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Used_materials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.material_usedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // um_rv
            // 
            reportDataSource1.Name = "usedmaterialdataset";
            reportDataSource1.Value = this.material_usedBindingSource;
            this.um_rv.LocalReport.DataSources.Add(reportDataSource1);
            this.um_rv.LocalReport.ReportEmbeddedResource = "Viva.Report1.rdlc";
            this.um_rv.Location = new System.Drawing.Point(168, 64);
            this.um_rv.Margin = new System.Windows.Forms.Padding(4);
            this.um_rv.Name = "um_rv";
            this.um_rv.ServerReport.BearerToken = null;
            this.um_rv.Size = new System.Drawing.Size(795, 666);
            this.um_rv.TabIndex = 4;
            this.um_rv.Load += new System.EventHandler(this.um_rv_Load);
            // 
            // tbl_garmentTableAdapter1
            // 
            this.tbl_garmentTableAdapter1.ClearBeforeFill = true;
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
            // used_material_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 764);
            this.Controls.Add(this.um_rv);
            this.Name = "used_material_report_form";
            this.Text = "Used Material Report";
            this.Load += new System.EventHandler(this.used_material_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Used_materials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.material_usedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer um_rv;
        private GarmentStockTableAdapters.tbl_garmentTableAdapter tbl_garmentTableAdapter1;
        private System.Windows.Forms.BindingSource material_usedBindingSource;
        private Used_materials Used_materials;
        private Used_materialsTableAdapters.material_usedTableAdapter material_usedTableAdapter;
    }
}