using Microsoft.Reporting.WinForms;
using QLSV.DataccessLayer;
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
    public partial class FormThongKeDiem : Form
    {
        public FormThongKeDiem()
        {
            InitializeComponent();
        }

        private void FormThongKeDiem_Load(object sender, EventArgs e)
        {
            HienThiThongkeDiemSinhVien();
            //this.rpvThongKeDiem.RefreshReport();
        }

        private void HienThiThongkeDiemSinhVien()
        {
            using (var _dbContext = new QLSinhVienDBContext())
            {
                string truyvansql = "select  sv.MSSV,Ho,Ten,TenLop,TenMH,Diem from SinhVien sv, Diem d, MonHoc mh,LopHoc l where sv.MSSV = d.MSSV and mh.MaMH = d.MaMH and sv.MaLop=l.MaLop";
                List<ThongKeDiem> danhSach =
                        _dbContext.Database.SqlQuery<ThongKeDiem>(truyvansql).ToList();

                if (textBox1.Text != "")
                {
                    danhSach = danhSach.Where(sv => sv.MSSV.ToLower() == textBox1.Text.ToLower()).ToList();
                    //Thêm report
                    this.rpvThongKeDiem.LocalReport.ReportPath = "ReportKetQuaSinhVien.rdlc";
                    var reportDataSource = new ReportDataSource("ThongKeDiemDataset", danhSach);// đúng với tên dataset trong thiết kế
                    this.rpvThongKeDiem.LocalReport.DataSources.Clear();//clear
                    this.rpvThongKeDiem.LocalReport.DataSources.Add(reportDataSource);
                    this.rpvThongKeDiem.RefreshReport();//chạy report
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HienThiThongkeDiemSinhVien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
