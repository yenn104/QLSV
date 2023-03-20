
namespace QLSV
{
  partial class FormDanhSachSV
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnThemSV = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.txtKeySV = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvSinhVien = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
      this.SuspendLayout();
      // 
      // btnThemSV
      // 
      this.btnThemSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnThemSV.BackColor = System.Drawing.Color.DarkCyan;
      this.btnThemSV.ForeColor = System.Drawing.Color.White;
      this.btnThemSV.Location = new System.Drawing.Point(758, 31);
      this.btnThemSV.Margin = new System.Windows.Forms.Padding(4);
      this.btnThemSV.Name = "btnThemSV";
      this.btnThemSV.Size = new System.Drawing.Size(80, 34);
      this.btnThemSV.TabIndex = 9;
      this.btnThemSV.Text = "Thêm";
      this.btnThemSV.UseVisualStyleBackColor = false;
      this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(867, 31);
      this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(96, 34);
      this.btnRefresh.TabIndex = 8;
      this.btnRefresh.Text = "Làm mới";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // txtKeySV
      // 
      this.txtKeySV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKeySV.Location = new System.Drawing.Point(522, 39);
      this.txtKeySV.Margin = new System.Windows.Forms.Padding(4);
      this.txtKeySV.Multiline = true;
      this.txtKeySV.Name = "txtKeySV";
      this.txtKeySV.Size = new System.Drawing.Size(197, 24);
      this.txtKeySV.TabIndex = 7;
      this.txtKeySV.TextChanged += new System.EventHandler(this.txtKeySV_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(428, 41);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 17);
      this.label1.TabIndex = 6;
      this.label1.Text = "Từ khóa";
      // 
      // dgvSinhVien
      // 
      this.dgvSinhVien.AllowUserToAddRows = false;
      this.dgvSinhVien.AllowUserToDeleteRows = false;
      this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvSinhVien.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvSinhVien.Location = new System.Drawing.Point(0, 90);
      this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4);
      this.dgvSinhVien.MultiSelect = false;
      this.dgvSinhVien.Name = "dgvSinhVien";
      this.dgvSinhVien.ReadOnly = true;
      this.dgvSinhVien.RowHeadersWidth = 51;
      this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvSinhVien.Size = new System.Drawing.Size(1018, 354);
      this.dgvSinhVien.TabIndex = 5;
      this.dgvSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellDoubleClick);
      // 
      // FormDanhSachSV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1018, 443);
      this.Controls.Add(this.btnThemSV);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.txtKeySV);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvSinhVien);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FormDanhSachSV";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh sách sinh viên";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.FormDanhSachSV_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnThemSV;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txtKeySV;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvSinhVien;
  }
}