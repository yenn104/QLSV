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
  public partial class FormChuyenNganh : Form
  {
    string MaCN;
    public FormChuyenNganh(string MaCN)
    {
      this.MaCN = MaCN;
      InitializeComponent();
    }

    private void FormChuyenNganh_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(MaCN))
      {
        this.Text = "Thêm mới chuyên ngành";
      }
      else
      {
        txtMa.Visible = false;
        lblMaLop.Visible = false;
        this.Text = "Cập nhật chuyên ngành";
        var r = new Database().Select("exec SelectCN '" + MaCN + "'");
        txtMa.Text = r["MaCN"].ToString();
        txtTen.Text = r["TenCN"].ToString();
        txtSoTC.Text = r["SoTC"].ToString();
        cbbMaNganh.Text = r["MaNganh"].ToString();
      }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      if (txtMa.Visible == true)
      {
        sql = "insertCN";
      }
      else
      {
        sql = "UpdateCN";
      }

      list.Add(new CustomParameter()
      {
        name = "@MaCN",
        value = txtMa.Text
      });

      list.Add(new CustomParameter()
      {
        name = "@TenCN",
        value = txtTen.Text
      });

      list.Add(new CustomParameter()
      {
        name = "@SoTC",
        value = txtSoTC.Text
      });

      list.Add(new CustomParameter()
      {
        name = "@MaNganh",
        value = cbbMaNganh.Text
      });

      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        if (txtMa.Visible == true)
        {
          MessageBox.Show("Thêm chuyên ngành mới thành công");
        }
        else
        {
          MessageBox.Show("Cập nhật thông tin chuyên ngành thành công");
        }
        this.Dispose();
      }
      else
      {
        MessageBox.Show("Không thành công!");
      }
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@MaCN",
        value = MaCN
      });

      sql = "DeleteCN";
      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        MessageBox.Show("Xóa chuyên ngành thành công");
        this.Dispose();
      }
      else
      {
        MessageBox.Show("Không thành công!");
      }
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
