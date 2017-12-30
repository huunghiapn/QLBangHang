using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DXApplication2
{
    public partial class DonHangEditor : EditFormUserControl
    {
        public DonHangEditor()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmChonKH frmChonKH = new frmChonKH();
            frmChonKH.ShowDialog();
            String[] result = frmChonKH.getResult();
            this.MaKH.Text = result[0];
            this.TenKH.Text = result[1];
        }
    }
}
