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
  public partial class FormDanhSachCN : Form
  {
    string key = "";
    public FormDanhSachCN()
    {
      InitializeComponent();
    }


    private void LoadDSCN()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });
      dgvDSCN.DataSource = new Database().SelectData("SelectAllDSCN", list);
    }

    private void FormDanhSachCN_Load(object sender, EventArgs e)
    {
      LoadDSCN();
      dgvDSCN.Columns["MaCN"].HeaderText = "Mã chuyên ngành";
      dgvDSCN.Columns["TenCN"].HeaderText = "Tên chuyên ngành";
      dgvDSCN.Columns["SoTC"].HeaderText = "Số tín chỉ";
      dgvDSCN.Columns["TenNganh"].HeaderText = "Ngành";
    }


    private void btnRefresh_Click(object sender, EventArgs e)
    {
      key = "";
      LoadDSCN();
    }

    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSCN();
    }

    private void dgvDSCN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var MaCN = dgvDSCN.Rows[e.RowIndex].Cells["MaCN"].Value.ToString();
        new FormDanhSachCTDT(MaCN).ShowDialog();
        LoadDSCN();
      }
    }

    private void btnThemCN_Click(object sender, EventArgs e)
    {
      new FormChuyenNganh(null).ShowDialog();
      LoadDSCN();
    }


    private void dgvDSCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var MaCN = dgvDSCN.Rows[e.RowIndex].Cells["MaCN"].Value.ToString();
        new FormChuyenNganh(MaCN).ShowDialog();
        LoadDSCN();
      }
    }
  }
}
