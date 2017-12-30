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
using DevExpress.Utils.Menu;

namespace DXApplication2
{
    public partial class ctrlTimKiemDH : DevExpress.XtraEditors.XtraUserControl
    {
        private String searchItem;
        private String searchContent;
        public ctrlTimKiemDH()
        {
            InitializeComponent();
            DXPopupMenu menu = new DXPopupMenu();
            menu.Items.Add(new DXMenuItem("Số điện thoại KH"));
            menu.Items.Add(new DXMenuItem("Ngày lập đơn"));
            menu.Items.Add(new DXMenuItem("Địa chỉ KH"));
            this.btnLoaiTimKiem.DropDownControl = menu;
            // subscribe item.Click event
            foreach (DXMenuItem item in menu.Items)
            {
                item.Click += item_Click;
            }
            btnLoaiTimKiem.Text = menu.Items[0].Caption;
            searchItem = "KH.SDT";
        }

        void item_Click(object sender, EventArgs e)
        {
            // synchronize selection
            btnLoaiTimKiem.Text = ((DXMenuItem)sender).Caption;
            switch(((DXMenuItem)sender).Caption)
            {
                case "Số điện thoại KH":
                    searchItem = "KH.SDT";
                    break;
                case "Ngày lập đơn":
                    searchItem = "DH.NgayLD";
                    break;
                case "Địa chỉ KH":
                    searchItem = "KH.DiaChi";
                    break;
            }
        }

        public String[] getResult()
        {
            return new List<string> { searchItem, searchContent }.ToArray(); ;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            searchContent = this.textEdit1.Text;
        }
    }
}
