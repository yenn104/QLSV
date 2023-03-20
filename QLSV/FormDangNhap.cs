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
  public partial class FormDangNhap : Form
  {
    public FormDangNhap()
    {
      InitializeComponent();
    }


    public string username;
    public string admin;

    private void btnDangNhap_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassWord.Text))
      {
        MessageBox.Show("Thông tin trống!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //txtUserName.Select();
        //return;
      }


      else {
        List<CustomParameter> list = new List<CustomParameter>()
            {
                 new CustomParameter()
                {
                    name = "@taikhoan",
                    value=txtUserName.Text
                },
                  new CustomParameter()
                {
                    name = "@matkhau",
                    value=txtPassWord.Text
                }
            };

        var rs = new Database().SelectData("Login", list);
        username = txtUserName.Text;
        //admin = rs.Rows[0].ToString();

        DataRow dr = rs.Rows[0];
        /*string a*/ admin = dr["Admin"].ToString();
        //if (a == "True")
        //{
        //  admin = 1;
        //}
        //else admin = 0;

        if (rs.Rows.Count > 0)
        {        
          //this.Hide();
          this.Close();
        }
        else 
        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btnThoat_Click(object sender, EventArgs e)
    {
      DialogResult y = MessageBox.Show("Bạn muốn thoát hệ thống?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (y == DialogResult.Yes)
      {
        this.Close();
      }
    }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
