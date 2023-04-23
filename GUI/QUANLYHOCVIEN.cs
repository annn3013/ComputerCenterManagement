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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class QUANLYHOCVIEN : Form
    {
        private DataTable dtTemp = new DataTable();
        public QUANLYHOCVIEN()
        {
            InitializeComponent();
            chon.Enabled = false;
            gioitinh.SelectedItem = "Nam";
            hvBLL hvBLL = new hvBLL();
            dataGridView1.DataSource = hvBLL.loadHV2();
            dtTemp = hvBLL.loadHV2();
            sua.Enabled = false;
            xoa.Enabled = false;
            them.Enabled = true;
        }
        private void Control_Changed(object sender, EventArgs e)
        {
            TaoMa();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string PhatSinhMaHocVien()
        {
            hvBLL hvBLL = new hvBLL();
            string maHocVienMoi = "";
            string maHocVienCuoiCung = hvBLL.LayMaCuoi2();

            if (maHocVienCuoiCung.StartsWith("HV"))
            {
                int soHocVien = int.Parse(maHocVienCuoiCung.Substring(2));

                soHocVien++;
                maHocVienMoi = "HV" + soHocVien.ToString("D3");
            }
            else
            {
                maHocVienMoi = "HV001";
            }


            return maHocVienMoi;
        }
        private string TaoMa()
        {
            if (!string.IsNullOrEmpty(diachi.Text)
                && !string.IsNullOrEmpty(hoten.Text)
                && !string.IsNullOrEmpty(sdt.Text)
                && !string.IsNullOrEmpty(nghe.Text)
                && gioitinh.SelectedIndex >= 0
                && dateTimePicker1.Value != null)
            {
                string maHocVien = PhatSinhMaHocVien();
                return maHocVien;
            }
            else
            {
                return "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hoten.TextChanged += new EventHandler(Control_Changed);
            gioitinh.SelectedIndexChanged += new EventHandler(Control_Changed);
            dateTimePicker1.ValueChanged += new EventHandler(Control_Changed);
            sdt.TextChanged += new EventHandler(Control_Changed);
            nghe.TextChanged += new EventHandler(Control_Changed);
            diachi.TextChanged += new EventHandler(Control_Changed);
            hvBLL hvBLL = new hvBLL();
            HocVien hocVien = new HocVien();
            hocVien.Sdt = sdt.Text;
            hocVien.DiaChi = diachi.Text;
            hocVien.NgaySinh = dateTimePicker1.Value;
            hocVien.HoTen = hoten.Text;
            hocVien.NgheNghiep = nghe.Text;
            if (gioitinh.SelectedIndex != -1)
            {
                hocVien.GioiTinh = gioitinh.SelectedItem?.ToString();
                hocVien.MaHV = TaoMa();
                string kq = hvBLL.themHV2(hocVien);
                MessageBox.Show(kq);
                if (kq == "Thêm học viên thành công")
                {
                    dataGridView1.DataSource = hvBLL.loadHV2();
                    dtTemp = hvBLL.loadHV2();
                    hoten.Clear();
                    diachi.Clear();
                    nghe.Clear();
                    sdt.Clear();
                    mahv.Clear();
                    gioitinh.Items.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }

            }
            hoten.TextChanged -= new EventHandler(Control_Changed);
            gioitinh.SelectedIndexChanged -= new EventHandler(Control_Changed);
            dateTimePicker1.ValueChanged -= new EventHandler(Control_Changed);
            sdt.TextChanged -= new EventHandler(Control_Changed);
            nghe.TextChanged -= new EventHandler(Control_Changed);
            diachi.TextChanged -= new EventHandler(Control_Changed);

        }



        private void diachi_TextChanged(object sender, EventArgs e)
        {
            TaoMa();
        }

        private void tim_Click(object sender, EventArgs e)
        {
            string mahv = mahv2.Text;
            hvBLL hvBLL = new hvBLL();
            string kq = hvBLL.TimHocVien2(mahv);
            if (kq != "Không tồn tại học viên này trong cơ sở dữ liệu")
            {
                chon.Enabled = true;

            }
            else
            {
                MessageBox.Show(kq);
            }
            dataGridView1.DataSource = hvBLL.loadHVT2(mahv);
        }

        private void chon_Click(object sender, EventArgs e)
        {
            mahv.Text = mahv2.Text;
            them.Enabled = false;
            sua.Enabled = true;
            xoa.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoten.TextChanged -= new EventHandler(Control_Changed);
            gioitinh.SelectedIndexChanged -= new EventHandler(Control_Changed);
            dateTimePicker1.ValueChanged -= new EventHandler(Control_Changed);
            sdt.TextChanged -= new EventHandler(Control_Changed);
            nghe.TextChanged -= new EventHandler(Control_Changed);
            diachi.TextChanged -= new EventHandler(Control_Changed);
            hvBLL hvBLL = new hvBLL();
            HocVien hocVien = new HocVien();
            hocVien.MaHV = mahv2.Text;
            hocVien.Sdt = sdt.Text;
            hocVien.DiaChi = diachi.Text;
            hocVien.NgaySinh = dateTimePicker1.Value;
            hocVien.HoTen = hoten.Text;
            hocVien.NgheNghiep = nghe.Text;

            if (gioitinh.SelectedIndex != -1)
            {
                hocVien.GioiTinh = gioitinh.SelectedItem?.ToString();
                string kq = hvBLL.capNhatHV2(hocVien);
                if (kq == "Cập nhật thông tin học viên thành công")
                {
                    MessageBox.Show(kq);
                    dataGridView1.DataSource = hvBLL.loadHV2();
                    dtTemp = hvBLL.loadHV2();
                    sdt.Clear();
                    diachi.Clear();
                    hoten.Clear();
                    nghe.Clear();
                    mahv.Clear();
                    gioitinh.Items.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    them.Enabled = true;
                    sua.Enabled = false;
                }
                else
                {
                    MessageBox.Show(kq);
                }

            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            sdt.Clear();
            diachi.Clear();
            hoten.Clear();
            nghe.Clear();
            mahv.Clear();
            gioitinh.Items.Clear();
            dateTimePicker1.Value=DateTime.Now;
            sua.Enabled = false;
            them.Enabled = true;

        }

        private void mahv_TextChanged(object sender, EventArgs e)
        {
            sua.Enabled = true;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string mahv1 = mahv2.Text;
            hvBLL hvBLL = new hvBLL();
            string a = hvBLL.xoaHV2(mahv1);
            MessageBox.Show(a);
            xoa.Enabled = false;
            mahv2.Clear();
            mahv.Clear();
            dataGridView1.DataSource = hvBLL.loadHV2();
            dtTemp = hvBLL.loadHV2();
        }

        private void QUANLYHOCVIEN_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tim_Click_1(object sender, EventArgs e)
        {
            string mahv = mahv2.Text;
            hvBLL hvBLL = new hvBLL();
            string kq = hvBLL.TimHocVien2(mahv);
            if (kq != "Không tồn tại học viên này trong cơ sở dữ liệu")
            {
                chon.Enabled = true;
                dataGridView1.DataSource = hvBLL.loadHVT2(mahv);

            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void chon_Click_1(object sender, EventArgs e)
        {
            mahv.Text = mahv2.Text;
            hvBLL a=    new hvBLL();
            DataTable temp = a.loadHVT2(mahv.Text);
            hoten.Text=temp.Rows[0]["HoTen"].ToString();
            sdt.Text= temp.Rows[0]["SoDienThoai"].ToString();
            nghe.Text= temp.Rows[0]["NgheNghiep"].ToString();
            diachi.Text= temp.Rows[0]["DiaChi"].ToString();
            dateTimePicker1.Value= Convert.ToDateTime(temp.Rows[0]["NgaySinh"]);
            gioitinh.Text = temp.Rows[0]["GioiTinh"].ToString();
            them.Enabled = false;
            sua.Enabled = true;
            xoa.Enabled = true;
        }

        private void tim2_Click(object sender, EventArgs e)
        {
            hvBLL hvBLL = new hvBLL();
            dataGridView1.DataSource = hvBLL.LoadTHV2(hoten2.Text);
        }

        private void huy2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtTemp;
        }
    }
}
