
namespace QLSV
{
  partial class FormDanhSachCTDT
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
      this.btnThem = new System.Windows.Forms.Button();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.txtKey = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dgvDSCTDT = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnLuu = new System.Windows.Forms.Button();
      this.lblMa = new System.Windows.Forms.Label();
      this.txtMa = new System.Windows.Forms.TextBox();
      this.mtbNgayBD = new System.Windows.Forms.MaskedTextBox();
      this.lblTen = new System.Windows.Forms.Label();
      this.txtTen = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTDT)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnThem
      // 
      this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnThem.BackColor = System.Drawing.Color.DarkCyan;
      this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnThem.ForeColor = System.Drawing.Color.White;
      this.btnThem.Location = new System.Drawing.Point(948, 99);
      this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(118, 39);
      this.btnThem.TabIndex = 18;
      this.btnThem.Text = "Cập nhật";
      this.btnThem.UseVisualStyleBackColor = false;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefresh.BackColor = System.Drawing.Color.DarkCyan;
      this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnRefresh.ForeColor = System.Drawing.Color.White;
      this.btnRefresh.Location = new System.Drawing.Point(1090, 99);
      this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(103, 39);
      this.btnRefresh.TabIndex = 17;
      this.btnRefresh.Text = "Làm mới";
      this.btnRefresh.UseVisualStyleBackColor = false;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // txtKey
      // 
      this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtKey.Location = new System.Drawing.Point(948, 29);
      this.txtKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtKey.Multiline = true;
      this.txtKey.Name = "txtKey";
      this.txtKey.Size = new System.Drawing.Size(245, 28);
      this.txtKey.TabIndex = 16;
      this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label1.Location = new System.Drawing.Point(846, 32);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 20);
      this.label1.TabIndex = 15;
      this.label1.Text = "Tìm kiếm";
      // 
      // dgvDSCTDT
      // 
      this.dgvDSCTDT.AllowUserToAddRows = false;
      this.dgvDSCTDT.AllowUserToDeleteRows = false;
      this.dgvDSCTDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvDSCTDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvDSCTDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvDSCTDT.Location = new System.Drawing.Point(1, 169);
      this.dgvDSCTDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvDSCTDT.MultiSelect = false;
      this.dgvDSCTDT.Name = "dgvDSCTDT";
      this.dgvDSCTDT.ReadOnly = true;
      this.dgvDSCTDT.RowHeadersWidth = 51;
      this.dgvDSCTDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvDSCTDT.Size = new System.Drawing.Size(1264, 424);
      this.dgvDSCTDT.TabIndex = 14;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnLuu);
      this.groupBox1.Controls.Add(this.lblMa);
      this.groupBox1.Controls.Add(this.txtMa);
      this.groupBox1.Controls.Add(this.mtbNgayBD);
      this.groupBox1.Controls.Add(this.lblTen);
      this.groupBox1.Controls.Add(this.txtTen);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(1, 10);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(796, 128);
      this.groupBox1.TabIndex = 27;
      this.groupBox1.TabStop = false;
      // 
      // btnLuu
      // 
      this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnLuu.BackColor = System.Drawing.Color.DarkCyan;
      this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.btnLuu.ForeColor = System.Drawing.Color.White;
      this.btnLuu.Location = new System.Drawing.Point(696, 19);
      this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(81, 37);
      this.btnLuu.TabIndex = 33;
      this.btnLuu.Text = "Lưu";
      this.btnLuu.UseVisualStyleBackColor = false;
      this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
      // 
      // lblMa
      // 
      this.lblMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblMa.AutoSize = true;
      this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblMa.Location = new System.Drawing.Point(106, 32);
      this.lblMa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMa.Name = "lblMa";
      this.lblMa.Size = new System.Drawing.Size(32, 20);
      this.lblMa.TabIndex = 28;
      this.lblMa.Text = "Mã";
      // 
      // txtMa
      // 
      this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtMa.Location = new System.Drawing.Point(164, 27);
      this.txtMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtMa.Multiline = true;
      this.txtMa.Name = "txtMa";
      this.txtMa.Size = new System.Drawing.Size(175, 28);
      this.txtMa.TabIndex = 27;
      // 
      // mtbNgayBD
      // 
      this.mtbNgayBD.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.mtbNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.mtbNgayBD.Location = new System.Drawing.Point(531, 26);
      this.mtbNgayBD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.mtbNgayBD.Mask = "00/00/0000";
      this.mtbNgayBD.Name = "mtbNgayBD";
      this.mtbNgayBD.Size = new System.Drawing.Size(128, 27);
      this.mtbNgayBD.TabIndex = 32;
      this.mtbNgayBD.ValidatingType = typeof(System.DateTime);
      // 
      // lblTen
      // 
      this.lblTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTen.AutoSize = true;
      this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.lblTen.Location = new System.Drawing.Point(106, 70);
      this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblTen.Name = "lblTen";
      this.lblTen.Size = new System.Drawing.Size(37, 20);
      this.lblTen.TabIndex = 30;
      this.lblTen.Text = "Tên";
      // 
      // txtTen
      // 
      this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.txtTen.Location = new System.Drawing.Point(164, 75);
      this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtTen.Multiline = true;
      this.txtTen.Name = "txtTen";
      this.txtTen.Size = new System.Drawing.Size(613, 30);
      this.txtTen.TabIndex = 29;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
      this.label2.Location = new System.Drawing.Point(380, 31);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(141, 20);
      this.label2.TabIndex = 31;
      this.label2.Text = "Thời gian áp dụng";
      // 
      // FormDanhSachCTDT
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1264, 593);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnThem);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.txtKey);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dgvDSCTDT);
      this.Name = "FormDanhSachCTDT";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chương trình đào tạo";
      this.Load += new System.EventHandler(this.FormDanhSachCTDT_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvDSCTDT)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txtKey;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgvDSCTDT;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.MaskedTextBox mtbNgayBD;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblTen;
    private System.Windows.Forms.TextBox txtTen;
    private System.Windows.Forms.Label lblMa;
    private System.Windows.Forms.TextBox txtMa;
  }
}