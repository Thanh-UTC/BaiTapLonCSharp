namespace BaiTapLonCSharp.gui
{
    partial class frmTongQuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongQuan));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHoaDonXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoaDonNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhaCungCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoTieuThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnThietLapGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnNguoiDung = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLiDoiTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLiKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.txtAppName = new DevExpress.XtraBars.BarStaticItem();
            this.txtTime = new DevExpress.XtraBars.BarStaticItem();
            this.tabGiaoDich = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabHoaDon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabDoiTac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabQuanLi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTimeSpanEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnHoaDonXuat,
            this.btnHoaDonNhap,
            this.btnKhachHang,
            this.btnNhaCungCap,
            this.btnBaoCaoDoanhThu,
            this.btnBaoCaoTieuThu,
            this.btnDanhMucHang,
            this.btnThietLapGia,
            this.btnPhanQuyen,
            this.btnNguoiDung,
            this.btnDoiMatKhau,
            this.btnQuanLiDoiTac,
            this.btnQuanLiKhachHang,
            this.txtAppName,
            this.txtTime});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tabGiaoDich,
            this.tabQuanLi});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeSpanEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(1334, 139);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnHoaDonXuat
            // 
            this.btnHoaDonXuat.Caption = "Hóa đơn xuất";
            this.btnHoaDonXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDonXuat.Glyph")));
            this.btnHoaDonXuat.Id = 7;
            this.btnHoaDonXuat.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDonXuat.LargeGlyph")));
            this.btnHoaDonXuat.Name = "btnHoaDonXuat";
            this.btnHoaDonXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDonXuat_ItemClick);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.Caption = "Hóa đơn nhập";
            this.btnHoaDonNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDonNhap.Glyph")));
            this.btnHoaDonNhap.Id = 8;
            this.btnHoaDonNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDonNhap.LargeGlyph")));
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 10;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.Caption = "Nhà cung cấp";
            this.btnNhaCungCap.Id = 11;
            this.btnNhaCungCap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCungCap.LargeGlyph")));
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            // 
            // btnBaoCaoDoanhThu
            // 
            this.btnBaoCaoDoanhThu.Caption = "Báo cáo doanh thu";
            this.btnBaoCaoDoanhThu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDoanhThu.Glyph")));
            this.btnBaoCaoDoanhThu.Id = 5;
            this.btnBaoCaoDoanhThu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDoanhThu.LargeGlyph")));
            this.btnBaoCaoDoanhThu.Name = "btnBaoCaoDoanhThu";
            // 
            // btnBaoCaoTieuThu
            // 
            this.btnBaoCaoTieuThu.Caption = "Báo cáo tiêu thụ";
            this.btnBaoCaoTieuThu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoTieuThu.Glyph")));
            this.btnBaoCaoTieuThu.Id = 6;
            this.btnBaoCaoTieuThu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoTieuThu.LargeGlyph")));
            this.btnBaoCaoTieuThu.Name = "btnBaoCaoTieuThu";
            // 
            // btnDanhMucHang
            // 
            this.btnDanhMucHang.Caption = "Danh mục hàng";
            this.btnDanhMucHang.Id = 8;
            this.btnDanhMucHang.ImageUri.Uri = "BringToFrontOfText";
            this.btnDanhMucHang.Name = "btnDanhMucHang";
            // 
            // btnThietLapGia
            // 
            this.btnThietLapGia.Caption = "Thiết lập giá";
            this.btnThietLapGia.Id = 9;
            this.btnThietLapGia.ImageUri.Uri = "CustomizeGrid";
            this.btnThietLapGia.Name = "btnThietLapGia";
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền";
            this.btnPhanQuyen.Id = 10;
            this.btnPhanQuyen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhanQuyen.LargeGlyph")));
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Caption = "Người dùng";
            this.btnNguoiDung.Id = 11;
            this.btnNguoiDung.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNguoiDung.LargeGlyph")));
            this.btnNguoiDung.Name = "btnNguoiDung";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 12;
            this.btnDoiMatKhau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.LargeGlyph")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnQuanLiDoiTac
            // 
            this.btnQuanLiDoiTac.Caption = "Quản lí nhà cung cấp";
            this.btnQuanLiDoiTac.Id = 1;
            this.btnQuanLiDoiTac.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLiDoiTac.LargeGlyph")));
            this.btnQuanLiDoiTac.Name = "btnQuanLiDoiTac";
            // 
            // btnQuanLiKhachHang
            // 
            this.btnQuanLiKhachHang.Caption = "Quản lí khách hàng";
            this.btnQuanLiKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLiKhachHang.Glyph")));
            this.btnQuanLiKhachHang.Id = 2;
            this.btnQuanLiKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnQuanLiKhachHang.LargeGlyph")));
            this.btnQuanLiKhachHang.Name = "btnQuanLiKhachHang";
            // 
            // txtAppName
            // 
            this.txtAppName.Caption = "Đồ gỗ Thanh Thái v1.0";
            this.txtAppName.Id = 3;
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtTime
            // 
            this.txtTime.Id = 6;
            this.txtTime.Name = "txtTime";
            this.txtTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // tabGiaoDich
            // 
            this.tabGiaoDich.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tabHoaDon,
            this.tabDoiTac,
            this.tabBaoCao});
            this.tabGiaoDich.Name = "tabGiaoDich";
            this.tabGiaoDich.Text = "Giao dịch";
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("tabHoaDon.Glyph")));
            this.tabHoaDon.ItemLinks.Add(this.btnHoaDonNhap);
            this.tabHoaDon.ItemLinks.Add(this.btnHoaDonXuat);
            this.tabHoaDon.Name = "tabHoaDon";
            // 
            // tabDoiTac
            // 
            this.tabDoiTac.ItemLinks.Add(this.btnKhachHang);
            this.tabDoiTac.ItemLinks.Add(this.btnNhaCungCap);
            this.tabDoiTac.Name = "tabDoiTac";
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.ItemLinks.Add(this.btnBaoCaoDoanhThu);
            this.tabBaoCao.ItemLinks.Add(this.btnBaoCaoTieuThu);
            this.tabBaoCao.Name = "tabBaoCao";
            // 
            // tabQuanLi
            // 
            this.tabQuanLi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.tabQuanLi.Name = "tabQuanLi";
            this.tabQuanLi.Text = "Quản lí";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhMucHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThietLapGia);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhanQuyen);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNguoiDung);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMatKhau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLiDoiTac);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQuanLiKhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemTimeSpanEdit1
            // 
            this.repositoryItemTimeSpanEdit1.AutoHeight = false;
            this.repositoryItemTimeSpanEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeSpanEdit1.Mask.EditMask = "dd.HH:mm:ss";
            this.repositoryItemTimeSpanEdit1.Name = "repositoryItemTimeSpanEdit1";
            this.repositoryItemTimeSpanEdit1.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.repositoryItemTimeSpanEdit1.TouchUIMinValue = new System.DateTime(((long)(0)));
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.txtAppName);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 936);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1334, 25);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // frmTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 961);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmTongQuan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỒ GỖ THANH THÁI v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeSpanEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabGiaoDich;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnHoaDonXuat;
        private DevExpress.XtraBars.BarButtonItem btnHoaDonNhap;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnNhaCungCap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup tabHoaDon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup tabDoiTac;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup tabBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabQuanLi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoDoanhThu;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoTieuThu;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucHang;
        private DevExpress.XtraBars.BarButtonItem btnThietLapGia;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnQuanLiDoiTac;
        private DevExpress.XtraBars.BarButtonItem btnQuanLiKhachHang;
        private DevExpress.XtraBars.BarStaticItem txtAppName;
        private DevExpress.XtraBars.BarStaticItem txtTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeSpanEdit repositoryItemTimeSpanEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}