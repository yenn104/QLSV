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
  public partial class FormMonCTDT : Form
  {
    string key="";
    int y,x;
    string MaCTDT, a;
    public FormMonCTDT(string MaCTDT)
    {
      this.MaCTDT = MaCTDT;
      InitializeComponent();
    }


    private void LoadMonCTDT()
    {
      List<CustomParameter> list = new List<CustomParameter>();

      list.Add(new CustomParameter()
      {
        name = "@MaCTDT",
        value = MaCTDT
      });

      list.Add(new CustomParameter()
      {
        name = "@tukhoa",
        value = key
      });

      dgvDS.DataSource = new Database().SelectData("SelectMonHocCTDT", list);
      dgvDS.ReadOnly = false;
      dgvDS.Enabled = true;
     
    }



    private void FormMonCTDT_Load(object sender, EventArgs e)
    {
      LoadMonCTDT();
      dgvDS.Columns["MaMH"].HeaderText = "Mã môn học";
      dgvDS.Columns["TenMH"].HeaderText = "Tên môn học";
      dgvDS.Columns["SoTC"].HeaderText = "Số tín chỉ";
      dgvDS.Columns["Checked"].Visible = false;


      DataGridViewCheckBoxColumn CheckBox = new DataGridViewCheckBoxColumn();
      CheckBox.HeaderText = "Chọn";
      CheckBox.Name = "Check";
      dgvDS.Columns.Add(CheckBox);

      x = int.Parse(dgvDS.Rows.Count.ToString());
      //DataGridViewRow row = this.dgvDS.Rows[3];
      for (int i = 0; i < x; i++)
      {
        DataGridViewRow row = this.dgvDS.Rows[i];
        a = row.Cells[3].Value.ToString();
        if (a == "True")
        {
         // CheckBox.Selected = true;
          row.Cells[4].Value = true;
        }
        else
        {
          row.Cells[4].Value = false;
        }
      }
    }


    private void btnHuy_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    private void txtKey_TextChanged(object sender, EventArgs e)
    {
      key = txtKey.Text;
      LoadMonCTDT();
    }


    private void btnLuu_Click(object sender, EventArgs e)
    {
      string sql = "";
      List<CustomParameter> list1 = new List<CustomParameter>();
      sql = "DeleteAllMonHocCTDT";

      list1.Add(new CustomParameter()
      {
        name = "@MaCTDT",
        value = MaCTDT
      });

      new Database().ExeCute(sql, list1);
      sql = "";
      x = int.Parse(dgvDS.Rows.Count.ToString());
      for (int i = 0; i < x; i++)
      {
        DataGridViewRow row = this.dgvDS.Rows[i];

        string MaMH = row.Cells[0].Value.ToString();
        //string TenMH = row.Cells[1].Value.ToString();
        string SoTC = row.Cells[2].Value.ToString();
        string Checked = row.Cells[4].Value.ToString();
 

        if (Checked == "True")
        {
        sql = "insertMonHocCTDT";

        List<CustomParameter> list = new List<CustomParameter>();

        list.Add(new CustomParameter()
        {
          name = "@MaCTDT",
          value = MaCTDT
        }); 

          list.Add(new CustomParameter()
        {
          name = "@MaMH",
          value = MaMH
        });

          list.Add(new CustomParameter()
          {
            name = "@SoTC",
            value = SoTC
          });


          new Database().ExeCute(sql, list);        
        }
      }
      MessageBox.Show("Cập nhật thông tin thành công");
      this.Dispose();

    }
  }
}
