namespace GUI
{
    partial class HETHONG
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
            menuStrip1 = new MenuStrip();
            taikhoanTS = new ToolStripMenuItem();
            dangxuatTS = new ToolStripMenuItem();
            doipassTS = new ToolStripMenuItem();
            capnhatTS = new ToolStripMenuItem();
            updatetTaiKhoanTS = new ToolStripMenuItem();
            updateHocVienTS = new ToolStripMenuItem();
            updateBienLaiTS = new ToolStripMenuItem();
            updateLopHocTS = new ToolStripMenuItem();
            updateMonHocTS = new ToolStripMenuItem();
            updateKhoaHocTS = new ToolStripMenuItem();
            updateDiemTS = new ToolStripMenuItem();
            updateNhanVienTS = new ToolStripMenuItem();
            updateGiaoVienTS = new ToolStripMenuItem();
            phòngHọcToolStripMenuItem = new ToolStripMenuItem();
            timkiemTS = new ToolStripMenuItem();
            timHocVienTS = new ToolStripMenuItem();
            timLopHocTS = new ToolStripMenuItem();
            timMonHocTS = new ToolStripMenuItem();
            timGiaoVienTS = new ToolStripMenuItem();
            timNhanVienTS = new ToolStripMenuItem();
            tìmKiếmToolStripMenuItem = new ToolStripMenuItem();
            thongkeTS = new ToolStripMenuItem();
            thongkeHPTS = new ToolStripMenuItem();
            thongkeDSTS = new ToolStripMenuItem();
            ghidanhTS = new ToolStripMenuItem();
            xepLopTS = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { taikhoanTS, capnhatTS, timkiemTS, thongkeTS, ghidanhTS, xepLopTS });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1289, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // taikhoanTS
            // 
            taikhoanTS.DropDownItems.AddRange(new ToolStripItem[] { dangxuatTS, doipassTS });
            taikhoanTS.Name = "taikhoanTS";
            taikhoanTS.Size = new Size(87, 24);
            taikhoanTS.Text = "Tài Khoản";
            // 
            // dangxuatTS
            // 
            dangxuatTS.Name = "dangxuatTS";
            dangxuatTS.Size = new Size(183, 26);
            dangxuatTS.Text = "Đăng Xuất";
            dangxuatTS.Click += dangxuatTS_Click;
            // 
            // doipassTS
            // 
            doipassTS.Name = "doipassTS";
            doipassTS.Size = new Size(183, 26);
            doipassTS.Text = "Đổi Mật Khẩu";
            doipassTS.Click += doipassTS_Click;
            // 
            // capnhatTS
            // 
            capnhatTS.DropDownItems.AddRange(new ToolStripItem[] { updatetTaiKhoanTS, updateHocVienTS, updateBienLaiTS, updateLopHocTS, updateMonHocTS, updateKhoaHocTS, updateDiemTS, updateNhanVienTS, updateGiaoVienTS, phòngHọcToolStripMenuItem });
            capnhatTS.Name = "capnhatTS";
            capnhatTS.Size = new Size(85, 24);
            capnhatTS.Text = "Cập Nhật";
            // 
            // updatetTaiKhoanTS
            // 
            updatetTaiKhoanTS.Name = "updatetTaiKhoanTS";
            updatetTaiKhoanTS.Size = new Size(224, 26);
            updatetTaiKhoanTS.Text = "Tài Khoản";
            // 
            // updateHocVienTS
            // 
            updateHocVienTS.Name = "updateHocVienTS";
            updateHocVienTS.Size = new Size(224, 26);
            updateHocVienTS.Text = "Học Viên";
            updateHocVienTS.Click += updateHocVienTS_Click;
            // 
            // updateBienLaiTS
            // 
            updateBienLaiTS.Name = "updateBienLaiTS";
            updateBienLaiTS.Size = new Size(224, 26);
            updateBienLaiTS.Text = "Biên Lai";
            updateBienLaiTS.Click += updateBienLaiTS_Click;
            // 
            // updateLopHocTS
            // 
            updateLopHocTS.Name = "updateLopHocTS";
            updateLopHocTS.Size = new Size(224, 26);
            updateLopHocTS.Text = "Lớp Học";
            updateLopHocTS.Click += updateLopHocTS_Click;
            // 
            // updateMonHocTS
            // 
            updateMonHocTS.Name = "updateMonHocTS";
            updateMonHocTS.Size = new Size(224, 26);
            updateMonHocTS.Text = "Môn Học";
            updateMonHocTS.Click += updateMonHocTS_Click;
            // 
            // updateKhoaHocTS
            // 
            updateKhoaHocTS.Name = "updateKhoaHocTS";
            updateKhoaHocTS.Size = new Size(224, 26);
            updateKhoaHocTS.Text = "Khóa Học";
            updateKhoaHocTS.Click += updateKhoaHocTS_Click;
            // 
            // updateDiemTS
            // 
            updateDiemTS.Name = "updateDiemTS";
            updateDiemTS.Size = new Size(224, 26);
            updateDiemTS.Text = "Điểm Số";
            updateDiemTS.Click += updateDiemTS_Click;
            // 
            // updateNhanVienTS
            // 
            updateNhanVienTS.Name = "updateNhanVienTS";
            updateNhanVienTS.Size = new Size(224, 26);
            updateNhanVienTS.Text = "Nhân Viên";
            updateNhanVienTS.Click += updateNhanVienTS_Click;
            // 
            // updateGiaoVienTS
            // 
            updateGiaoVienTS.Name = "updateGiaoVienTS";
            updateGiaoVienTS.Size = new Size(224, 26);
            updateGiaoVienTS.Text = "Giáo Viên";
            updateGiaoVienTS.Click += updateGiaoVienTS_Click;
            // 
            // phòngHọcToolStripMenuItem
            // 
            phòngHọcToolStripMenuItem.Name = "phòngHọcToolStripMenuItem";
            phòngHọcToolStripMenuItem.Size = new Size(224, 26);
            phòngHọcToolStripMenuItem.Text = "Phòng Học";
            phòngHọcToolStripMenuItem.Click += phòngHọcToolStripMenuItem_Click;
            // 
            // timkiemTS
            // 
            timkiemTS.DropDownItems.AddRange(new ToolStripItem[] { timHocVienTS, timLopHocTS, timMonHocTS, timGiaoVienTS, timNhanVienTS, tìmKiếmToolStripMenuItem });
            timkiemTS.Name = "timkiemTS";
            timkiemTS.Size = new Size(86, 24);
            timkiemTS.Text = "Tìm Kiếm";
            // 
            // timHocVienTS
            // 
            timHocVienTS.Name = "timHocVienTS";
            timHocVienTS.Size = new Size(160, 26);
            timHocVienTS.Text = "Học Viên";
            // 
            // timLopHocTS
            // 
            timLopHocTS.Name = "timLopHocTS";
            timLopHocTS.Size = new Size(160, 26);
            timLopHocTS.Text = "Lớp Học";
            // 
            // timMonHocTS
            // 
            timMonHocTS.Name = "timMonHocTS";
            timMonHocTS.Size = new Size(160, 26);
            timMonHocTS.Text = "Môn Học";
            // 
            // timGiaoVienTS
            // 
            timGiaoVienTS.Name = "timGiaoVienTS";
            timGiaoVienTS.Size = new Size(160, 26);
            timGiaoVienTS.Text = "Giáo Viên";
            // 
            // timNhanVienTS
            // 
            timNhanVienTS.Name = "timNhanVienTS";
            timNhanVienTS.Size = new Size(160, 26);
            timNhanVienTS.Text = "Nhân Viên";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            tìmKiếmToolStripMenuItem.Size = new Size(160, 26);
            tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // thongkeTS
            // 
            thongkeTS.DropDownItems.AddRange(new ToolStripItem[] { thongkeHPTS, thongkeDSTS });
            thongkeTS.Name = "thongkeTS";
            thongkeTS.Size = new Size(86, 24);
            thongkeTS.Text = "Thống Kê";
            // 
            // thongkeHPTS
            // 
            thongkeHPTS.Name = "thongkeHPTS";
            thongkeHPTS.Size = new Size(149, 26);
            thongkeHPTS.Text = "Học Phí";
            thongkeHPTS.Click += thongkeHPTS_Click;
            // 
            // thongkeDSTS
            // 
            thongkeDSTS.Name = "thongkeDSTS";
            thongkeDSTS.Size = new Size(149, 26);
            thongkeDSTS.Text = "Điểm Số";
            thongkeDSTS.Click += thongkeDSTS_Click;
            // 
            // ghidanhTS
            // 
            ghidanhTS.Name = "ghidanhTS";
            ghidanhTS.Size = new Size(84, 24);
            ghidanhTS.Text = "Ghi Danh";
            ghidanhTS.Click += ghidanhTS_Click;
            // 
            // xepLopTS
            // 
            xepLopTS.Name = "xepLopTS";
            xepLopTS.Size = new Size(78, 24);
            xepLopTS.Text = "Xếp Lớp";
            xepLopTS.Click += xepLopTS_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(1289, 539);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // HETHONG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 569);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "HETHONG";
            Text = "HETHONG";
            Load += HETHONG_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem taikhoanTS;
        private ToolStripMenuItem dangxuatTS;
        private ToolStripMenuItem doipassTS;
        private ToolStripMenuItem capnhatTS;
        private ToolStripMenuItem updatetTaiKhoanTS;
        private ToolStripMenuItem updateHocVienTS;
        private ToolStripMenuItem updateBienLaiTS;
        private ToolStripMenuItem updateLopHocTS;
        private ToolStripMenuItem updateMonHocTS;
        private ToolStripMenuItem updateKhoaHocTS;
        private ToolStripMenuItem updateDiemTS;
        private ToolStripMenuItem updateGiaoVienTS;
        private ToolStripMenuItem updateNhanVienTS;
        private ToolStripMenuItem timkiemTS;
        private ToolStripMenuItem timHocVienTS;
        private ToolStripMenuItem timLopHocTS;
        private ToolStripMenuItem timMonHocTS;
        private ToolStripMenuItem timGiaoVienTS;
        private ToolStripMenuItem timNhanVienTS;
        private ToolStripMenuItem thongkeTS;
        private ToolStripMenuItem thongkeHPTS;
        private ToolStripMenuItem thongkeDSTS;
        private ToolStripMenuItem ghidanhTS;
        private ToolStripMenuItem phòngHọcToolStripMenuItem;
        private ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem xepLopTS;
    }
}