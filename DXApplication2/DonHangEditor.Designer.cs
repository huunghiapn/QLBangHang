namespace DXApplication2
{
    partial class DonHangEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonHangEditor));
            this.MaKH = new DevExpress.XtraEditors.TextEdit();
            this.NgayLD = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TongTien = new DevExpress.XtraEditors.TextEdit();
            this.TenKH = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayLD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayLD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MaKH
            // 
            this.SetBoundFieldName(this.MaKH, "DH.MaKH");
            this.SetBoundPropertyName(this.MaKH, "EditValue");
            this.MaKH.Location = new System.Drawing.Point(104, 16);
            this.MaKH.Name = "MaKH";
            this.MaKH.Size = new System.Drawing.Size(84, 20);
            this.MaKH.TabIndex = 0;
            // 
            // NgayLD
            // 
            this.SetBoundFieldName(this.NgayLD, "DH.NgayLap");
            this.SetBoundPropertyName(this.NgayLD, "EditValue");
            this.NgayLD.EditValue = null;
            this.NgayLD.Location = new System.Drawing.Point(528, 16);
            this.NgayLD.Name = "NgayLD";
            this.NgayLD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayLD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NgayLD.Size = new System.Drawing.Size(100, 20);
            this.NgayLD.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.SetBoundPropertyName(this.labelControl2, "");
            this.labelControl2.Location = new System.Drawing.Point(26, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mã khách hàng";
            // 
            // labelControl3
            // 
            this.SetBoundPropertyName(this.labelControl3, "");
            this.labelControl3.Location = new System.Drawing.Point(450, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Ngày lập đơn";
            // 
            // labelControl4
            // 
            this.SetBoundPropertyName(this.labelControl4, "");
            this.labelControl4.Location = new System.Drawing.Point(450, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Tổng tiền";
            // 
            // TongTien
            // 
            this.SetBoundFieldName(this.TongTien, "DH.TongTien");
            this.SetBoundPropertyName(this.TongTien, "EditValue");
            this.TongTien.Location = new System.Drawing.Point(528, 84);
            this.TongTien.Name = "TongTien";
            this.TongTien.Size = new System.Drawing.Size(100, 20);
            this.TongTien.TabIndex = 4;
            // 
            // TenKH
            // 
            this.SetBoundFieldName(this.TenKH, "KH.TenKH");
            this.SetBoundPropertyName(this.TenKH, "EditValue");
            this.TenKH.Enabled = false;
            this.TenKH.Location = new System.Drawing.Point(232, 17);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(177, 20);
            this.TenKH.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.SetBoundPropertyName(this.simpleButton2, "");
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(194, 14);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(32, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Chọn";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // DonHangEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.NgayLD);
            this.Controls.Add(this.MaKH);
            this.Name = "DonHangEditor";
            this.Size = new System.Drawing.Size(665, 220);
            ((System.ComponentModel.ISupportInitialize)(this.MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayLD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NgayLD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenKH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit MaKH;
        private DevExpress.XtraEditors.DateEdit NgayLD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TongTien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TenKH;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
