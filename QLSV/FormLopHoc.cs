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
  public partial class FormLopHoc : Form
  {
    string MaLop;
    public FormLopHoc(string MaLop)
    {
      this.MaLop = MaLop;
      InitializeComponent();
    }

    private void FormLopHoc_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(MaLop))
      {
        this.Text = "Thêm mới lớp học";
      }
      else
      {
        txtMaLop.Visible = false;
        lblMaLop.Visible = false;
        this.Text = "Cập nhật lớp học";
        var r = new Database().Select("exec SelectLop '" + MaLop + "'");
        txtMaLop.Text = r["MaLop"].ToString();
        txtTenLop.Text = r["TenLop"].ToString();
        txtSiSo.Text = r["SiSo"].ToString();
      }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {      

      if (string.IsNullOrEmpty(txtTenLop.Text))
      {
        MessageBox.Show("Tên lớp không được để trống");
      }

      if (txtMaLop.Visible == true)
      {
        MaLop = txtMaLop.Text;
      }

      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      if (txtMaLop.Visible == true)
      {
        sql = "insertLop";
      }
      else
      {       
        sql = "UpdateLop";
      }

      list.Add(new CustomParameter()
        {
          name = "@MaLop",
          value = MaLop
        });

      list.Add(new CustomParameter()
      {
        name = "@TenLop",
        value = txtTenLop.Text
      });

      list.Add(new CustomParameter()
      {
        name = "@SiSo",
        value = txtSiSo.Text
      });

      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        if (txtMaLop.Visible == true)
        {
          MessageBox.Show("Thêm mới lớp học thành công");
        }
        else
        {
          MessageBox.Show("Cập nhật thông tin lớp học thành công");
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
        name = "@MaLop",
        value = MaLop
      });

      sql = "DeleteLop";
      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        MessageBox.Show("Xóa lớp học thành công");
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
