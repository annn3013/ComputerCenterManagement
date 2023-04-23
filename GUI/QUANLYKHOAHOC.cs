using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace GUI
{
    public partial class QUANLYKHOAHOC : Form
    {
        public QUANLYKHOAHOC()
        {
            InitializeComponent();
            khAccess a = new khAccess();
            dataGridView1.DataSource = a.LoadKH2();
            sua.Enabled = false;
            xoa.Enabled = false;
            chon.Enabled = false;
        }
        public static string TaoMaKH()
        {

            khBLL a = new khBLL();
            string maKHCuoiCung = a.getMaKH2();

            int soThuTu = 1;
            if (!string.IsNullOrEmpty(maKHCuoiCung))
            {
                // Lấy số thứ tự hiện tại từ mã khóa học cuối cùng
                string soThuTuStr = maKHCuoiCung.Substring(2);
                soThuTu = int.Parse(soThuTuStr) + 1;
            }

            // Tạo mã khóa học mới từ số thứ tự
            string maKH = "KH" + soThuTu.ToString().PadLeft(2, '0');

            // Nếu không có mã khóa học cuối cùng thì trả về KH01
            if (string.IsNullOrEmpty(maKHCuoiCung))
            {
                maKH = "KH01";
            }

            return maKH;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            hoten.TextChanged += new EventHandler(hoten_TextChanged);
            KhoaHoc a = new KhoaHoc();
            khBLL khBLL = new khBLL();
            a.MaKH = textBox1.Text;
            a.TenKH = hoten.Text;
            string kq = khBLL.themKH2(a);
            MessageBox.Show(kq);
            dataGridView1.DataSource = khBLL.LoadKH2();

        }

        private void QUANLYKHOAHOC_Load(object sender, EventArgs e)
        {

        }

        private void hoten_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = TaoMaKH();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoten.Clear();
            textBox1.Clear();
            textBox2.Clear();
            sua.Enabled = false;
            xoa.Enabled = false;
            them.Enabled = true;
            chon.Enabled = false;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            khBLL khBLL = new khBLL();
            string makh = textBox2.Text;
            string kq = khBLL.CheckKHT2(makh);
            if (kq != "Không tồn tại khóa học này trong cơ sở dữ liệu")
            {
                dataGridView1.DataSource = khBLL.LoadKHT2(makh);
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            KhoaHoc a = new KhoaHoc();
            khBLL khBLL2 = new khBLL();
            a.MaKH = textBox2.Text;
            a.TenKH = hoten.Text;
            string kq = khBLL2.suaKH2(a);
            MessageBox.Show(kq);
            dataGridView1.DataSource = khBLL2.LoadKH2();
            hoten.TextChanged += new EventHandler(hoten_TextChanged);
        }

        private void chon_Click(object sender, EventArgs e)
        {
            hoten.TextChanged -= new EventHandler(hoten_TextChanged);
            textBox1.Text = textBox2.Text;
            sua.Enabled = true;
            xoa.Enabled = true;
            them.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            chon.Enabled = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string makh = textBox2.Text;
            khBLL a = new khBLL();
            string kq = a.xoaKH2(makh);
            MessageBox.Show(kq);
            dataGridView1.DataSource = a.LoadKH2();
        }
    }
}
