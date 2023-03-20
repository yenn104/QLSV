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
  public partial class FormDanhSachSV : Form
  {
    string key = "";
    public FormDanhSachSV()
    {
      InitializeComponent();
    }

    private void FormDanhSachSV_Load(object sender, EventArgs e)
    {
      LoadDSSV();
    }

    private void LoadDSSV()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });
      dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", list);

      dgvSinhVien.Columns["MSSV"].HeaderText = "MSSV";
      dgvSinhVien.Columns["Ho"].HeaderText = "Họ";
      dgvSinhVien.Columns["Ten"].HeaderText = "Tên";
      dgvSinhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
      dgvSinhVien.Columns["GioiTinh"].HeaderText = "Giới tính";
      dgvSinhVien.Columns["QueQuan"].HeaderText = "Quê quán";
      dgvSinhVien.Columns["SDT"].HeaderText = "Điện thoại";
      dgvSinhVien.Columns["Mail"].HeaderText = "Mail";
      
    }

    private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var MSSV = dgvSinhVien.Rows[e.RowIndex].Cells["MSSV"].Value.ToString();
        new FormSinhVien(MSSV).ShowDialog();
        LoadDSSV();
      }
    }

    private void btnThemSV_Click(object sender, EventArgs e)
    {
      new FormSinhVien(null).ShowDialog();
      LoadDSSV();
    }

    private void txtKeySV_TextChanged(object sender, EventArgs e)
    {
      key = txtKeySV.Text;
      LoadDSSV();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      key = "";
      LoadDSSV();
    }
  }
}
