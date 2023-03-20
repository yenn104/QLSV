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
    public partial class FormBaoCaoDSSV : Form
    {
        public FormBaoCaoDSSV()
        {
            InitializeComponent();
        }

        private void FormBaoCaoDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSVDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.dSSVDataSet.SinhVien);

            this.reportViewer1.RefreshReport();
        }
    }
}
