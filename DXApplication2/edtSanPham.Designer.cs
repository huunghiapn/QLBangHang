namespace DXApplication2
{
    partial class edtSanPham
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.MaNCC = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TenNCC = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNCC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.SetBoundFieldName(this.textEdit1, "TenSP");
            this.SetBoundPropertyName(this.textEdit1, "EditValue");
            this.textEdit1.EditValue = "";
            this.textEdit1.Location = new System.Drawing.Point(72, 30);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // MaNCC
            // 
            this.SetBoundFieldName(this.MaNCC, "MaNCC");
            this.MaNCC.Location = new System.Drawing.Point(72, 66);
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Size = new System.Drawing.Size(100, 20);
            this.MaNCC.TabIndex = 1;
            // 
            // textEdit3
            // 
            this.SetBoundFieldName(this.textEdit3, "GiaBan");
            this.SetBoundPropertyName(this.textEdit3, "EditValue");
            this.textEdit3.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEdit3.Location = new System.Drawing.Point(266, 30);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.SetBoundPropertyName(this.labelControl1, "");
            this.labelControl1.Location = new System.Drawing.Point(3, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Nhà cung cấp";
            // 
            // labelControl2
            // 
            this.SetBoundPropertyName(this.labelControl2, "");
            this.labelControl2.Location = new System.Drawing.Point(3, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên sản phẩm";
            // 
            // labelControl3
            // 
            this.SetBoundPropertyName(this.labelControl3, "");
            this.labelControl3.Location = new System.Drawing.Point(224, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Giá bán";
            // 
            // labelControl4
            // 
            this.SetBoundPropertyName(this.labelControl4, "");
            this.labelControl4.Location = new System.Drawing.Point(224, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Giá gốc";
            // 
            // textEdit4
            // 
            this.SetBoundFieldName(this.textEdit4, "GiaGoc");
            this.SetBoundPropertyName(this.textEdit4, "EditValue");
            this.textEdit4.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEdit4.Location = new System.Drawing.Point(266, 65);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(100, 20);
            this.textEdit4.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetBoundFieldName(this.pictureEdit1, "AnhSP");
            this.SetBoundPropertyName(this.pictureEdit1, "EditValue");
            this.pictureEdit1.Location = new System.Drawing.Point(454, 15);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(247, 178);
            this.pictureEdit1.TabIndex = 8;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // labelControl5
            // 
            this.SetBoundPropertyName(this.labelControl5, "");
            this.labelControl5.Location = new System.Drawing.Point(376, 37);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Ảnh sản phẩm";
            // 
            // TenNCC
            // 
            this.SetBoundPropertyName(this.TenNCC, "");
            this.TenNCC.Location = new System.Drawing.Point(72, 66);
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Size = new System.Drawing.Size(100, 20);
            this.TenNCC.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.SetBoundPropertyName(this.simpleButton2, "");
            this.simpleButton2.Location = new System.Drawing.Point(178, 66);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(40, 19);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Chọn";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // edtSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.TenNCC);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.MaNCC);
            this.Controls.Add(this.textEdit1);
            this.Name = "edtSanPham";
            this.Size = new System.Drawing.Size(715, 205);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenNCC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit MaNCC;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TenNCC;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
