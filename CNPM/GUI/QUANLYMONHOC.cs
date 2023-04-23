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
using System.Web;
using System.Reflection.Metadata;

namespace GUI
{
    public partial class QUANLYMONHOC : Form
    {
        private DataTable temp = new DataTable();
        public QUANLYMONHOC()
        {
            InitializeComponent();
            mhBLL mhBLL = new mhBLL();
            dataGridView1.DataSource = mhBLL.loadMH2();
            xoa.Enabled = false;
            sua.Enabled = false;
            chon.Enabled = false;
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
                    if (textBox.Name == "tenmon")
                    {
                        tenlopHasValue = false; // Đánh dấu là tenlop không có giá trị
                    }
                }
                else if (control.HasChildren)
                {
                    // Nếu control là container (như GroupBox, Panel), đệ quy gọi lại hàm
                    clearAll(control);
                }
            }
        }

        private void QUANLYMONHOC_Load(object sender, EventArgs e)
        {
            mhBLL mhBLL = new mhBLL();
            temp = mhBLL.loadMH2();
        }
        private bool tenlopHasValue = false; // Biến để kiểm tra giá trị của tenlop



        private void button1_Click(object sender, EventArgs e)
        {
            clearAll(this);
            dataGridView1.DataSource = temp;
            them.Enabled = true;
            xoa.Enabled = false;
            sua.Enabled = false;
            chon.Enabled = false;
        }

        private void chon_Click(object sender, EventArgs e)
        {
            tenlopHasValue = true;
            mamon.Text = mamon2.Text;
            mhBLL a = new mhBLL();
            DataTable temp = a.loadMHT2(mamon2.Text);
            tenmon.Text = temp.Rows[0]["TenMonHoc"].ToString();
            sobuoi.Text = temp.Rows[0]["SoBuoi"].ToString();
            hocphi.Text = temp.Rows[0]["HocPhi"].ToString();
            makh.Text = temp.Rows[0]["MaKhoaHoc"].ToString();
            them.Enabled = false;
            xoa.Enabled = true;
            sua.Enabled = true;
        }

        private void tenmon_TextChanged(object sender, EventArgs e)
        {
            if (!tenlopHasValue)
            {
                if (string.IsNullOrEmpty(tenmon.Text))
                {
                    // Nếu giá trị của textbox "tenmon" rỗng thì xóa giá trị của textbox "mamon"
                    mamon.Text = string.Empty;
                    tenlopHasValue = false; // Đánh dấu là tenlop không có giá trị
                }
                else
                {
                    // Nếu giá trị của textbox "tenmon" không rỗng thì gọi hàm PhatSinhMaLopHoc để lấy mã lớp học mới
                    mhBLL a = new mhBLL();
                    // Gán giá trị mã lớp học mới vào textbox "mamon"
                    mamon.Text = a.autoMH2();
                    tenlopHasValue = true; // Đánh dấu là tenlop đã có giá trị
                }
            }
            else
            {
                return;
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            mhBLL mhBLL = new mhBLL();
            MonHoc a = new MonHoc();
            a.MaMonHoc = mamon.Text;
            a.TenMonHoc = tenmon.Text;
            int value = 0;
            if (int.TryParse(sobuoi.Text, out value))
            {
                a.SoBuoi = value;

            }
            else
            {
                a.SoBuoi = 0;
            }
            float value2 = 0;
            if (float.TryParse(hocphi.Text, out value2))
            {
                a.HocPhi = value2;

            }
            else
            {
                a.HocPhi = 0;
            }
            a.MaKhoaHoc = makh.Text;
            string kq = mhBLL.themMH2(a);
            if (kq == "Thêm môn học thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                dataGridView1.DataSource = mhBLL.loadMH2();
                temp = mhBLL.loadMH2();
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void tim_Click(object sender, EventArgs e)
        {
            string mamon = mamon2.Text;
            mhBLL mhBLL = new mhBLL();

            string kq = mhBLL.checkMH2(mamon);
            if (kq != "Mã môn học  không tồn tại trong cơ sở dữ liệu")
            {
                chon.Enabled = true;
                dataGridView1.DataSource = mhBLL.loadMHT2(mamon);
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void sua_Click(object sender, EventArgs e)
        {
            mhBLL mhBLL = new mhBLL();
            MonHoc a = new MonHoc();
            string mm = mamon.Text;
            a.MaMonHoc = mamon.Text;
            a.TenMonHoc = tenmon.Text;
            int value = 0;
            if (int.TryParse(sobuoi.Text, out value))
            {
                a.SoBuoi = value;

            }
            else
            {
                a.SoBuoi = 0;
            }
            float value2 = 0;
            if (float.TryParse(hocphi.Text, out value2))
            {
                a.HocPhi = value2;

            }
            else
            {
                a.HocPhi = 0;
            }
            a.MaKhoaHoc = makh.Text;
            string kq = mhBLL.suaMH2(mm, a);
            if (kq == "Cập nhật thông tin môn học thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                dataGridView1.DataSource = mhBLL.loadMH2();
                temp = mhBLL.loadMH2();
                them.Enabled = true;
                xoa.Enabled = false;
                sua.Enabled = false;
                chon.Enabled = false;
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            mhBLL mhBLL = new mhBLL();
            string mm = mamon.Text;
            string kq = mhBLL.xoaMH2(mm);
            if (kq == "Xóa môn học thành công")
            {
                MessageBox.Show(kq);
                dataGridView1.DataSource = mhBLL.loadMH2();
                temp = mhBLL.loadMH2();
                xoa.Enabled = false;
                sua.Enabled = false;
                chon.Enabled = false;
                them.Enabled = true;
                clearAll(this);
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                tenlopHasValue = true;
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tenmon.Text = row.Cells["TenMonHoc"].Value.ToString();
                mamon.Text = row.Cells["MaMonHoc"].Value.ToString();
                sobuoi.Text = row.Cells["SoBuoi"].Value.ToString();
                hocphi.Text = row.Cells["HocPhi"].Value.ToString();
                makh.Text = row.Cells["MaKhoaHoc"].Value.ToString();
                them.Enabled = false;
                xoa.Enabled = true;
                sua.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
