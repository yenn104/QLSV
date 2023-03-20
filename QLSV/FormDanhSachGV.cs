using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
  public partial class FormDanhSachGV : Form
  {
    string key = "";
    public FormDanhSachGV()
    {
      InitializeComponent();
    }
    

    private void FormDanhSachGV_Load(object sender, EventArgs e)
    {
      loadDSGV();
      dgvGiangVien.Columns["MaGV"].HeaderText = "Mã giáo viên";
      dgvGiangVien.Columns["MaHV"].HeaderText = "Học vị";
      dgvGiangVien.Columns["Ho"].HeaderText = "Họ";
      dgvGiangVien.Columns["Ten"].HeaderText = "Tên";
      dgvGiangVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
      dgvGiangVien.Columns["GioiTinh"].HeaderText = "Giới tính";
      dgvGiangVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
      dgvGiangVien.Columns["SDT"].HeaderText = "Điện thoại";
      dgvGiangVien.Columns["Mail"].HeaderText = "Mail";
      
    }

    private void loadDSGV()
    {
      string sql = "SelectAllGV";
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });
      dgvGiangVien.DataSource = new Database().SelectData(sql, list);
    }

    private void dgvDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var MaGV = dgvGiangVien.Rows[e.RowIndex].Cells["MaGV"].Value.ToString();
        new FormGiangVien(MaGV).ShowDialog();
        loadDSGV();
      }
    }

    private void btnThemMoi_Click(object sender, EventArgs e)
    {
      new FormGiangVien(null).ShowDialog();
      loadDSGV();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      key = txtTimKiem.Text;
      loadDSGV();
    }

    private void txtTimKiem_TextChanged(object sender, EventArgs e)
    {
      key = txtTimKiem.Text;
      loadDSGV();
    }
  }
}
