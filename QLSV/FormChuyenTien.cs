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
  public partial class FormChuyenTien : Form
  {
    string MSSV, ten, Money;
    public FormChuyenTien(string MSSV, String ten, String Money)
    {
      this.MSSV = MSSV;
      this.ten = ten;
      this.Money = Money;
      InitializeComponent();
    }


    private void FormChuyenTien_Load(object sender, EventArgs e)
    {
      txtNoiDung.Text = "Chuyển tiền học bổng cho sinh viên, MSSV: " + MSSV + " Ten: " + ten;
      txtSoTien.Text = Money;
      cbbNganHang.Text = cbbNganHang.Items[0].ToString();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      txtSTK.ResetText();
    }


    private void btnChuyen_Click(object sender, EventArgs e)
    {
      DialogResult y = MessageBox.Show("Tiến hành chuyển khoản", "Xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      if (y== DialogResult.OK)
      {
        List<CustomParameter> list = new List<CustomParameter>();
        list.Add(new CustomParameter()
        {
          name = "@MSSV",
          value = MSSV
        });
        var rs = new Database().ExeCute("UpdateChuyenTien", list);
        if (rs >= 1)
        {
          MessageBox.Show("Bạn đã chuyển khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        this.Dispose();
      }
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
      this.Dispose();
    }
  }
}
