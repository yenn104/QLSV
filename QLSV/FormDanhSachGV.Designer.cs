
namespace QLSV
{
  partial class FormDanhSachGV
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
      this.dgvGiangVien = new System.Windows.Forms.DataGridView();
      this.btnThemMoi = new System.Windows.Forms.Button();
      this.btnTimKiem = new System.Windows.Forms.Button();
      this.txtTimKiem = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvGiangVien
      // 
      this.dgvGiangVien.AllowUserToAddRows = false;
      this.dgvGiangVien.AllowUserToDeleteRows = false;
      this.dgvGiangVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvGiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvGiangVien.Location = new System.Drawing.Point(0, 114);
      this.dgvGiangVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvGiangVien.MultiSelect = false;
      this.dgvGiangVien.Name = "dgvGiangVien";
      this.dgvGiangVien.ReadOnly = true;
      this.dgvGiangVien.RowHeadersWidth = 51;
      this.dgvGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvGiangVien.Size = new System.Drawing.Size(1152, 517);
      this.dgvGiangVien.TabIndex = 8;
      this.dgvGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSGV_CellContentClick);
      // 
      // btnThemMoi
      // 
      this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnThemMoi.BackColor = System.Drawing.Color.DarkCyan;
      this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnThemMoi.ForeColor = System.Drawing.Color.White;
      this.btnThemMoi.Location = new System.Drawing.Point(1026, 42);
      this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnThemMoi.Name = "btnThemMoi";
      this.btnThemMoi.Size = new System.Drawing.Size(98, 42);
      this.btnThemMoi.TabIndex = 6;
      this.btnThemMoi.Text = "Thêm mới";
      this.btnThemMoi.UseVisualStyleBackColor = false;
      this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
      // 
      // btnTimKiem
      // 
      this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTimKiem.BackColor = System.Drawing.Color.DarkCyan;
      this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnTimKiem.ForeColor = System.Drawing.Color.White;
      this.btnTimKiem.Location = new System.Drawing.Point(901, 42);
      this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new System.Drawing.Size(98, 42);
      this.btnTimKiem.TabIndex = 7;
      this.btnTimKiem.Text = "Tìm kiếm";
      this.btnTimKiem.UseVisualStyleBackColor = false;
      this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
      // 
      // txtTimKiem
      // 
      this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTimKiem.Location = new System.Drawing.Point(606, 50);
      this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtTimKiem.Name = "txtTimKiem";
      this.txtTimKiem.Size = new System.Drawing.Size(260, 27);
      this.txtTimKiem.TabIndex = 5;
      this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(521, 54);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Tìm kiếm";
      // 
      // FormDanhSachGV
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1152, 629);
      this.Controls.Add(this.dgvGiangVien);
      this.Controls.Add(this.btnThemMoi);
      this.Controls.Add(this.btnTimKiem);
      this.Controls.Add(this.txtTimKiem);
      this.Controls.Add(this.label1);
      this.Name = "FormDanhSachGV";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh sách giảng viên khoa";
      this.Load += new System.EventHandler(this.FormDanhSachGV_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvGiangVien;
    private System.Windows.Forms.Button btnThemMoi;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Label label1;
  }
}