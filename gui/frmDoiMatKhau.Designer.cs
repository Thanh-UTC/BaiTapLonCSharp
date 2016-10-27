namespace BaiTapLonCSharp.gui
{
    partial class frmDoiMatKhau
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblDoiMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.lblTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblOldPass = new DevExpress.XtraEditors.LabelControl();
            this.lblNewPass = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.btnPassChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblDoiMatKhau);
            this.panelControl1.Location = new System.Drawing.Point(1, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(514, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnHuy);
            this.panelControl2.Controls.Add(this.btnPassChange);
            this.panelControl2.Controls.Add(this.textEdit3);
            this.panelControl2.Controls.Add(this.textEdit2);
            this.panelControl2.Controls.Add(this.textEdit1);
            this.panelControl2.Controls.Add(this.lblTenDangNhap);
            this.panelControl2.Controls.Add(this.lblOldPass);
            this.panelControl2.Controls.Add(this.lblNewPass);
            this.panelControl2.Location = new System.Drawing.Point(1, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(514, 228);
            this.panelControl2.TabIndex = 1;
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.Appearance.ForeColor = System.Drawing.Color.Peru;
            this.lblDoiMatKhau.Appearance.Options.UseFont = true;
            this.lblDoiMatKhau.Appearance.Options.UseForeColor = true;
            this.lblDoiMatKhau.Location = new System.Drawing.Point(167, 10);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(160, 29);
            this.lblDoiMatKhau.TabIndex = 0;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTenDangNhap.Appearance.Options.UseFont = true;
            this.lblTenDangNhap.Appearance.Options.UseForeColor = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(43, 32);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(107, 18);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblOldPass
            // 
            this.lblOldPass.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            this.lblOldPass.Appearance.Options.UseFont = true;
            this.lblOldPass.Appearance.Options.UseForeColor = true;
            this.lblOldPass.Location = new System.Drawing.Point(43, 67);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(89, 18);
            this.lblOldPass.TabIndex = 2;
            this.lblOldPass.Text = "Mật khẩu cũ";
            // 
            // lblNewPass
            // 
            this.lblNewPass.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            this.lblNewPass.Appearance.Options.UseFont = true;
            this.lblNewPass.Appearance.Options.UseForeColor = true;
            this.lblNewPass.Location = new System.Drawing.Point(43, 102);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(99, 18);
            this.lblNewPass.TabIndex = 3;
            this.lblNewPass.Text = "Mật khẩu mới";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(204, 30);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(225, 20);
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(204, 100);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(225, 20);
            this.textEdit2.TabIndex = 5;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(204, 65);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(225, 20);
            this.textEdit3.TabIndex = 6;
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(62, 150);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(169, 36);
            this.btnPassChange.TabIndex = 7;
            this.btnPassChange.Text = "Đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(267, 151);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(185, 34);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 296);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblDoiMatKhau;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnPassChange;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblTenDangNhap;
        private DevExpress.XtraEditors.LabelControl lblOldPass;
        private DevExpress.XtraEditors.LabelControl lblNewPass;
    }
}