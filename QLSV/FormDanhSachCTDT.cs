using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
  public partial class FormDanhSachCTDT : Form
  {
    string key = "";
    string MaCN;
    public FormDanhSachCTDT(string MaCN)
    {
      this.MaCN = MaCN;
      InitializeComponent();
    }

    private void LoadDSCTDT()
    {
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@MaCN",
        value = MaCN
      });

      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });

      dgvDSCTDT.DataSource = new Database().SelectData("SelectAllChuongTrinhDT", list);
    }


    private void FormDanhSachCTDT_Load(object sender, EventArgs e)
    {
      LoadDSCTDT();

      DataGridViewRow row = this.dgvDSCTDT.Rows[0];
      txtMa.Text = row.Cells[0].Value.ToString();
      txtTen.Text = row.Cells[1].Value.ToString();
      mtbNgayBD.Text = row.Cells[2].Value.ToString();

      dgvDSCTDT.Columns["MaCTDT"].Visible = false;
      dgvDSCTDT.Columns["TenCTDT"].Visible = false;
      dgvDSCTDT.Columns["TGBD"].Visible = false;
      dgvDSCTDT.Columns["MaMH"].HeaderText = "Mã môn học";
      dgvDSCTDT.Columns["TenMH"].HeaderText = "Tên môn học";
      dgvDSCTDT.Columns["SoTC"].HeaderText = "Số tín chỉ";
    }



    private void btnLuu_Click(object sender, EventArgs e)
    {
      DateTime tgbd;
      try
      {
        tgbd = DateTime.ParseExact(mtbNgayBD.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
      }
      catch (Exception)
      {
        MessageBox.Show("Ngày sinh không hợp lệ");
        mtbNgayBD.Select();
        return;
      }

      string sql = "updateThongTinCTDT";

      List<CustomParameter> list = new List<CustomParameter>();
      
      list.Add(new CustomParameter()
      {
        name = "@MaCTDT",
        value = txtMa.Text
    });

      list.Add(new CustomParameter()
      {
        name = "@TenCTDT",
        value = txtTen.Text
      });

      list.Add(new CustomParameter()
      {
        name = "@TGBD",
        value = tgbd.ToString("yyyy-MM-dd")
      });


      var rs = new Database().ExeCute(sql, list);
      if (rs == 1) //Thực thi thành công
      {
        MessageBox.Show("Cập nhật thông tin thành công");
        LoadDSCTDT();
      }
      else
      {
        MessageBox.Show("Thực thi thất bại");
      }

    }


    private void btnThem_Click(object sender, EventArgs e)
    {
      var MaCTDT = txtMa.Text;
      new FormMonCTDT(MaCTDT).ShowDialog();
      LoadDSCTDT();
      
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      key = "";
      LoadDSCTDT();
    }

    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSCTDT();
    }


  }
}
