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
    public partial class ctrlTimKiemKH : DevExpress.XtraEditors.XtraUserControl
    {
        private String searchItem;
        private String searchContent;
        public ctrlTimKiemKH()
        {
            InitializeComponent();
            DXPopupMenu menu = new DXPopupMenu();
            menu.Items.Add(new DXMenuItem("Tên khách hàng"));
            menu.Items.Add(new DXMenuItem("Số điện thoại"));
            menu.Items.Add(new DXMenuItem("Địa chỉ"));
            menu.Items.Add(new DXMenuItem("Mã số thuế"));
            this.btnLoaiTimKiem.DropDownControl = menu;
            // subscribe item.Click event
            foreach (DXMenuItem item in menu.Items)
            {
                item.Click += item_Click;
            }
            btnLoaiTimKiem.Text = menu.Items[0].Caption;
            searchItem = "TenKH";
        }

        void item_Click(object sender, EventArgs e)
        {
            // synchronize selection
            btnLoaiTimKiem.Text = ((DXMenuItem)sender).Caption;
            switch(((DXMenuItem)sender).Caption)
            {
                case "Tên khách hàng":
                    searchItem = "TenKH";
                    break;
                case "Số điện thoại":
                    searchItem = "SDT";
                    break;
                case "Địa chỉ":
                    searchItem = "DiaChi";
                    break;
                case "Mã số thuế":
                    searchItem = "MST";
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
