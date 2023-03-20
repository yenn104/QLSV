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
  public partial class FormDSSinhVienLop : Form
  {
    string MaLop;
    string key = "";
    public FormDSSinhVienLop(string MaLop)
    {
      this.MaLop = MaLop;
      InitializeComponent();
    }

    private void LoadDSSV()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      
      list.Add(new CustomParameter()
      {
        name = "@MaLop",
        value = MaLop
      });

      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });

      dgvDS.DataSource = new Database().SelectData("SelectSinhVienLop", list);
    }

    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSSV();
    }

    private void FormDSSinhVienLop_Load(object sender, EventArgs e)
    {
      LoadDSSV();
      dgvDS.Columns["MSSV"].HeaderText = "MSSV";
      dgvDS.Columns["Ho"].HeaderText = "Họ";
      dgvDS.Columns["Ten"].HeaderText = "Tên";
      dgvDS.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
      dgvDS.Columns["GioiTinh"].HeaderText = "Giới tính";
      dgvDS.Columns["QueQuan"].HeaderText = "Quê quán";
      dgvDS.Columns["SDT"].HeaderText = "Điện thoại";
      dgvDS.Columns["Mail"].HeaderText = "Mail";
    }



  }
}
