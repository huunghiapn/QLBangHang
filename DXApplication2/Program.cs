using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Threading;

namespace DXApplication2
{
    static class Program
    {
        public static frmMain frmMain;
        public static frmKhachHang frmKH;
        public static frmDonHang frmDH;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmMain = new frmMain();
            Application.Run(frmMain);
        }
    }
}
