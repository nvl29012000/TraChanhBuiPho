namespace demobtl
{
    partial class fReport
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
            this.Fn_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Trachanhbuipho1DataSet = new demobtl.Trachanhbuipho1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Fn_ReportTableAdapter = new demobtl.Trachanhbuipho1DataSetTableAdapters.Fn_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Fn_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trachanhbuipho1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Fn_ReportBindingSource
            // 
            this.Fn_ReportBindingSource.DataMember = "Fn_Report";
            this.Fn_ReportBindingSource.DataSource = this.Trachanhbuipho1DataSet;
            // 
            // Trachanhbuipho1DataSet
            // 
            this.Trachanhbuipho1DataSet.DataSetName = "Trachanhbuipho1DataSet";
            this.Trachanhbuipho1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Fn_ReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "demobtl.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(642, 634);
            this.reportViewer1.TabIndex = 0;
            // 
            // Fn_ReportTableAdapter
            // 
            this.Fn_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(642, 634);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.fReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fn_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trachanhbuipho1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Fn_ReportBindingSource;
        private Trachanhbuipho1DataSet Trachanhbuipho1DataSet;
        private Trachanhbuipho1DataSetTableAdapters.Fn_ReportTableAdapter Fn_ReportTableAdapter;
    }
}