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
  public partial class FormDSLichDay : Form
  {
    string UserName;
    string key = "";
    public FormDSLichDay(string UserName)
    {
      this.UserName = UserName;
      InitializeComponent();
    }

    private void LoadDSLichDay()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });

      list.Add(new CustomParameter()
      {
        name = "@MaGV",
        value = UserName
      });

      dgvDS.DataSource = new Database().SelectData("SelectLichDay", list);
    }

    private void FormDSLichDay_Load(object sender, EventArgs e)
    {
      LoadDSLichDay();
      dgvDS.Columns["MaLop"].HeaderText = "Lớp";
      dgvDS.Columns["MaMH"].HeaderText = "Mã môn học";
      dgvDS.Columns["TenMH"].HeaderText = "Tên môn học";
      dgvDS.Columns["SoTC"].HeaderText = "Số tín chỉ";
      dgvDS.Columns["Tiet"].HeaderText = "Tiết";
      dgvDS.Columns["Thu"].HeaderText = "Thứ";
      dgvDS.Columns["NgayBD"].HeaderText = "Ngày bắt đầu";
      dgvDS.Columns["NgayKT"].HeaderText = "Ngày kết thúc";

      //tkb.MaLop,tkb.MaMH, m.TenMH, m.SoTC, Tiet, Thu, convert(varchar(10),NgayBD,103) AS NgayBD, convert(varchar(10),NgayKT,103) AS NgayKT
    }

    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSLichDay();
    }

  }
}
