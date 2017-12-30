using DevExpress.XtraGrid.Views.Grid;
using DXApplication2.Model;

namespace DXApplication2
{
    partial class frmDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHang));
            this.donhangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.donhangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // donhangsBindingSource
            // 
            this.donhangsBindingSource.DataSource = typeof(DXApplication2.Model.DonHangView);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(648, 330);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 33);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(739, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa2
            // 
            this.btnXoa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa2.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa2.Image")));
            this.btnXoa2.Location = new System.Drawing.Point(830, 330);
            this.btnXoa2.Name = "btnXoa2";
            this.btnXoa2.Size = new System.Drawing.Size(85, 33);
            this.btnXoa2.TabIndex = 5;
            this.btnXoa2.Text = "Xóa";
            this.btnXoa2.Click += new System.EventHandler(this.btnXoa2_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(557, 330);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 33);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.donhangsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(927, 324);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDH,
            this.colMaKH,
            this.colTenKH,
            this.colSDT,
            this.colMaNV,
            this.colNgayLD,
            this.colTongTien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.EditFormPrepared += new DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventHandler(this.gridView1_EditFormPrepared);
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.OptionsEditForm.CustomEditFormLayout = new DonHangEditor();
            // 
            // colMaDH
            // 
            this.colMaDH.Caption = "Mã đơn hàng";
            this.colMaDH.FieldName = "DH.MaDH";
            this.colMaDH.Name = "colMaDH";
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Mã khách hàng";
            this.colMaKH.FieldName = "DH.MaKH";
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.Caption = "Tên khách hàng";
            this.colTenKH.FieldName = "KH.TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.OptionsColumn.AllowEdit = false;
            this.colTenKH.OptionsColumn.ReadOnly = true;
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 0;
            this.colTenKH.Width = 229;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số điện thoại KH";
            this.colSDT.FieldName = "KH.SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 1;
            this.colSDT.Width = 233;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "DH.MaNV";
            this.colMaNV.Name = "colMaNV";
            // 
            // colNgayLD
            // 
            this.colNgayLD.Caption = "Ngày lập đơn";
            this.colNgayLD.FieldName = "DH.NgayLap";
            this.colNgayLD.Name = "colNgayLD";
            this.colNgayLD.Visible = true;
            this.colNgayLD.VisibleIndex = 2;
            this.colNgayLD.Width = 218;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng tiền";
            this.colTongTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTongTien.FieldName = "DH.TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 3;
            this.colTongTien.Width = 229;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(466, 330);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 33);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Refresh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(12, 330);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(85, 33);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Chi tiết";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 366);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Name = "frmDonHang";
            this.Text = "Quản lý thông tin đơn hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.donhangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource donhangsBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa2;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLD;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}