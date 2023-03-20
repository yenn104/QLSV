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
  public partial class FormDanhSachMH : Form
  {
    string key = "";
    public FormDanhSachMH()
    {    
      InitializeComponent();
    }
    private void LoadDSMH()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });
      dgvDSMH.DataSource = new Database().SelectData("SelectAllMonHoc", list);
    }

    private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var MaMH = dgvDSMH.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
        new FormMonHoc(MaMH).ShowDialog();
        LoadDSMH();
      }
    }

    private void btnThemMH_Click(object sender, EventArgs e)
    {
      new FormMonHoc(null).ShowDialog();
      LoadDSMH();
    }

    private void FormDanhSachMH_Load(object sender, EventArgs e)
    {
      LoadDSMH();
      dgvDSMH.Columns["MaMH"].HeaderText = "Mã môn học";
      dgvDSMH.Columns["TenMH"].HeaderText = "Tên môn học";
      dgvDSMH.Columns["SoTC"].HeaderText = "Số tín chỉ";
    }

    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSMH();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      key = "";
      LoadDSMH();
    }


  }
}
