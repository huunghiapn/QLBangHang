using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;

namespace DXApplication2
{
    public partial class SplashScreen1 : SplashScreen
    {
        private int timeLoad;

        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timeLoad += 1;
            if(timeLoad == 5)
            {
                using (quanlycuahangEntities dbContext = new quanlycuahangEntities())
                {
                    if (dbContext.Database.Exists() == false)
                    {
                        if (XtraMessageBox.Show("Không thể kết nối tới dữ liệu, xin hãy kiểm tra lại hoặc báo cho NghiaNguyenIT",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {

                            Application.Exit();
                        }
                    }
                }
                this.Close();
            }
        }
    }
}