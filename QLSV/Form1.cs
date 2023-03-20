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
  public partial class Form1 : Form
  {
    string UserName, admin;
    int y, z;
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      FormDangNhap dn = new FormDangNhap();
      dn.ShowDialog();
      UserName = dn.username;
      admin = dn.admin;

      if (admin != null)
      {
        if (admin.Equals("True"))
        {
          //tsLichDay.Visible = false;
          mimGiangDay.Visible = false;
        }
        else
        {
          mimQuanLy.Visible = false;
          mimThongKe.Visible = false;
          mimKhenThuong.Visible = false;
          mimCTDT.Visible = false;           
          LoadDSLopDay();
          LoadDSMonDay();
        }
        Form2 welcome = new Form2();
        AddForm(welcome);
      }
      else
      {
        this.Close();
      }
    }



    private void LoadDSLopDay()
    {
      string a;
      DataTable dataTable = new DataTable();
      List<CustomParameter> list = new List<CustomParameter>();

      list.Add(new CustomParameter()
      {
        name = "@MaGV",
        value = UserName
      });
      dataTable = new Database().SelectData("SelectLopDay", list);
      
      y =  int.Parse(dataTable.Rows.Count.ToString());
      for(int i = 0; i < y; i++)
      {
        a = dataTable.Rows[i].ItemArray[0].ToString();
        tsQuanLyLop.DropDownItems.Add(a);
        tsQuanLyLop.DropDownItems[i].Click += new EventHandler(toolStripItem_Click);
      }
    }


    private void LoadDSMonDay()
    {
      string a;
      DataTable dataTable = new DataTable();
      List<CustomParameter> list = new List<CustomParameter>();

      list.Add(new CustomParameter()
      {
        name = "@MaGV",
        value = UserName
      });
      dataTable = new Database().SelectData("SelectMonDay", list);

      y = int.Parse(dataTable.Rows.Count.ToString());
      for (int i = 0; i < y; i++)
      {
        a = dataTable.Rows[i].ItemArray[0].ToString();
        tsNhapDiem.DropDownItems.Add(a);
        tsNhapDiem.DropDownItems[i].Name = "ts"+i;
        var name = tsNhapDiem.DropDownItems[i].Name.ToString();
        tsNhapDiem.DropDownItems[i].Click += new EventHandler(diem_Click);
      }
      
    }

  

    private void toolStripItem_Click(object sender, EventArgs e)
    {
      string ma = sender.ToString();
      FormDSSinhVienLop form = new FormDSSinhVienLop(ma);
      AddForm(form);
    }

    private void diem_Click(object sender, EventArgs e)
    {
      string ma = sender.ToString();
      FormDiem form = new FormDiem(UserName, ma);
      AddForm(form);
    }


    private void AddForm(Form form)
      {       
        this.pnlContent.Controls.Clear();
        form.TopLevel = false;
        form.AutoScroll = true;
        form.FormBorderStyle = FormBorderStyle.None;
        form.Dock = DockStyle.Fill;
        this.Text = form.Text;
        this.pnlContent.Controls.Add(form);
        form.Show();
      }

    private void tsThoat_Click(object sender, EventArgs e)
    {
      Form1 f = new Form1();
      this.Hide();
      f.ShowDialog();
      this.Close();
    }

    private void tsDoiMatKhau_Click(object sender, EventArgs e)
    {
            DoiMK form = new DoiMK();
            form.ShowDialog();
    }

    private void tsSinhVien_Click(object sender, EventArgs e)
    {
      FormDanhSachSV form = new FormDanhSachSV();
      AddForm(form);
    }

    private void tsMonHoc_Click(object sender, EventArgs e)
    {
      FormDanhSachMH form = new FormDanhSachMH();
      AddForm(form);
    }

    private void tsGiangVien_Click(object sender, EventArgs e)
    {
      FormDanhSachGV form = new FormDanhSachGV();
      AddForm(form);
    }

    private void tsLopHoc_Click(object sender, EventArgs e)
    {
      FormDanhSachLH form = new FormDanhSachLH();
      AddForm(form);
    }

    private void tsHocBong_Click(object sender, EventArgs e)
    {
      FormHocBong form = new FormHocBong();
      AddForm(form);
    }

        private void họcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoDSSV form = new FormBaoCaoDSSV();
            AddForm(form);
        }

        private void nợMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoDSGV form = new FormBaoCaoDSGV();
            AddForm(form);
        }

        private void danhSáchThờiKhóaBiểuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoTKB form = new FormBaoCaoTKB();
            AddForm(form);
        }

        private void danhSáchHọcBổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaoCaoHocBong form = new FormBaoCaoHocBong();
            AddForm(form);
        }

        private void danhSáchĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKeDiem form = new FormThongKeDiem();
            AddForm(form);
        }

        private void mimCTDT_Click(object sender, EventArgs e)
    {
      FormDanhSachCN form = new FormDanhSachCN();
      AddForm(form);
    }


    private void tsLichDay_Click(object sender, EventArgs e)
    {
      FormDSLichDay form = new FormDSLichDay(UserName);
      AddForm(form);
    }


  }
}
