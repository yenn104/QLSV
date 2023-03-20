using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienMK.Checked)
            {
                txtpassht.PasswordChar = (char)0;
                txtpassnew.PasswordChar = (char)0;
                txtpassrenew.PasswordChar = (char)0;
            }
            else
            {
                txtpassht.PasswordChar = '*';
                txtpassnew.PasswordChar = '*';
                txtpassrenew.PasswordChar = '*';
            }
        }
        public bool KiemTra()
        {
            if (txtTenTK.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập tên tài khoản !!";
                txtTenTK.Focus();
                return false;
            }
            else if (txtpassht.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                txtpassht.Focus();
                return false;
            }
            else if (txtpassnew.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                txtpassnew.Focus();
                return false;
            }
            else if (txtpassrenew.Text == "")
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                txtpassrenew.Focus();
                return false;
            }
            else if (txtpassnew.Text != txtpassrenew.Text)
            {
                lblShowInfor.ForeColor = System.Drawing.Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                txtpassrenew.Focus();
                txtpassrenew.SelectAll();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["QLSV.Properties.Settings.QLSVConnectionString"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_Update_Pass";
                    cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtTenTK.Text;
                    cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txtpassht.Text;
                    cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtpassnew.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.GetInt32(0) == 1)
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Blue;
                        lblShowInfor.Text = dr.GetString(1);
                        txtpassrenew.Text = "";
                        txtpassht.Text = "";
                        txtpassnew.Text = "";
                        txtpassht.Focus();
                    }
                    else
                    {
                        lblShowInfor.ForeColor = System.Drawing.Color.Red;
                        lblShowInfor.Text = dr.GetString(1);
                        txtpassht.Focus();
                        txtpassht.SelectAll();
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

        private void checkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienMK.Checked)
            {
                txtpassht.PasswordChar = (char)0;
                txtpassnew.PasswordChar = (char)0;
                txtpassrenew.PasswordChar = (char)0;
            }
            else
            {
                txtpassht.PasswordChar = '*';
                txtpassnew.PasswordChar = '*';
                txtpassrenew.PasswordChar = '*';
            }
        
    }
    }

}
