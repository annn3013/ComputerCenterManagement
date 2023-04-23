using BLL;
using DTO;
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
    public partial class THONGKEDIEM : Form
    {
        public THONGKEDIEM()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void THONGKEDIEM_Load(object sender, EventArgs e)
        {
            diemBLL diemBLL = new diemBLL();
            dataGridView1.DataSource = diemBLL.loadDiem2();
            yeu2.Enabled = false;
            yeu3.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            kha2.Enabled = false;
            kha3.Enabled = false;
            gioi2.Enabled = false;
            gioi3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiemM2(mamon.Text);
            if (kq == "có")
            {
                dataGridView1.DataSource = diemBLL2.hienDiemM2(mamon.Text);
                yeu3.Enabled = true;
                tb3.Enabled = true;
                kha3.Enabled = true;
                gioi3.Enabled = true;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiem2(mahv.Text);
            if (kq == "có")
            {
                dataGridView1.DataSource = diemBLL2.hienDiemT2(mahv.Text);
                yeu2.Enabled = true;
                tb2.Enabled = true;
                kha2.Enabled = true;
                gioi2.Enabled = true;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void yeu2_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiem2(mahv.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemT2(mahv.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh< 5.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void tb2_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiem2(mahv.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemT2(mahv.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh >= 5.0 AND DiemTrungBinh <= 6.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void kha2_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiem2(mahv.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemT2(mahv.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh > 6.0 AND DiemTrungBinh < 8.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void gioi2_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiem2(mahv.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemT2(mahv.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh>=8.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void yeu3_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiemM2(mamon.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemM2(mamon.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh< 5.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void tb3_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiemM2(mamon.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemM2(mamon.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh >= 5.0 AND DiemTrungBinh <= 6.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void kha3_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiemM2(mamon.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemM2(mamon.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh > 6.0 AND DiemTrungBinh < 8.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void gioi3_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiemM2(mamon.Text);
            if (kq == "có")
            {
                // Lấy đối tượng DataTable từ diemBLL2.hienDiemM2(mamon.Text)
                DataTable dtDiem = diemBLL2.hienDiemM2(mamon.Text);

                // Tạo DataView từ DataTable
                DataView dvDiem = new DataView(dtDiem);

                // Đặt bộ lọc cho DataView
                dvDiem.RowFilter = "DiemTrungBinh>=8.0"; // Áp dụng bộ lọc, chỉ hiển thị dòng có giá trị DiemTB < 5

                // Đặt DataView làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dvDiem;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void in2_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL2 = new diemBLL();
            string kq = diemBLL2.checkDiem2(mahv.Text);
            if (kq == "có")
            {
                this.Hide();
                INDIEM iNDIEM = new INDIEM(mahv.Text);
                iNDIEM.Show();
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void in1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mamon.Clear();
            mahv.Clear();
            diemBLL diemBLL = new diemBLL();
            dataGridView1.DataSource = diemBLL.loadDiem2();

        }
    }
}
