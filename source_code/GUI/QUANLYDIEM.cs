using BLL;
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


namespace GUI
{
    public partial class QUANLYDIEM : Form
    {
        public QUANLYDIEM()
        {
            InitializeComponent();
            diemBLL diemBLL = new diemBLL();
            dataGridView1.DataSource = diemBLL.loadDiem2();
            chon.Enabled = false;
            xoa.Enabled = false;
            sua.Enabled = false;
        }

        private void QUANLYDIEM_Load(object sender, EventArgs e)
        {

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
                }
                else if (control.HasChildren)
                {
                    // Nếu control là container (như GroupBox, Panel), đệ quy gọi lại hàm
                    clearAll(control);
                }
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL = new diemBLL();
            Diem diem = new Diem();
            diem.MaHV = mahv.Text;
            diem.MaMH = mamon.Text;
            float kt1Value;
            if (float.TryParse(kt1.Text, out kt1Value))
            {
                // Giá trị của kt1.Text là kiểu float, có thể sử dụng kt1Value để thực hiện các xử lý tiếp theo
                diem.KT1 = kt1Value;
            }
            else
            {
                diem.KT1 = -1;
            }
            float kt2Value;
            if (float.TryParse(kt2.Text, out kt2Value))
            {
                // Giá trị của kt1.Text là kiểu float, có thể sử dụng kt1Value để thực hiện các xử lý tiếp theo
                diem.KT2 = kt2Value;
            }
            else
            {
                diem.KT1 = -1;
            }
            float ktValue;
            if (float.TryParse(diemthi.Text, out ktValue))
            {
                // Giá trị của kt1.Text là kiểu float, có thể sử dụng kt1Value để thực hiện các xử lý tiếp theo
                diem.DiemThi = ktValue;
            }
            else
            {
                diem.DiemThi = -1;
            }
            string kq = diemBLL.themDiem2(diem);
            if (kq == "Thêm điểm thành công")
            {
                MessageBox.Show(kq);
                dataGridView1.DataSource = diemBLL.loadDiem2();
                clearAll(this);
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void huy_Click(object sender, EventArgs e)
        {
            clearAll(this);
            them.Enabled = true;
            sua.Enabled = false;
            xoa.Enabled = false;
        }

        private void chon_Click(object sender, EventArgs e)
        {
            mahv.Text = mahv2.Text;
            them.Enabled = false;
            sua.Enabled = true;
            xoa.Enabled = true;
        }

        private void tim_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL = new diemBLL();
            string kq = diemBLL.checkDiem2(mahv2.Text);
            if (kq == "có")
            {
                dataGridView2.DataSource = diemBLL.loadDiemT2(mahv2.Text);
                chon.Enabled = true;
            }
            else
            {
                MessageBox.Show(kq);
                chon.Enabled = false;
            }

        }

        private void sua_Click(object sender, EventArgs e)
        {
            diemBLL diemBLL = new diemBLL();
            Diem diem = new Diem();
            diem.MaHV = mahv.Text;
            diem.MaMH = mamon.Text;
            float kt1Value;
            if (float.TryParse(kt1.Text, out kt1Value))
            {
                // Giá trị của kt1.Text là kiểu float, có thể sử dụng kt1Value để thực hiện các xử lý tiếp theo
                diem.KT1 = kt1Value;
            }
            else
            {
                diem.KT1 = -1;
            }
            float kt2Value;
            if (float.TryParse(kt2.Text, out kt2Value))
            {
                // Giá trị của kt1.Text là kiểu float, có thể sử dụng kt1Value để thực hiện các xử lý tiếp theo
                diem.KT2 = kt2Value;
            }
            else
            {
                diem.KT1 = -1;
            }
            float ktValue;
            if (float.TryParse(diemthi.Text, out ktValue))
            {
                // Giá trị của kt1.Text là kiểu float, có thể sử dụng kt1Value để thực hiện các xử lý tiếp theo
                diem.DiemThi = ktValue;
            }
            else
            {
                diem.DiemThi = -1;
            }
            string kq = diemBLL.suaDiem2(diem);
            if (kq == "Cập nhật điểm thành công")
            {
                MessageBox.Show(kq);
                dataGridView1.DataSource = diemBLL.loadDiem2();
                clearAll(this);
                chon.Enabled = false;
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
            diemBLL diemBLL = new diemBLL();
            string kq = diemBLL.xoaDiem2(mahv.Text, mamon.Text);
            if (kq == "Xóa điểm thành công")
            {
                MessageBox.Show(kq);
                clearAll(this);
                dataGridView1.DataSource = diemBLL.loadDiem2();
                chon.Enabled = false;
                xoa.Enabled = false;
                sua.Enabled = false;
                them.Enabled = true;
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


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                mahv.Text = row.Cells["MaHocVien"].Value.ToString();
                mamon.Text = row.Cells["MaMonHoc"].Value.ToString();
                kt1.Text = row.Cells["DiemKiemTra1"].Value.ToString();
                kt2.Text = row.Cells["DiemKiemTra2"].Value.ToString();
                diemthi.Text = row.Cells["DiemThi"].Value.ToString();
                them.Enabled = false;
                xoa.Enabled = true;
                sua.Enabled = true;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Selected = true;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            mahv.Text = row.Cells["MaHocVien"].Value.ToString();
            mamon.Text = row.Cells["MaMonHoc"].Value.ToString();
            kt1.Text = row.Cells["DiemKiemTra1"].Value.ToString();
            kt2.Text = row.Cells["DiemKiemTra2"].Value.ToString();
            diemthi.Text = row.Cells["DiemThi"].Value.ToString();
            them.Enabled = false;
            xoa.Enabled = true;
            sua.Enabled = true;
        }
    }
}
