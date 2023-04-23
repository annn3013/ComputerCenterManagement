using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class HETHONG : Form
    {
        public HETHONG()
        {
            InitializeComponent();
        }
        private string tenquyen;
        private string tentaikkhoan;
        private string matkhau;
        public HETHONG(string tenquyen, string TenTaiKhoan, string matkhau)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.tenquyen = tenquyen;
            this.tentaikkhoan = TenTaiKhoan;
            this.matkhau = matkhau;
        }
        private void CheckQuyen(string tenquyen)
        {
            switch (tenquyen)
            {
                case "Admin":
                    foreach (ToolStripMenuItem item in menuStrip1.Items)
                    {
                        item.Visible = false;
                    }
                    taikhoanTS.Visible = true;
                    capnhatTS.Visible = true;
                    foreach (ToolStripMenuItem item in capnhatTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    updatetTaiKhoanTS.Visible = false;
                    capnhatTS.Visible = false;
                    xepLopTS.Visible = false;
                    QUANLYACC AdoiMatKhauForm = new QUANLYACC();
                    OPEN(AdoiMatKhauForm);

                    break;
                case "Nhân viên lễ tân":
                    foreach (ToolStripMenuItem item in capnhatTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    updateHocVienTS.Visible = true;
                    updateBienLaiTS.Visible = true;
                    foreach (ToolStripMenuItem item in timkiemTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    timHocVienTS.Visible = true;
                    timLopHocTS.Visible = true;
                    timMonHocTS.Visible = true;
                    thongkeTS.Visible = false;
                    xepLopTS.Visible = false;
                    QUANLYHOCVIEN qUANLYHOCVIEN = new QUANLYHOCVIEN();
                    OPEN(qUANLYHOCVIEN);

                    break;
                case "Quản lý kế hoạch":
                    updatetTaiKhoanTS.Visible = false;
                    updateHocVienTS.Visible = false;
                    updateBienLaiTS.Visible = false;
                    ghidanhTS.Visible = false;
                    thongkeHPTS.Visible = false;
                    timHocVienTS.Visible = false;
                    timGiaoVienTS.Visible = false;
                    timNhanVienTS.Visible = false;
                    updateNhanVienTS.Visible = false;
                    updateGiaoVienTS.Visible = false;
                    QUANLYLOPHOC qUANLYLOPHOC = new QUANLYLOPHOC();
                    OPEN(qUANLYLOPHOC);

                    break;
                case "Quản Lý Nhân Sự":
                    foreach (ToolStripMenuItem item in capnhatTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    updateNhanVienTS.Visible = true;
                    updateGiaoVienTS.Visible = true;
                    foreach (ToolStripMenuItem item in timkiemTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    timNhanVienTS.Visible = true;
                    timGiaoVienTS.Visible = true;
                    thongkeTS.Visible = false;
                    ghidanhTS.Visible = false;
                    xepLopTS.Visible = false;
                    QUANLYGIAOVIEN qUANLYGIAOVIEN = new QUANLYGIAOVIEN();
                    OPEN(qUANLYGIAOVIEN);
                    break;
                default:
                    foreach (ToolStripMenuItem item in capnhatTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    updateNhanVienTS.Visible = true;
                    updateGiaoVienTS.Visible = true;
                    foreach (ToolStripMenuItem item in timkiemTS.DropDownItems)
                    {
                        item.Visible = false;
                    }
                    timNhanVienTS.Visible = true;
                    timGiaoVienTS.Visible = true;
                    thongkeTS.Visible = false;
                    ghidanhTS.Visible = false;
                    xepLopTS.Visible = false;
                    QUANLYGIAOVIEN qUANLYGIAOVIEN2 = new QUANLYGIAOVIEN();
                    OPEN(qUANLYGIAOVIEN2);

                    break;
            }
        }
        private void HETHONG_Load(object sender, EventArgs e)
        {
            CheckQuyen(tenquyen);

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dangxuatTS_Click(object sender, EventArgs e)
        {
            this.Close();
            LOGIN login = new LOGIN();
            login.Show();
        }

        private void doipassTS_Click(object sender, EventArgs e)
        {

            DOIPASS AdoiMatKhauForm = new DOIPASS(this.tentaikkhoan, this.matkhau);

            OPEN(AdoiMatKhauForm);
        }
        public void OPEN(Form a)
        {
            a.TopLevel = false;
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            panel1.Controls.Add(a);
            panel1.Tag = a;
            a.BringToFront();
            a.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateLopHocTS_Click(object sender, EventArgs e)
        {
            QUANLYLOPHOC qUANLYLOPHOC = new QUANLYLOPHOC();
            OPEN(qUANLYLOPHOC);
        }

        private void updateMonHocTS_Click(object sender, EventArgs e)
        {
            QUANLYMONHOC qUANLYMONHOC = new QUANLYMONHOC();
            OPEN(qUANLYMONHOC);
        }

        private void updateKhoaHocTS_Click(object sender, EventArgs e)
        {
            QUANLYKHOAHOC qUANLYKHOAHOC = new QUANLYKHOAHOC();
            OPEN(qUANLYKHOAHOC);
        }

        private void updateHocVienTS_Click(object sender, EventArgs e)
        {
            QUANLYHOCVIEN qUANLYHOCVIEN = new QUANLYHOCVIEN();
            OPEN(qUANLYHOCVIEN);
        }

        private void updateGiaoVienTS_Click(object sender, EventArgs e)
        {
            QUANLYGIAOVIEN qUANLYGIAOVIEN = new QUANLYGIAOVIEN();
            OPEN(qUANLYGIAOVIEN);
        }

        private void updateDiemTS_Click(object sender, EventArgs e)
        {
            QUANLYDIEM qUANLYDIEM = new QUANLYDIEM();
            OPEN(qUANLYDIEM);
        }

        private void ghidanhTS_Click(object sender, EventArgs e)
        {
            GHIDANH gHIDANH = new GHIDANH();
            OPEN(gHIDANH);
        }

        private void xepLopTS_Click(object sender, EventArgs e)
        {
            XEPLOP xEPLOP = new XEPLOP();
            OPEN(xEPLOP);
        }

        private void updateNhanVienTS_Click(object sender, EventArgs e)
        {
            QUANLYNHANVIEN qUANLYNHANVIEN = new QUANLYNHANVIEN();
            OPEN(qUANLYNHANVIEN);
        }

        private void thongkeDSTS_Click(object sender, EventArgs e)
        {
            THONGKEDIEM tHONGKEDIEM = new THONGKEDIEM();
            OPEN(tHONGKEDIEM);
        }

        private void thongkeHPTS_Click(object sender, EventArgs e)
        {
            THONGKEHOCPHI tHONGKEHOCPHI = new THONGKEHOCPHI();
            OPEN(tHONGKEHOCPHI);
        }

        private void updateBienLaiTS_Click(object sender, EventArgs e)
        {
            BIENLAI bIENLAI    = new BIENLAI();
            OPEN(bIENLAI);
        }
    }
}
    