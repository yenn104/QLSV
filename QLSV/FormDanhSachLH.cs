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
  public partial class FormDanhSachLH : Form
  {
    string key = "";
    public FormDanhSachLH()
    {
      InitializeComponent();
    }

    private void LoadDSLH()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });
      dgvDSLH.DataSource = new Database().SelectData("SelectAllLop", list);
    }

    private void FormDanhSachLH_Load(object sender, EventArgs e)
    {
      LoadDSLH();
      dgvDSLH.Columns["MaLop"].HeaderText = "Mã lớp học";
      dgvDSLH.Columns["TenLop"].HeaderText = "Tên lớp học";
      dgvDSLH.Columns["SiSo"].HeaderText = "Sỉ số";
    }

    private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var MaLop = dgvDSLH.Rows[e.RowIndex].Cells["MaLop"].Value.ToString();
        new FormLopHoc(MaLop).ShowDialog();
        LoadDSLH();
      }
    }

    private void btnThemLH_Click(object sender, EventArgs e)
    {
      new FormLopHoc(null).ShowDialog();
      LoadDSLH();
    }



    private void txtKeyLH_TextChanged(object sender, EventArgs e)
    {
      key = txtKeyLH.Text;
      LoadDSLH();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      key = "";
      LoadDSLH();
    }
  }
}
