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
    public partial class QUANLYPHONG : Form
    {
        public QUANLYPHONG()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void QUANLYPHONG_Load(object sender, EventArgs e)
        {
            phBLL a = new phBLL();
            dataGridView1.DataSource = a.loadPH2();
            sua.Enabled = false;
        }

        private void them_Click(object sender, EventArgs e)
        {
            Phong a = new Phong();
            phBLL phBLL = new phBLL();
            a.MaPhongHoc = maphong.Text;
            a.TenPhongHoc = tenphong.Text;
            string kq = phBLL.themPH2(a);
            if (kq == "Thêm phòng học thành công")
            {
                dataGridView1.DataSource = phBLL.loadPH2();
                maphong.Clear();
                tenphong.Clear();
            }
            MessageBox.Show(kq);
        }

        private void sua_Click(object sender, EventArgs e)
        {
            Phong a = new Phong();
            phBLL phBLL = new phBLL();
            a.MaPhongHoc = maphong.Text;
            a.TenPhongHoc = tenphong.Text;
            string kq = phBLL.suaPH2(a);
            if (kq == "Sửa thông tin phòng học thành công")
            {
                dataGridView1.DataSource = phBLL.loadPH2();
                maphong.Clear();
                tenphong.Clear();
                them.Enabled = true;
                sua.Enabled = false;
            }
            MessageBox.Show(kq);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                dataGridView1.Rows[e.RowIndex].Selected = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                maphong.Text = row.Cells["MaPhongHoc"].Value.ToString();
                tenphong.Text = row.Cells["TenPhongHoc"].Value.ToString();

                them.Enabled = false;
                sua.Enabled = true;


            }
        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            them.Enabled = true;
            sua.Enabled = false;
            maphong.Clear();
            tenphong.Clear();
        }
    }
}
