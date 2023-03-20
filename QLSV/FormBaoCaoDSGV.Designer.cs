namespace QLSV
{
    partial class FormBaoCaoDSGV
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
      this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.qLSVDataSet = new QLSV.QLSVDataSet();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.label1 = new System.Windows.Forms.Label();
      this.giangVienTableAdapter = new QLSV.QLSVDataSetTableAdapters.GiangVienTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // giangVienBindingSource
      // 
      this.giangVienBindingSource.DataMember = "GiangVien";
      this.giangVienBindingSource.DataSource = this.qLSVDataSet;
      // 
      // qLSVDataSet
      // 
      this.qLSVDataSet.DataSetName = "QLSVDataSet";
      this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      reportDataSource1.Name = "GiangVienDataSet";
      reportDataSource1.Value = this.giangVienBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Reportings.RPGiangVien.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(37, 86);
      this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(1030, 371);
      this.reportViewer1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(866, 94);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(135, 17);
      this.label1.TabIndex = 4;
      this.label1.Text = "True:Nam Fales: Nữ";
      // 
      // giangVienTableAdapter
      // 
      this.giangVienTableAdapter.ClearBeforeFill = true;
      // 
      // FormBaoCaoDSGV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1095, 456);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.reportViewer1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormBaoCaoDSGV";
      this.Text = "FormBaoCaoDSGV";
      this.Load += new System.EventHandler(this.FormBaoCaoDSGV_Load);
      ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QLSVDataSetTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
    }
}