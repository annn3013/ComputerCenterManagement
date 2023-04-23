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
    public partial class QUANLYGIAOVIEN : Form
    {
        private DataTable temp= new DataTable();
        public QUANLYGIAOVIEN()
        {
            InitializeComponent();
        }


        private void QUANLYGIAOVIEN_Load(object sender, EventArgs e)
        {
            gioitinh.SelectedIndex = 0;
            gvBLL gvBLL = new gvBLL();
            dataGridView1.DataSource = gvBLL.loadGV2();
            temp= gvBLL.loadGV2();
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
                    magv.Text = string.Empty;
                    tengvHasValue = false; // Đánh dấu là tengv không có giá trị
                }
                else
                {
                    // Nếu giá trị của textbox "hoten" không rỗng thì gọi hàm autoGV2 để lấy mã giáo viên mới
                    gvBLL a = new gvBLL();
                    // Gán giá trị mã giáo viên mới vào textbox "magv"
                    magv.Text = a.autoGV2();
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
            
            gvBLL a = new gvBLL();
            DataTable temp = a.loadGVT2(magv2.Text);
            hoten.Text = temp.Rows[0]["HoTen"].ToString();
            sdt.Text = temp.Rows[0]["SoDienThoai"].ToString();
            chucvu.Text = temp.Rows[0]["ChucVu"].ToString();
            diachi.Text = temp.Rows[0]["DiaChi"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(temp.Rows[0]["NgaySinh"]);
            gioitinh.Text= temp.Rows[0]["GioiTinh"].ToString();
            magv.Text = magv2.Text;
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
            gvBLL gvBLL = new gvBLL();
            string kq = gvBLL.checkGV2(magv2.Text);
            if (kq == "Mã giáo viên đã tồn tại trong cơ sở dữ liệu.")
            {
                chon.Enabled = true;
                dataGridView1.DataSource = gvBLL.loadGVT2(magv2.Text);
                
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void them_Click(object sender, EventArgs e)
        {
            GiaoVien a = new GiaoVien();
            gvBLL gvBLL = new gvBLL();
            a.MaGiaoVien = magv.Text;
            a.ChucVu = chucvu.Text;
            a.HoTen = hoten.Text;
            a.SoDienThoai = sdt.Text;
            a.NgaySinh = dateTimePicker1.Value;
            a.DiaChi = diachi.Text;
            a.GioiTinh = gioitinh.SelectedItem.ToString();
            string kq = gvBLL.themGV2(a);
            if (kq == "Thêm giáo viên thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                gioitinh.Items.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dataGridView1.DataSource = gvBLL.loadGV2();
                temp= gvBLL.loadGV2();
            }
            else
            {
                MessageBox.Show(kq);
            }


        }

        private void xoa_Click(object sender, EventArgs e)
        {
            gvBLL gvBLL = new gvBLL();
            string kq = gvBLL.xoaGV2(magv.Text);
            if (kq == "Xóa thông tin giáo viên thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                them.Enabled = true;
                xoa.Enabled = false;
                chon.Enabled = false;
                sua.Enabled = false;
                dataGridView1.DataSource = gvBLL.loadGV2();
                temp= gvBLL.loadGV2();

            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            GiaoVien a = new GiaoVien();
            gvBLL gvBLL = new gvBLL();
            a.MaGiaoVien = magv.Text;
            a.ChucVu = chucvu.Text;
            a.HoTen = hoten.Text;
            a.SoDienThoai = sdt.Text;
            a.NgaySinh = dateTimePicker1.Value;
            a.DiaChi = diachi.Text;
            a.GioiTinh = gioitinh.SelectedItem.ToString();
            string kq = gvBLL.suaGV2(a);
            if (kq == "Cập nhật thông tin giáo viên thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                gioitinh.Items.Clear();
                dateTimePicker1.Value = DateTime.Now;
                dataGridView1.DataSource = gvBLL.loadGV2();
                temp= gvBLL.loadGV2();
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = temp;
        }

        private void tim2_Click(object sender, EventArgs e)
        {
            gvBLL gvBLL = new gvBLL();
            dataGridView1.DataSource =gvBLL.loadTGV2(hoten2.Text);

        }

    }
}
