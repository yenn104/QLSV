
namespace QLSV
{
  partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mimHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mimQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mimCTDT = new System.Windows.Forms.ToolStripMenuItem();
            this.mimGiangDay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLichDay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuanLyLop = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mimThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.họcPhíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nợMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchThờiKhóaBiểuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHọcBổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mimKhenThuong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHocBong = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mimHeThong,
            this.mimQuanLy,
            this.mimCTDT,
            this.mimGiangDay,
            this.mimThongKe,
            this.mimKhenThuong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1761, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mimHeThong
            // 
            this.mimHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDoiMatKhau,
            this.tsThoat});
            this.mimHeThong.Name = "mimHeThong";
            this.mimHeThong.Size = new System.Drawing.Size(103, 29);
            this.mimHeThong.Text = "Hệ thống";
            // 
            // tsDoiMatKhau
            // 
            this.tsDoiMatKhau.Name = "tsDoiMatKhau";
            this.tsDoiMatKhau.Size = new System.Drawing.Size(270, 34);
            this.tsDoiMatKhau.Text = "Đổi mật khẩu";
            this.tsDoiMatKhau.Click += new System.EventHandler(this.tsDoiMatKhau_Click);
            // 
            // tsThoat
            // 
            this.tsThoat.Name = "tsThoat";
            this.tsThoat.Size = new System.Drawing.Size(270, 34);
            this.tsThoat.Text = "Thoát";
            this.tsThoat.Click += new System.EventHandler(this.tsThoat_Click);
            // 
            // mimQuanLy
            // 
            this.mimQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSinhVien,
            this.tsMonHoc,
            this.tsGiangVien,
            this.tsLopHoc});
            this.mimQuanLy.Name = "mimQuanLy";
            this.mimQuanLy.Size = new System.Drawing.Size(89, 29);
            this.mimQuanLy.Text = "Quản lý";
            // 
            // tsSinhVien
            // 
            this.tsSinhVien.Name = "tsSinhVien";
            this.tsSinhVien.Size = new System.Drawing.Size(197, 34);
            this.tsSinhVien.Text = "Sinh viên";
            this.tsSinhVien.Click += new System.EventHandler(this.tsSinhVien_Click);
            // 
            // tsMonHoc
            // 
            this.tsMonHoc.Name = "tsMonHoc";
            this.tsMonHoc.Size = new System.Drawing.Size(197, 34);
            this.tsMonHoc.Text = "Môn học";
            this.tsMonHoc.Click += new System.EventHandler(this.tsMonHoc_Click);
            // 
            // tsGiangVien
            // 
            this.tsGiangVien.Name = "tsGiangVien";
            this.tsGiangVien.Size = new System.Drawing.Size(197, 34);
            this.tsGiangVien.Text = "Giảng viên";
            this.tsGiangVien.Click += new System.EventHandler(this.tsGiangVien_Click);
            // 
            // tsLopHoc
            // 
            this.tsLopHoc.Name = "tsLopHoc";
            this.tsLopHoc.Size = new System.Drawing.Size(197, 34);
            this.tsLopHoc.Text = "Lớp học";
            this.tsLopHoc.Click += new System.EventHandler(this.tsLopHoc_Click);
            // 
            // mimCTDT
            // 
            this.mimCTDT.Name = "mimCTDT";
            this.mimCTDT.Size = new System.Drawing.Size(200, 29);
            this.mimCTDT.Text = "Chương trình đào tạo";
            this.mimCTDT.Click += new System.EventHandler(this.mimCTDT_Click);
            // 
            // mimGiangDay
            // 
            this.mimGiangDay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLichDay,
            this.tsQuanLyLop,
            this.tsNhapDiem});
            this.mimGiangDay.Name = "mimGiangDay";
            this.mimGiangDay.Size = new System.Drawing.Size(110, 29);
            this.mimGiangDay.Text = "Giảng Dạy";
            // 
            // tsLichDay
            // 
            this.tsLichDay.Name = "tsLichDay";
            this.tsLichDay.Size = new System.Drawing.Size(206, 34);
            this.tsLichDay.Text = "Lịch dạy";
            this.tsLichDay.Click += new System.EventHandler(this.tsLichDay_Click);
            // 
            // tsQuanLyLop
            // 
            this.tsQuanLyLop.Name = "tsQuanLyLop";
            this.tsQuanLyLop.Size = new System.Drawing.Size(206, 34);
            this.tsQuanLyLop.Text = "Quản lý lớp";
            // 
            // tsNhapDiem
            // 
            this.tsNhapDiem.Name = "tsNhapDiem";
            this.tsNhapDiem.Size = new System.Drawing.Size(206, 34);
            this.tsNhapDiem.Text = "Nhập điểm";
            // 
            // mimThongKe
            // 
            this.mimThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họcPhíToolStripMenuItem,
            this.nợMônToolStripMenuItem,
            this.danhSáchThờiKhóaBiểuToolStripMenuItem,
            this.danhSáchĐiểmToolStripMenuItem,
            this.danhSáchHọcBổngToolStripMenuItem});
            this.mimThongKe.Name = "mimThongKe";
            this.mimThongKe.Size = new System.Drawing.Size(102, 29);
            this.mimThongKe.Text = "Thống kê";
            // 
            // họcPhíToolStripMenuItem
            // 
            this.họcPhíToolStripMenuItem.Name = "họcPhíToolStripMenuItem";
            this.họcPhíToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.họcPhíToolStripMenuItem.Text = "Danh sách sinh viên";
            this.họcPhíToolStripMenuItem.Click += new System.EventHandler(this.họcPhíToolStripMenuItem_Click);
            // 
            // nợMônToolStripMenuItem
            // 
            this.nợMônToolStripMenuItem.Name = "nợMônToolStripMenuItem";
            this.nợMônToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.nợMônToolStripMenuItem.Text = "Danh sách giảng viên";
            this.nợMônToolStripMenuItem.Click += new System.EventHandler(this.nợMônToolStripMenuItem_Click);
            // 
            // danhSáchThờiKhóaBiểuToolStripMenuItem
            // 
            this.danhSáchThờiKhóaBiểuToolStripMenuItem.Name = "danhSáchThờiKhóaBiểuToolStripMenuItem";
            this.danhSáchThờiKhóaBiểuToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.danhSáchThờiKhóaBiểuToolStripMenuItem.Text = "Danh sách thời khóa biểu";
            this.danhSáchThờiKhóaBiểuToolStripMenuItem.Click += new System.EventHandler(this.danhSáchThờiKhóaBiểuToolStripMenuItem_Click);
            // 
            // danhSáchĐiểmToolStripMenuItem
            // 
            this.danhSáchĐiểmToolStripMenuItem.Name = "danhSáchĐiểmToolStripMenuItem";
            this.danhSáchĐiểmToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.danhSáchĐiểmToolStripMenuItem.Text = "Danh sách điểm";
            this.danhSáchĐiểmToolStripMenuItem.Click += new System.EventHandler(this.danhSáchĐiểmToolStripMenuItem_Click);
            // 
            // danhSáchHọcBổngToolStripMenuItem
            // 
            this.danhSáchHọcBổngToolStripMenuItem.Name = "danhSáchHọcBổngToolStripMenuItem";
            this.danhSáchHọcBổngToolStripMenuItem.Size = new System.Drawing.Size(315, 34);
            this.danhSáchHọcBổngToolStripMenuItem.Text = "Danh sách học bổng";
            this.danhSáchHọcBổngToolStripMenuItem.Click += new System.EventHandler(this.danhSáchHọcBổngToolStripMenuItem_Click);
            // 
            // mimKhenThuong
            // 
            this.mimKhenThuong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHocBong});
            this.mimKhenThuong.Name = "mimKhenThuong";
            this.mimKhenThuong.Size = new System.Drawing.Size(134, 29);
            this.mimKhenThuong.Text = "Khen Thưởng";
            // 
            // tsHocBong
            // 
            this.tsHocBong.Name = "tsHocBong";
            this.tsHocBong.Size = new System.Drawing.Size(193, 34);
            this.tsHocBong.Text = "Học Bổng";
            this.tsHocBong.Click += new System.EventHandler(this.tsHocBong_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1761, 874);
            this.pnlContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 874);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlContent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mimHeThong;
    private System.Windows.Forms.ToolStripMenuItem tsDoiMatKhau;
    private System.Windows.Forms.ToolStripMenuItem tsThoat;
    private System.Windows.Forms.ToolStripMenuItem mimQuanLy;
    private System.Windows.Forms.ToolStripMenuItem tsSinhVien;
    private System.Windows.Forms.ToolStripMenuItem tsMonHoc;
    private System.Windows.Forms.ToolStripMenuItem tsGiangVien;
    private System.Windows.Forms.ToolStripMenuItem tsLopHoc;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.ToolStripMenuItem mimCTDT;
    private System.Windows.Forms.ToolStripMenuItem mimThongKe;
    private System.Windows.Forms.ToolStripMenuItem họcPhíToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nợMônToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mimGiangDay;
    private System.Windows.Forms.ToolStripMenuItem tsLichDay;
    private System.Windows.Forms.ToolStripMenuItem tsQuanLyLop;
    private System.Windows.Forms.ToolStripMenuItem tsNhapDiem;
    private System.Windows.Forms.ToolStripMenuItem mimKhenThuong;
    private System.Windows.Forms.ToolStripMenuItem tsHocBong;
        private System.Windows.Forms.ToolStripMenuItem danhSáchThờiKhóaBiểuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHọcBổngToolStripMenuItem;
    }
}

