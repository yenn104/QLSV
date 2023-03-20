namespace QLSV
{
    partial class FormBaoCaoTKB
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
      this.dSTKBBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.qLTKBDataSet = new QLSV.QLTKBDataSet();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.dS_TKBTableAdapter = new QLSV.QLTKBDataSetTableAdapters.DS_TKBTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.dSTKBBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLTKBDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // dSTKBBindingSource
      // 
      this.dSTKBBindingSource.DataMember = "DS_TKB";
      this.dSTKBBindingSource.DataSource = this.qLTKBDataSet;
      // 
      // qLTKBDataSet
      // 
      this.qLTKBDataSet.DataSetName = "QLTKBDataSet";
      this.qLTKBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      reportDataSource1.Name = "TKBDataSet";
      reportDataSource1.Value = this.dSTKBBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Reportings.RPTKB.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(-1, 58);
      this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(1147, 405);
      this.reportViewer1.TabIndex = 0;
      // 
      // dS_TKBTableAdapter
      // 
      this.dS_TKBTableAdapter.ClearBeforeFill = true;
      // 
      // FormBaoCaoTKB
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1144, 461);
      this.Controls.Add(this.reportViewer1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormBaoCaoTKB";
      this.Text = "FormBaoCaoTKB";
      this.Load += new System.EventHandler(this.FormBaoCaoTKB_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dSTKBBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLTKBDataSet)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLTKBDataSet qLTKBDataSet;
        private System.Windows.Forms.BindingSource dSTKBBindingSource;
        private QLTKBDataSetTableAdapters.DS_TKBTableAdapter dS_TKBTableAdapter;
    }
}