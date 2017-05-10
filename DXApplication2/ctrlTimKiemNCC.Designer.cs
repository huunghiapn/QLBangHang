using DevExpress.Utils.Menu;

namespace DXApplication2
{
    partial class ctrlTimKiemNCC
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
            this.btnLoaiTimKiem = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(136, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(260, 20);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // btnLoaiTimKiem
            // 
            this.btnLoaiTimKiem.Location = new System.Drawing.Point(4, 29);
            this.btnLoaiTimKiem.Name = "btnLoaiTimKiem";
            this.btnLoaiTimKiem.Size = new System.Drawing.Size(115, 23);
            this.btnLoaiTimKiem.TabIndex = 1;
            this.btnLoaiTimKiem.Text = "Tìm theo..";
            // 
            // ctrlTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoaiTimKiem);
            this.Controls.Add(this.textEdit1);
            this.Name = "ctrlTimKiem";
            this.Size = new System.Drawing.Size(418, 77);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DropDownButton btnLoaiTimKiem;
    }
}
