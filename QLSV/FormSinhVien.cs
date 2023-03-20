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
  public partial class FormSinhVien : Form
  {
    string MSSV, a;
    int x;
    public FormSinhVien(string MSSV)
    {
      this.MSSV = MSSV;
      InitializeComponent();
    }


    private void LoadDSLop()
    {
      DataTable dataTable = new DataTable();
      List<CustomParameter> list = new List<CustomParameter>();
      //SelectDS

      dataTable = new Database().SelectDS("Select MaLop FROM LopHoc");
      x = int.Parse(dataTable.Rows.Count.ToString());
      for (int i = 0; i < x; i++)
      {
        a = dataTable.Rows[i].ItemArray[0].ToString();
        cbbLop.Items.Add(a);
      }
      cbbLop.Text = cbbLop.Items[0].ToString();
    }


    private void FormSinhVien_Load(object sender, EventArgs e)
    {
      LoadDSLop();
      if (string.IsNullOrEmpty(MSSV))
      {
        this.Text = "Thêm mới sinh viên";
        
      }
      else
      {
        txtMSSV.Visible = false;
        lblMSSV.Visible = false;
        this.Text = "Cập nhật thông tin sinh viên";
        var r = new Database().Select("SelectSV '" + MSSV + "'");
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
        txtQue.Text = r["QueQuan"].ToString();
        txtSDT.Text = r["SDT"].ToString();
        txtMail.Text = r["Mail"].ToString();
        cbbLop.Text = r["MaLop"].ToString();
      }
    }


    private void btnLuu_Click(object sender, EventArgs e)
    {
      string sql = "";
      if (txtMSSV.Visible == true)
      {
          MSSV = txtMSSV.Text;
      }      
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
      string quequan = txtQue.Text;
      string sdt = txtSDT.Text;
      string mail = txtMail.Text;
      string malop = cbbLop.Text;

      List<CustomParameter> list = new List<CustomParameter>();
      if (txtMSSV.Visible == true)
      {
        sql = "insertSV";
      }
      else
      {
        sql = "updateSV";
      }

      list.Add(new CustomParameter()
      {
        name = "@MSSV",
        value = MSSV
      });

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
        name = "@QueQuan",
        value = quequan
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

      list.Add(new CustomParameter()
      {
        name = "@MaLop",
        value = malop
      });


      var rs = new Database().ExeCute(sql, list);
      if (rs >= 1) //Thực thi thành công
      {
        if (txtMSSV.Visible == true)//nếu thêm mới
        {
          MessageBox.Show("Thêm mới sinh viên thành công");
        }
        else//nếu cập nhật
        {
          MessageBox.Show("Cập nhật thông tin sinh viên thành công");
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

    private void btnXoaSV_Click(object sender, EventArgs e)
    {
      string sql = "";
      List<CustomParameter> list = new List<CustomParameter>();
      list.Add(new CustomParameter()
      {
        name = "@MSSV",
        value = MSSV
      });

      sql = "DeleteSV";
      var rs = new Database().ExeCute(sql, list);

      if (rs == 1)
      {
        MessageBox.Show("Xóa sinh viên thành công");
        this.Dispose();

      }
      else
      {
        MessageBox.Show("Không thành công!");
      }
    }

  }
}
