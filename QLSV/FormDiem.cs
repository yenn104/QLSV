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
  public partial class FormDiem : Form
  {
    string UserName, TenMH, a;
    int x, m, y;
    string key = "";
    string MaMH = "";
    public FormDiem(string UserName, string TenMH)
    {
      this.UserName = UserName;
      this.TenMH = TenMH;
      InitializeComponent();
    }

    private void LoadDSLichDay()
    {
      DataTable dataTable = new DataTable();
      List<CustomParameter> list = new List<CustomParameter>();   
      list.Add(new CustomParameter()
      {
        name = "@MaGV",
        value = UserName
      });

      list.Add(new CustomParameter()
      {
        name = "@TenMH",
        value = TenMH
      });

      dataTable = new Database().SelectData("SelectLopDayMon", list);
      x = int.Parse(dataTable.Rows.Count.ToString());
      for (int i = 0; i < x; i++)
      {
        a = dataTable.Rows[i].ItemArray[0].ToString();
        cbbLop.Items.Add(a);

        m = int.Parse(dataTable.Rows[i].ItemArray[2].ToString());
        y = int.Parse(dataTable.Rows[i].ItemArray[3].ToString());
        if (m >= 8)
        {
          int y1 = y + 1;
          txtNienKhoa.Text = y + "-" + y1;
        }
        else
        {
          int y1 = y - 1;
          txtNienKhoa.Text = y1 + "-" + y;
        }
      } 
      cbbLop.Text = cbbLop.Items[0].ToString();
      txtTenMH.Text = TenMH;
      MaMH = dataTable.Rows[0].ItemArray[1].ToString();
    }


    private void LoadDSSV()
    {
      List<CustomParameter> list1 = new List<CustomParameter>();

      list1.Add(new CustomParameter()
      {
        name = "@MaLop",
        value = cbbLop.Text
      });

      list1.Add(new CustomParameter()
      {
        name = "@MaMH",
        value = MaMH
      });

      list1.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });

      dgvDS.DataSource = new Database().SelectData("SelectDiemSV", list1);
      dgvDS.ReadOnly = false;
      dgvDS.Enabled = true;
    }

    private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
    {
      LoadDSSV();
    }

    private void FormDiem_Load(object sender, EventArgs e)
    {
      LoadDSLichDay();
      LoadDSSV();
      dgvDS.Columns["MSSV"].HeaderText = "MSSV";
      dgvDS.Columns["Ho"].HeaderText = "Họ";
      dgvDS.Columns["Ten"].HeaderText = "Tên";
      dgvDS.Columns["Diem"].HeaderText = "Hệ số";
      dgvDS.Columns["Diem4"].HeaderText = "Hệ chữ";
    }

    private void btnLưu_Click(object sender, EventArgs e)
    {
      string sql = "";
     
      x = int.Parse(dgvDS.Rows.Count.ToString());
      for (int i = 0; i < x; i++)
      {
        DataGridViewRow row = this.dgvDS.Rows[i];

        string MSSV = row.Cells[0].Value.ToString();        
        string Diem = row.Cells[3].Value.ToString();

        
          sql = "UpdateDiemSV";

          List<CustomParameter> list = new List<CustomParameter>();

          list.Add(new CustomParameter()
          {
            name = "@MSSV",
            value = MSSV
          });

          list.Add(new CustomParameter()
          {
            name = "@MaMH",
            value = MaMH
          });

          list.Add(new CustomParameter()
          {
            name = "@Diem",
            value = Diem
          });


          new Database().ExeCute(sql, list);
        
      }
      MessageBox.Show("Cập nhật thông tin thành công");
      LoadDSSV();

    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      key = "";
      LoadDSSV();
    }


    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadDSSV();
    }



  }
}
