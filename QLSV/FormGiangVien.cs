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
  public partial class FormGiangVien : Form
  {
    string MaGV;
    public FormGiangVien(string MaGV)
    {
      this.MaGV = MaGV;
      InitializeComponent();
    }

    private void FormGiangVien_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(MaGV))
      {
        this.Text = "Thêm mới giáo viên";
      }
      else
      {
        this.Text = "Cập nhật giáo viên";
        var r = new Database().Select("SelectGV '" + MaGV + "'");
        cbbHocVi.Text = r["MaHV"].ToString();
        txtHo.Text = r["Ho"].ToString();
        txtTen.Text = r["Ten"].ToString();
        mtbNgaySinh.Text = r["NgaySinh"].ToString();

        if (r["GioiTinh"].ToString() == "True")
        {
          rbtNam.Checked = true;
        }
        else
        {
          rbtNu.Checked = true;
        }
        txtDiaChi.Text = r["DiaChi"].ToString();
        txtSDT.Text = r["SDT"].ToString();
        txtMail.Text = r["Mail"].ToString();
      }
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
      string sql = "";
      string ho = txtHo.Text;
      string ten = txtTen.Text;
      DateTime ngaysinh;
      try
      {
        ngaysinh = DateTime.ParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
      }
      catch (Exception)
      {
        MessageBox.Show("Ngày sinh không hợp lệ");
        mtbNgaySinh.Select();
        return;
      }

      string gioitinh = rbtNam.Checked ? "1" : "0";
      string diachi = txtDiaChi.Text;
      string sdt = txtSDT.Text;
      string mail = txtMail.Text;
      string hocvi = cbbHocVi.Text;

      List<CustomParameter> list = new List<CustomParameter>();
      if (string.IsNullOrEmpty(MaGV))
      {
        sql = "insertGV";
      }
      else
      {
        sql = "updateGV";
          
      list.Add(new CustomParameter()
      {
        name = "@MaGV",
        value = MaGV
      });
      }

      list.Add(new CustomParameter()
      {
        name = "@MaHV",
        value = hocvi
      }); ;  

      list.Add(new CustomParameter()
      {
        name = "@Ho",
        value = ho
      });

      list.Add(new CustomParameter()
      {
        name = "@Ten",
        value = ten
      });

      list.Add(new CustomParameter()
      {
        name = "@NgaySinh",
        value = ngaysinh.ToString("yyyy-MM-dd")
      });

      list.Add(new CustomParameter()
      {
        name = "@GioiTinh",
        value = gioitinh
      });

      list.Add(new CustomParameter()
      {
        name = "@DiaChi",
        value = diachi
      });

      list.Add(new CustomParameter()
      {
        name = "@SDT",
        value = sdt
      });

      list.Add(new CustomParameter()
      {
        name = "@Mail",
        value = mail
      });

      var rs = new Database().ExeCute(sql, list);
      if (rs >= 1) //Thực thi thành công
      {
        if (string.IsNullOrEmpty(MaGV))//nếu thêm mới
        {
          MessageBox.Show("Thêm mới giảng viên thành công");
        }
        else//nếu cập nhật
        {
          MessageBox.Show("Cập nhật thông tin giảng viên thành công");
        }
        this.Dispose();//đóng form
      }
      else
      {
        MessageBox.Show("Thực thi thất bại");
      }
    }

    private void btnHuy_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnXoa_Click(object sender, EventArgs e)
    {
      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@MaGV",
        value = MaGV
      });

      sql = "DeleteGV";
      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        MessageBox.Show("Xóa giảng viên thành công");
        this.Dispose();
      }
      else
      {
        MessageBox.Show("Không thành công!");
      }
    }
  }
}
