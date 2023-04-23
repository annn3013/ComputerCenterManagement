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

    public partial class XEPLOP : Form
    {
        private DataTable dtTemp = new DataTable();
        public XEPLOP()
        {
            InitializeComponent();

        }

        private void XEPLOP_Load(object sender, EventArgs e)
        {
            lhBLL lhBLL = new lhBLL();
            loadLH();
            dataGridView1.DataSource = lhBLL.loadLHC2();
            button4.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;
            gdBLL gdBLL = new gdBLL();
            dataGridView3.DataSource = gdBLL.loadGD2();
        }

        public void loadLH()
        {
            lhBLL lhBLL = new lhBLL();
            comboBox2.DataSource = lhBLL.loadLHC2();
            comboBox2.DisplayMember = "MaLopHoc";
            comboBox2.ValueMember = "MaLopHoc";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            lhBLL lhBLL = new lhBLL();
            // Lấy giá trị của ComboBox2
            object selectedValue = comboBox2.SelectedValue;
            // Kiểm tra và ép kiểu sang kiểu dữ liệu cần thiết
            if (selectedValue != null)
            {
                string value = selectedValue.ToString(); // Ép kiểu sang kiểu dữ liệu cần thiết
                                                         // Sử dụng giá trị lấy được từ ComboBox2
                dataGridView1.DataSource = lhBLL.loadLHT2(value);
                DataTable dt = lhBLL.loadLHT2(value);
                // Lấy giá trị của cột "MaLopHoc" từ dòng đầu tiên của DataTable
                string malop = dt.Rows[0]["MaLopHoc"].ToString();

                // Lấy giá trị của cột "TenLopHoc" từ dòng đầu tiên của DataTable
                string tenlop = dt.Rows[0]["TenLopHoc"].ToString();

                // Lấy giá trị của cột "SiSo" từ dòng đầu tiên của DataTable
                int siso = Convert.ToInt32(dt.Rows[0]["SiSo"]);

                // Lấy giá trị của cột "NgayBatDau" từ dòng đầu tiên của DataTable
                DateTime ngaybatdau = Convert.ToDateTime(dt.Rows[0]["NgayBatDau"]);

                // Lấy giá trị của cột "NgayKetThuc" từ dòng đầu tiên của DataTable
                DateTime ngayketthuc = Convert.ToDateTime(dt.Rows[0]["NgayKetThuc"]);

                // Lấy giá trị của cột "MaPhongHoc" từ dòng đầu tiên của DataTable
                string maphong = dt.Rows[0]["MaPhongHoc"].ToString();

                // Lấy giá trị của cột "CaHoc" từ dòng đầu tiên của DataTable

                int cahoc = Convert.ToInt32(dt.Rows[0]["CaHoc"]);
                // Lấy giá trị của cột "MaMonHoc" từ dòng đầu tiên của DataTable
                string mamon = dt.Rows[0]["MaMonHoc"].ToString();
                gvBLL gvBLL = new gvBLL();
                comboBox1.DataSource = gvBLL.loadGVC2(maphong, cahoc, ngaybatdau, ngayketthuc);
                comboBox1.DisplayMember = "MaGiaoVien";
                comboBox1.ValueMember = "MaGiaoVien";
                dataGridView2.DataSource = gvBLL.loadGVC2(maphong, cahoc, ngaybatdau, ngayketthuc);
                // Xóa sạch dữ liệu trong DataTable dtTemp
                dtTemp.Clear();

                // Thêm các cột từ DataGridView2 vào DataTable dtTemp nếu chưa tồn tại
                foreach (DataGridViewColumn dgvCol in dataGridView2.Columns)
                {
                    if (!dtTemp.Columns.Contains(dgvCol.Name))
                    {
                        dtTemp.Columns.Add(dgvCol.Name);
                    }
                }

                // Lặp qua từng dòng trong DataGridView2
                foreach (DataGridViewRow dgvRow in dataGridView2.Rows)
                {
                    // Tạo một dòng mới trong DataTable dtTemp
                    DataRow newRow = dtTemp.NewRow();

                    // Đặt giá trị của từng ô trong dòng mới dựa trên giá trị của các ô trong DataGridView2
                    foreach (DataGridViewCell dgvCell in dgvRow.Cells)
                    {
                        newRow[dgvCell.ColumnIndex] = dgvCell.Value;
                    }

                    // Thêm dòng mới vào DataTable dtTemp
                    dtTemp.Rows.Add(newRow);
                }
                button4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã lớp học ");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lhBLL lhBLL = new lhBLL();
            dataGridView1.DataSource = lhBLL.loadLHC2();
            button4.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            gvBLL gvBLL = new gvBLL();
            dataGridView2.DataSource = gvBLL.loadGVT2(comboBox1.SelectedValue.ToString());
            button5.Enabled = true;
            button3.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView2.DataSource = dtTemp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gdBLL gdBLL = new gdBLL();
            GiangDay giangDay = new GiangDay();
            giangDay.MaGiaoVien = comboBox1.SelectedValue.ToString();
            giangDay.MaLopHoc = comboBox2.SelectedValue.ToString();
            string kq = gdBLL.themGD2(giangDay.MaGiaoVien, giangDay.MaLopHoc);
            if (kq == "Thêm dữ liệu vào bảng GiangDay thành công")
            {
                MessageBox.Show(kq);
                button4.Enabled = false;
                button5.Enabled = false;
                button3.Enabled = false;
                lhBLL lhBLL = new lhBLL();
                loadLH();
                dataGridView1.DataSource = lhBLL.loadLHC2();
                dataGridView2.Columns.Clear();
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();

                dataGridView3.DataSource = gdBLL.loadGD2();
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            gdBLL gdBLL = new gdBLL();
            dataGridView3.DataSource = gdBLL.timGD2(hoten.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            gdBLL gdBLL = new gdBLL();
            string kq = gdBLL.xoaGD2(magv.Text, mamon.Text);
            if (kq == "Xóa dữ liệu từ bảng GiangDay thành công")
            {
                dataGridView3.DataSource = gdBLL.loadGD2();
                loadLH();
                comboBox1.Items.Clear();
                lhBLL lhBLL = new lhBLL();
                dataGridView1.DataSource = lhBLL.loadLHC2();
            }
            else
            {
                MessageBox.Show(kq);
            }
        }
    }
}
