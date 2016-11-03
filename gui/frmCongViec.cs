using BaiTapLonCSharp.bus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCSharp.gui
{
    public partial class frmCongViec : Form
    {
        CongViecInfo m_CongViecInfo = new CongViecInfo();
        public frmCongViec()
        {
            InitializeComponent();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= m_CongViecInfo.GetInfoCongViec();
        }
    }
}
