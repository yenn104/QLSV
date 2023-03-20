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
  public partial class FormMonHoc : Form
  {
    string MaMH;
    public FormMonHoc(string MaMH)
    {
      this.MaMH = MaMH;
      InitializeComponent();
    }

    
    private void FormMonHoc_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(MaMH))
      {
        this.Text = "Thêm mới môn học";
      }
      else
      {
        this.Text = "Cập nhật môn học";
        var r = new Database().Select("exec SelectMH '" + MaMH + "'");
        txtTenMH.Text = r["TenMH"].ToString();
        txtSoTC.Text = r["SoTC"].ToString();
      }
    }

    private void btnThemMH_Click(object sender, EventArgs e)
    {
      try
      {
        var sotc = int.Parse(txtSoTC.Text);
        if (sotc <= 0)
        {
          MessageBox.Show("Số tín chỉ phải lớn hơn 0");
        }
        if (string.IsNullOrEmpty(txtSoTC.Text))
        {
          MessageBox.Show("Số tín chỉ không được để trống");
        }
      }
      catch{
        MessageBox.Show("Số tín chỉ phải là kiểu số nguyên");
      }

      if (string.IsNullOrEmpty(txtTenMH.Text))
      {
        MessageBox.Show("Tên môn học không được để trống");
      }


      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      if (string.IsNullOrEmpty(MaMH))
      {
        sql = "insertMH";
      }
      else
      {
        list.Add(new CustomParameter()
        {
          name = "@MaMH",
          value = MaMH
        });

        sql = "UpdateMH";
      }


      list.Add(new CustomParameter()
      {
        name = "@TenMH",
        value = txtTenMH.Text
      });

      list.Add(new CustomParameter()
      {
        name = "@SoTC",
        value = txtSoTC.Text
      });


      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        if (string.IsNullOrEmpty(MaMH))
        {
          MessageBox.Show("Thêm mới môn học thành công");
        }
        else
        {
          MessageBox.Show("Cập nhật thông tin môn học thành công");
        }
        this.Dispose();
      }
      else
      {
        MessageBox.Show("Không thành công!");
      }
    }

    private void btnXoaMH_Click(object sender, EventArgs e)
    {
      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@MaMH",
        value = MaMH
      });

      sql = "DeleteMH";
      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {      
        MessageBox.Show("Xóa môn học thành công");
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
