
namespace QLSV
{
  partial class FormGiangVien
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.mtbNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbHocVi = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(315, 494);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(101, 52);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(64, 494);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(101, 52);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // mtbNgaySinh
            // 
            this.mtbNgaySinh.Location = new System.Drawing.Point(161, 288);
            this.mtbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtbNgaySinh.Mask = "00/00/0000";
            this.mtbNgaySinh.Name = "mtbNgaySinh";
            this.mtbNgaySinh.Size = new System.Drawing.Size(148, 26);
            this.mtbNgaySinh.TabIndex = 6;
            this.mtbNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Checked = true;
            this.rbtNu.Location = new System.Drawing.Point(297, 238);
            this.rbtNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(54, 24);
            this.rbtNu.TabIndex = 4;
            this.rbtNu.TabStop = true;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Location = new System.Drawing.Point(161, 238);
            this.rbtNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(67, 24);
            this.rbtNam.TabIndex = 4;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(161, 422);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(255, 26);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(161, 382);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(255, 26);
            this.txtMail.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(161, 342);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(255, 26);
            this.txtSDT.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(55, 426);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(161, 182);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(255, 26);
            this.txtTen.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Học Vị";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(161, 130);
            this.txtHo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(255, 26);
            this.txtHo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ";
            // 
            // cbbHocVi
            // 
            this.cbbHocVi.FormattingEnabled = true;
            this.cbbHocVi.Items.AddRange(new object[] {
            "PGS",
            "TS",
            "ThS",
            "KS"});
            this.cbbHocVi.Location = new System.Drawing.Point(161, 80);
            this.cbbHocVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbHocVi.Name = "cbbHocVi";
            this.cbbHocVi.Size = new System.Drawing.Size(255, 28);
            this.cbbHocVi.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkCyan;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(189, 494);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 52);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 589);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbbHocVi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.mtbNgaySinh);
            this.Controls.Add(this.rbtNu);
            this.Controls.Add(this.rbtNam);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giảng Viên";
            this.Load += new System.EventHandler(this.FormGiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnHuy;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.MaskedTextBox mtbNgaySinh;
    private System.Windows.Forms.RadioButton rbtNu;
    private System.Windows.Forms.RadioButton rbtNam;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.TextBox txtMail;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.TextBox txtTen;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtHo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbbHocVi;
    private System.Windows.Forms.Button btnXoa;
  }
}