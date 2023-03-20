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
  public partial class FormHocBong : Form
  {
    string MSSV, ten, Money;
    string key = "";
    public FormHocBong()
    {
      InitializeComponent();
    }

    private void btnChuyenTien_Click(object sender, EventArgs e)
    {
      DialogResult y = MessageBox.Show("Bạn muốn chuyển tiền cho " + ten, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      if (y == DialogResult.OK)
      {
        new FormChuyenTien(MSSV, ten, Money).ShowDialog();
        LoadDSHB();
      }
    }


    private void LoadDSHB()
    {
      List<CustomParameter> list = new List<CustomParameter>();      
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });
      dgvDS.DataSource = new Database().SelectData("SelectHocBong", list);
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }

    private void FormHocBong_Load(object sender, EventArgs e)
    {
      LoadDSHB();
      dgvDS.Columns["MSSV"].HeaderText = "MSSV";
      dgvDS.Columns["Ho"].HeaderText = "Họ";
      dgvDS.Columns["Ten"].HeaderText = "Tên";
      dgvDS.Columns["Diem"].HeaderText = "Điểm";
      dgvDS.Columns["XepLoai"].HeaderText = "Xếp loại";
      dgvDS.Columns["MucThuong"].HeaderText = "Mức thưởng";
      dgvDS.Columns["TrangThai"].HeaderText = "Trạng thái";
    }

    private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        MSSV = dgvDS.Rows[e.RowIndex].Cells["MSSV"].Value.ToString();
        string a  = dgvDS.Rows[e.RowIndex].Cells["Ho"].Value.ToString();
        string b = dgvDS.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
        Money = dgvDS.Rows[e.RowIndex].Cells["MucThuong"].Value.ToString();
        ten = a + " "+b;    
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      txtKey.Text = "";
      key = "";
      LoadDSHB();
    }

    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSHB();
    }


  }
}
