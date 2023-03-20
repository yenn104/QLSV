
namespace QLSV
{
  partial class FormHocBong
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnChuyenTien = new System.Windows.Forms.Button();
      this.txtKey = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dgvDS = new System.Windows.Forms.DataGridView();
      this.btnRefresh = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.ForeColor = System.Drawing.Color.DarkCyan;
      this.label1.Location = new System.Drawing.Point(258, 79);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(363, 25);
      this.label1.TabIndex = 8;
      this.label1.Text = "QUẢN LÝ HỌC BỔNG CỦA SINH VIÊN";
      // 
      // btnChuyenTien
      // 
      this.btnChuyenTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnChuyenTien.BackColor = System.Drawing.Color.DarkCyan;
      this.btnChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnChuyenTien.ForeColor = System.Drawing.Color.White;
      this.btnChuyenTien.Location = new System.Drawing.Point(760, 110);
      this.btnChuyenTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnChuyenTien.Name = "btnChuyenTien";
      this.btnChuyenTien.Size = new System.Drawing.Size(149, 41);
      this.btnChuyenTien.TabIndex = 6;
      this.btnChuyenTien.Text = "Chuyển tiền";
      this.btnChuyenTien.UseVisualStyleBackColor = false;
      this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
      // 
      // txtKey
      // 
      this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKey.Location = new System.Drawing.Point(845, 49);
      this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtKey.Multiline = true;
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new System.Drawing.Size(213, 28);
      this.txtKey.TabIndex = 11;
      this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.Location = new System.Drawing.Point(757, 56);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 18);
      this.label2.TabIndex = 10;
      this.label2.Text = "Tìm kiếm";
      // 
      // dgvDS
      // 
      this.dgvDS.AllowUserToAddRows = false;
      this.dgvDS.AllowUserToDeleteRows = false;
      this.dgvDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDS.Location = new System.Drawing.Point(54, 171);
      this.dgvDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvDS.MultiSelect = false;
      this.dgvDS.Name = "dgvDS";
      this.dgvDS.ReadOnly = true;
      this.dgvDS.RowHeadersWidth = 51;
      this.dgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDS.Size = new System.Drawing.Size(1102, 338);
      this.dgvDS.TabIndex = 26;
      this.dgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_CellClick);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(936, 110);
      this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(122, 41);
      this.btnRefresh.TabIndex = 27;
      this.btnRefresh.Text = "Làm mới";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // FormHocBong
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1209, 510);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.dgvDS);
      this.Controls.Add(this.txtKey);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnChuyenTien);
      this.Name = "FormHocBong";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Học bổng";
      this.Load += new System.EventHandler(this.FormHocBong_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDS)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnChuyenTien;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dgvDS;
    private System.Windows.Forms.Button btnRefresh;
  }
}