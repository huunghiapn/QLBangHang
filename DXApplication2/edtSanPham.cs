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
using System.IO;

namespace DXApplication2
{
    public partial class edtSanPham : EditFormUserControl
    {
        public edtSanPham()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmChonNCC frmChonNCC = new frmChonNCC();
            frmChonNCC.ShowDialog();
            String[] result = frmChonNCC.getResult();
            this.MaNCC.Text = result[0];
            this.TenNCC.Text = result[1];
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    Image img = Image.FromFile(file);
                    byte[] data = DevExpress.XtraEditors.Controls.ByteImageConverter.ToByteArray(img, img.RawFormat);
                    pictureEdit1.EditValue = data;
                }
                catch (IOException)
                {
                    // TODO
                }
            }
        }
    }
}
