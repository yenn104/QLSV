﻿namespace QLSV
{
    partial class FormBaoCaoDSSV
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
      this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dSSVDataSet = new QLSV.DSSVDataSet();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.label1 = new System.Windows.Forms.Label();
      this.sinhVienTableAdapter = new QLSV.DSSVDataSetTableAdapters.SinhVienTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dSSVDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // sinhVienBindingSource
      // 
      this.sinhVienBindingSource.DataMember = "SinhVien";
      this.sinhVienBindingSource.DataSource = this.dSSVDataSet;
      // 
      // dSSVDataSet
      // 
      this.dSSVDataSet.DataSetName = "DSSVDataSet";
      this.dSSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      reportDataSource1.Name = "SinhVienDataSet";
      reportDataSource1.Value = this.sinhVienBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLSV.Reportings.RPSinhVien.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(31, 59);
      this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(1564, 310);
      this.reportViewer1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(918, 70);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(135, 17);
      this.label1.TabIndex = 5;
      this.label1.Text = "True:Nam Fales: Nữ";
      // 
      // sinhVienTableAdapter
      // 
      this.sinhVienTableAdapter.ClearBeforeFill = true;
      // 
      // FormBaoCaoDSSV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1622, 430);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.reportViewer1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "FormBaoCaoDSSV";
      this.Text = "FormBaoCaoDSSV";
      this.Load += new System.EventHandler(this.FormBaoCaoDSSV_Load);
      ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dSSVDataSet)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private DSSVDataSet dSSVDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DSSVDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
    }
}