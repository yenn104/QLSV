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
    public partial class FormBaoCaoTKB : Form
    {
        public FormBaoCaoTKB()
        {
            InitializeComponent();
        }

        private void FormBaoCaoTKB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTKBDataSet.DS_TKB' table. You can move, or remove it, as needed.
            this.dS_TKBTableAdapter.Fill(this.qLTKBDataSet.DS_TKB);

            this.reportViewer1.RefreshReport();
        }
    }
}
