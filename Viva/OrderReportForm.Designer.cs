namespace Viva
{
    partial class OrderReportForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.date_from = new MetroFramework.Controls.MetroDateTime();
            this.date_to = new MetroFramework.Controls.MetroDateTime();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrderDataSet = new Viva.OrderDataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new Viva.OrderDataSetTableAdapters.DataTable1TableAdapter();
            this.btn_generate = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(52, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "From Date";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(401, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 25);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "To Date";
            // 
            // date_from
            // 
            this.date_from.Location = new System.Drawing.Point(149, 99);
            this.date_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(200, 29);
            this.date_from.TabIndex = 1;
            // 
            // date_to
            // 
            this.date_to.Location = new System.Drawing.Point(475, 99);
            this.date_to.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(200, 29);
            this.date_to.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Viva.OrderReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 155);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(754, 272);
            this.reportViewer1.TabIndex = 3;
            // 
            // OrderDataSet
            // 
            this.OrderDataSet.DataSetName = "OrderDataSet";
            this.OrderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.OrderDataSet;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(702, 103);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseSelectable = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // OrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "OrderReportForm";
            this.Text = "OrderReportForm";
            this.Load += new System.EventHandler(this.OrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime date_from;
        private MetroFramework.Controls.MetroDateTime date_to;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private OrderDataSet OrderDataSet;
        private OrderDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private MetroFramework.Controls.MetroButton btn_generate;
    }
}