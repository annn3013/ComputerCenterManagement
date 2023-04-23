using BLL;
using DTO;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QUANLYLOPHOC : Form
    {
        public QUANLYLOPHOC()
        {
            InitializeComponent();
            lhBLL a = new lhBLL();
            dataGridView1.DataSource = a.loadLH2();
            button2.Enabled = false;
            xoa.Enabled = false;
            sua.Enabled = false;
            them.Enabled = true;
        }
        void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    // Nếu control là TextBox, thì xóa dữ liệu
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if (control.HasChildren)
                {
                    // Nếu control là container (như GroupBox, Panel), đệ quy gọi lại hàm
                    ClearAllTextBoxes(control);
                }
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            LopHoc a = new LopHoc();
            lhBLL lhBLL = new lhBLL();

            a.CaHoc = ca.Text;
            a.SiSo = siso.Text;
            a.MaPhongHoc = maphong.Text;
            a.NgayBatDau = ngaybatdau.Value;
            a.NgayKetThuc = ngayketthuc.Value;
            a.MaLopHoc = lhBLL.autoLH2();
            a.MaMonHoc = mamon.Text;
            a.TenLopHoc = tenlop.Text;
            string kq = lhBLL.themLH2(a);
            MessageBox.Show(kq);
            if (kq == "Thêm lớp học thành công")
            {
                malop.Clear();
                tenlop.Clear();
                siso.Clear();
                mamon.Clear();
                maphong.Clear();

                ca.Clear();
                malop2.Clear();
                ngayketthuc.Value = DateTime.Now;
                ngaybatdau.Value = DateTime.Now;
                dataGridView1.DataSource = lhBLL.loadLH2();
            }

        }

        private void huy_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(this);
            ngayketthuc.Value = DateTime.Now;
            ngaybatdau.Value = DateTime.Now;
            lhBLL lhBLL = new lhBLL();
            dataGridView1.DataSource = lhBLL.loadLH2();
        }


        private void tim_Click(object sender, EventArgs e)
        {
            lhBLL lhBLL = new lhBLL();
            string kq = lhBLL.checkLH2(malop2.Text);
            if (kq == "có")
            {
                malop.Text = malop2.Text;
                button2.Enabled = true;
                dataGridView1.DataSource = lhBLL.loadLHT2(malop.Text);
            }
            else
            {
                MessageBox.Show(kq);
            }

        }
        private bool tenlopHasValue = false; // Biến để kiểm tra giá trị của tenlop

        private void tenlop_TextChanged(object sender, EventArgs e)
        {
            if (!tenlopHasValue)
            {
                if (string.IsNullOrEmpty(tenlop.Text))
                {
                    // Nếu giá trị của textbox "tenlop" rỗng thì xóa giá trị của textbox "malop"
                    malop.Text = string.Empty;
                    tenlopHasValue = false; // Đánh dấu là tenlop không có giá trị
                }
                else
                {
                    // Nếu giá trị của textbox "tenlop" không rỗng thì gọi hàm PhatSinhMaLopHoc để lấy mã lớp học mới
                    lhBLL a = new lhBLL();
                    // Gán giá trị mã lớp học mới vào textbox "malop"
                    malop.Text = a.autoLH2();
                    tenlopHasValue = true; // Đánh dấu là tenlop đã có giá trị
                }
            }
            else
            {
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lhBLL a = new lhBLL();
            DataTable temp = a.loadLHT2(malop2.Text);
            tenlop.Text = temp.Rows[0]["TenLopHoc"].ToString();
            siso.Text = temp.Rows[0]["SiSo"].ToString();
            maphong.Text = temp.Rows[0]["MaPhongHoc"].ToString();
            mamon.Text = temp.Rows[0]["MaMonHoc"].ToString();
            ca.Text = temp.Rows[0]["CaHoc"].ToString();
            ngaybatdau.Value = Convert.ToDateTime(temp.Rows[0]["NgayBatDau"]);
            ngayketthuc.Value = Convert.ToDateTime(temp.Rows[0]["NgayKetThuc"]);
            malop.Text = malop2.Text;
            them.Enabled = false;
            xoa.Enabled = true;
            sua.Enabled = true;

        }

        private void sua_Click(object sender, EventArgs e)
        {
            LopHoc a = new LopHoc();
            lhBLL lhBLL = new lhBLL();
            a.MaLopHoc = malop.Text;
            a.MaMonHoc = mamon.Text;
            a.CaHoc = ca.Text;
            a.TenLopHoc = tenlop.Text;
            a.MaPhongHoc = maphong.Text;
            a.SiSo = siso.Text;
            a.NgayBatDau = ngaybatdau.Value;
            a.NgayKetThuc = ngayketthuc.Value;
            string kq = lhBLL.suaLH2(a);

            if (kq == "Sửa lớp học thành công")
            {
                MessageBox.Show(kq);
                malop.Clear();
                tenlop.Clear();
                siso.Clear();
                mamon.Clear();
                maphong.Clear();
                ca.Clear();
                malop2.Clear();
                ngayketthuc.Value = DateTime.Now;
                ngaybatdau.Value = DateTime.Now;
                dataGridView1.DataSource = lhBLL.loadLH2();
                xoa.Enabled = false;
                sua.Enabled = false;
                them.Enabled = true;
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            lhBLL lhBLL = new lhBLL();
            string malh = malop2.Text;
            string kq = lhBLL.xoaLH2(malh);
            if (kq == "Xóa lớp học thành công")
            {
                MessageBox.Show(kq);
                dataGridView1.DataSource = lhBLL.loadLH2();
                them.Enabled = true;
                xoa.Enabled = false;
                sua.Enabled = false;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void QUANLYLOPHOC_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
