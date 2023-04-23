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
using DAL;
using BLL;

namespace GUI
{
    public partial class QUANLYNHANVIEN : Form
    {
        private DataTable temp = new DataTable();
        public QUANLYNHANVIEN()
        {
            InitializeComponent();
        }

        private void QUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
            gioitinh.SelectedIndex = 0;
            nvBLL nvBLL = new nvBLL();
            dataGridView1.DataSource = nvBLL.loadNV2();
            temp = nvBLL.loadNV2();
            them.Enabled = true;
            xoa.Enabled = false;
            chon.Enabled = false;
            sua.Enabled = false;
        }
        void clearAll(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    // Nếu control là TextBox, thì xóa dữ liệu và đánh dấu lại giá trị của biến "tenlopHasValue"
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                    if (textBox.Name == "hoten")
                    {
                        tengvHasValue = false; // Đánh dấu là tenlop không có giá trị
                    }
                }
                else if (control.HasChildren)
                {
                    // Nếu control là container (như GroupBox, Panel), đệ quy gọi lại hàm
                    clearAll(control);
                }
            }
        }

        private bool tengvHasValue = false; // Biến để kiểm tra giá trị của tenlop

        private void hoten_TextChanged(object sender, EventArgs e)
        {
            if (!tengvHasValue)
            {
                if (string.IsNullOrEmpty(hoten.Text))
                {
                    // Nếu giá trị của textbox "hoten" rỗng thì xóa giá trị của textbox "magv"
                    manv.Text = string.Empty;
                    tengvHasValue = false; // Đánh dấu là tengv không có giá trị
                }
                else
                {
                    // Nếu giá trị của textbox "hoten" không rỗng thì gọi hàm autoGV2 để lấy mã giáo viên mới
                    nvBLL a = new nvBLL();
                    // Gán giá trị mã giáo viên mới vào textbox "magv"
                    manv.Text = a.autoNV2();
                    tengvHasValue = true; // Đánh dấu là tengv đã có giá trị
                }
            }
            else
            {
                return;
            }
        }

        private void chon_Click(object sender, EventArgs e)
        {
            nvBLL a = new nvBLL();
            DataTable temp = a.loadNVT2(manv2.Text);
            hoten.Text = temp.Rows[0]["HoTen"].ToString();
            sdt.Text = temp.Rows[0]["SoDienThoai"].ToString();
            chucvu.Text = temp.Rows[0]["ChucVu"].ToString();
            diachi.Text = temp.Rows[0]["DiaChi"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(temp.Rows[0]["NgaySinh"]);
            gioitinh.Text = temp.Rows[0]["GioiTinh"].ToString();
            manv.Text = manv2.Text;
            tengvHasValue = true;
            them.Enabled = false;
            xoa.Enabled = true;
            chon.Enabled = true;
            sua.Enabled = true;
        }

        private void huy_Click(object sender, EventArgs e)
        {
            clearAll(this);
            gioitinh.Items.Clear();
            dateTimePicker1.Value = DateTime.Now;
            them.Enabled = true;
            xoa.Enabled = false;
            chon.Enabled = false;
            sua.Enabled = false;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            nvBLL nvBLL = new nvBLL();
            string kq = nvBLL.checkNV2(manv2.Text);
            if (kq == "oke")
            {
                chon.Enabled = true;
                dataGridView1.DataSource = nvBLL.loadNVT2(manv2.Text);
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            NhanVien a = new NhanVien();
            nvBLL nvBLL = new nvBLL();
            a.MaNhanVien = manv.Text;
            a.ChucVu = chucvu.Text;
            a.HoTen = hoten.Text;
            a.SoDienThoai = sdt.Text;
            a.NgaySinh = dateTimePicker1.Value;
            a.DiaChi = diachi.Text;
            a.GioiTinh = gioitinh.SelectedItem.ToString();
            string kq = nvBLL.themNV2(a);
            if (kq == "Thêm nhân viên thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                gioitinh.Items.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dataGridView1.DataSource = nvBLL.loadNV2();
                temp = nvBLL.loadNV2();
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            nvBLL nvBLL = new nvBLL();
            string kq = nvBLL.xoaNV2(manv.Text);
            if (kq == "Xóa nhân viên thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                them.Enabled = true;
                xoa.Enabled = false;
                chon.Enabled = false;
                sua.Enabled = false;
                dataGridView1.DataSource = nvBLL.loadNV2();
                temp = nvBLL.loadNV2();

            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            NhanVien a = new NhanVien();
            nvBLL nvBLL = new nvBLL();
            a.MaNhanVien = manv.Text;
            a.ChucVu = chucvu.Text;
            a.HoTen = hoten.Text;
            a.SoDienThoai = sdt.Text;
            a.NgaySinh = dateTimePicker1.Value;
            a.DiaChi = diachi.Text;
            a.GioiTinh = gioitinh.SelectedItem.ToString();
            string kq = nvBLL.suaNV2(a);
            if (kq == "Sửa thông tin nhân viên thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                gioitinh.Items.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dataGridView1.DataSource = nvBLL.loadNV2();
                temp = nvBLL.loadNV2();
                them.Enabled = true;
                xoa.Enabled = false;
                chon.Enabled = false;
                sua.Enabled = false;
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void tim2_Click(object sender, EventArgs e)
        {
            nvBLL nvBLL = new nvBLL();
            dataGridView1.DataSource = nvBLL.loadTNV2(hoten2.Text);
        }

        private void huy2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = temp;
        }
    }
}
