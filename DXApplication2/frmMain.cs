using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication2
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKHClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            ViewChildForm(frmKH);
        }

        private void btnDHClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonHang frmDH = new frmDonHang();
            ViewChildForm(frmDH);
        }

        private void btnSPClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSanPham frmSP = new frmSanPham();
            ViewChildForm(frmSP);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SplashScreen1 splash = new SplashScreen1();
            splash.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaCungCap frmNCC = new frmNhaCungCap();
            ViewChildForm(frmNCC);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        //Create function to re-use
        public void ViewChildForm(Form _form)
        {
            //Check before open
            if (!IsFormActived(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }

        //Check if a form is opened already      
        private bool IsFormActived(Form form)
        {

            bool IsOpenend = false;
            //If there is more than one form opened
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Active this form
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }

                }
            }
            return IsOpenend;
        }

    }
}
