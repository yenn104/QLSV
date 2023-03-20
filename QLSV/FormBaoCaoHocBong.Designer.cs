namespace QLSV
{
    partial class FormBaoCaoHocBong
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
      this.dSHBBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.qLSVDataSet2 = new QLSV.QLSVDataSet2();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.qLSVDataSet1 = new QLSV.QLSVDataSet1();
      this.selectHocBongBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.selectHocBongTableAdapter = new QLSV.QLSVDataSet1TableAdapters.SelectHocBongTableAdapter();
      this.dS_HBTableAdapter = new QLSV.QLSVDataSet2TableAdapters.DS_HBTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.dSHBBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.selectHocBongBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // dSHBBindingSource
      // 
      this.dSHBBindingSource.DataMember = "DS_HB";
      this.dSHBBindingSource.DataSource = this.qLSVDataSet2;
      // 
      // qLSVDataSet2
      // 
      this.qLSVDataSet2.DataSetName = "QLSVDataSet2";
      this.qLSVDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      reportDataSource1.Name = "HBDataSet";
      reportDataSource1.Value = this.dSHBBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Reportings.RPHB.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 65);
      this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(1237, 441);
      this.reportViewer1.TabIndex = 0;
      // 
      // qLSVDataSet1
      // 
      this.qLSVDataSet1.DataSetName = "QLSVDataSet1";
      this.qLSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // selectHocBongBindingSource
      // 
      this.selectHocBongBindingSource.DataMember = "SelectHocBong";
      this.selectHocBongBindingSource.DataSource = this.qLSVDataSet1;
      // 
      // selectHocBongTableAdapter
      // 
      this.selectHocBongTableAdapter.ClearBeforeFill = true;
      // 
      // dS_HBTableAdapter
      // 
      this.dS_HBTableAdapter.ClearBeforeFill = true;
      // 
      // FormBaoCaoHocBong
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1236, 506);
      this.Controls.Add(this.reportViewer1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormBaoCaoHocBong";
      this.Text = "FormBaoCaoHocBong";
      this.Load += new System.EventHandler(this.FormBaoCaoHocBong_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dSHBBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.selectHocBongBindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectHocBongBindingSource;
        private QLSVDataSet1 qLSVDataSet1;
        private QLSVDataSet1TableAdapters.SelectHocBongTableAdapter selectHocBongTableAdapter;
        private QLSVDataSet2 qLSVDataSet2;
        private System.Windows.Forms.BindingSource dSHBBindingSource;
        private QLSVDataSet2TableAdapters.DS_HBTableAdapter dS_HBTableAdapter;
    }
}