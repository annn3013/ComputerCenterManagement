using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GUI
{
    public partial class QUANLYACC : Form
    {
        public QUANLYACC()
        {
            InitializeComponent();
            tkTextBox.TextChanged += UpdateMaTK;
            mkTextBox.TextChanged += UpdateMaTK;
            comboBox1.TextChanged += UpdateMaTK;
            tkBLL tkBLL = new tkBLL();
            dataGridView1.DataSource = tkBLL.loadTK2();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            button6.Enabled = false;
            button5.Enabled = false;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mkTextBox.Clear();
            tkTextBox.Clear();
            comboBox1.Text = "";
            maTKtextBox.Clear();
            button1.Enabled = true;

        }



        private void QUANLYACC_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void UpdateMaTK(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tkTextBox.Text) && !string.IsNullOrEmpty(mkTextBox.Text) && !string.IsNullOrEmpty(comboBox1.Text))
            {
                // Set giá trị cho maTKTextBox khi cả 3 control trên đều đã được điền giá trị
                maTKtextBox.Text = PhatSinhMaTaiKhoan();
            }
            else
            {
                maTKtextBox.Text = string.Empty;
            }
        }
        public static string phatSinhMaTK()
        {
            tkBLL tkBLL = new tkBLL();
            string maTK = "";
            int stt = tkBLL.demTK2() + 1;
            if (stt < 10)
            {
                maTK = "TK00" + stt;
            }
            else if (stt < 100)
            {
                maTK = "TK0" + stt;
            }
            else
            {
                maTK = "TK" + stt;
            }
            return maTK;
        }
        public static string PhatSinhMaTaiKhoan()
        {
            tkBLL tkBLL = new tkBLL();
            string maTaiKhoan = tkBLL.loadMTK2();
            string maTK = "";
            int stt = 1;
            if (maTaiKhoan != null)
            {
                stt = Convert.ToInt32(maTaiKhoan.Substring(2)) + 1;
            }
            if (stt < 10)
            {
                maTK = "TK00" + stt;
            }
            else if (stt < 100)
            {
                maTK = "TK0" + stt;
            }
            else
            {
                maTK = "TK" + stt;
            }
            return maTK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            tkBLL tkBLL = new tkBLL();
            taiKhoan.TenTaiKhoan = tkTextBox.Text;
            taiKhoan.MatKhau = mkTextBox.Text;
            int maQuyen = 0;
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    if (selectedItem == "Admin")
                    {
                        maQuyen = 1;
                    }
                    if (selectedItem == "Quản Lý Nhân Sự")
                    {
                        maQuyen = 4;
                    }
                    if (selectedItem == "Nhân Viên Lễ Tân")
                    {
                        maQuyen = 3;
                    }
                    if (selectedItem == "Quản Lý Kế Hoạch")
                    {
                        maQuyen = 2;
                    }

                }
            }
            taiKhoan.MaQuyen = maQuyen;
            taiKhoan.MaTaiKhoan = maTKtextBox.Text;
            string kq = tkBLL.themTK2(taiKhoan);
            MessageBox.Show(kq);
            dataGridView1.DataSource = tkBLL.loadTK2();
            mkTextBox.Clear();
            tkTextBox.Clear();
            comboBox1.Text = "";
            maTKtextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tkBLL tkBLL = new tkBLL();
            string a = tkBLL.checkTKT2(timkiemTextBox1.Text);

            if (a == "ok")
            {
                dataGridView2.DataSource = tkBLL.loadTKT2(timkiemTextBox1.Text);
                button4.Enabled = true;
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            else
            {
                MessageBox.Show(a);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tkTextBox.TextChanged -= UpdateMaTK;
            mkTextBox.TextChanged -= UpdateMaTK;
            comboBox1.TextChanged -= UpdateMaTK;
            button1.Enabled = false;
            button6.Enabled = true;
            button5.Enabled = true;
            maTKtextBox.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();


        }

        private void button6_Click(object sender, EventArgs e)
        {

            TaiKhoan taiKhoan = new TaiKhoan();
            tkBLL tkBLL = new tkBLL();
            taiKhoan.TenTaiKhoan = tkTextBox.Text;
            taiKhoan.MatKhau = mkTextBox.Text;
            int maQuyen = 0;
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(selectedItem))
                {
                    if (selectedItem == "Admin")
                    {
                        maQuyen = 1;
                    }
                    if (selectedItem == "Quản Lý Nhân Sự")
                    {
                        maQuyen = 4;
                    }
                    if (selectedItem == "Nhân Viên Lễ Tân")
                    {
                        maQuyen = 3;
                    }
                    if (selectedItem == "Quản Lý Kế Hoạch")
                    {
                        maQuyen = 2;
                    }

                }
            }
            taiKhoan.MaQuyen = maQuyen;
            taiKhoan.MaTaiKhoan = maTKtextBox.Text;
            string kq = tkBLL.suaTK2(taiKhoan);
            MessageBox.Show(kq);
            if (kq == "Cập nhật thông tin tài khoản thành công")
            {
                dataGridView1.DataSource = tkBLL.loadTK2();
                mkTextBox.Clear();
                tkTextBox.Clear();
                comboBox1.Text = "";
                maTKtextBox.Clear();
                tkTextBox.TextChanged += UpdateMaTK;
                mkTextBox.TextChanged += UpdateMaTK;
                comboBox1.TextChanged += UpdateMaTK;
                button1.Enabled = true;
                button6.Enabled = false;
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            tkBLL tkBLL = new tkBLL();
            TaiKhoan taiKhoan = new TaiKhoan();
            string kq = tkBLL.xoaTK2(maTKtextBox.Text);
            dataGridView1.DataSource = tkBLL.loadTK2();
            button5.Enabled = false;
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            maTKtextBox.Clear();
            timkiemTextBox1.Clear();
            tkTextBox.Clear();
            mkTextBox.Clear();
            button4.Enabled = false;
            button6.Enabled = false;
            button1.Enabled = true;
            tkTextBox.TextChanged += UpdateMaTK;
            mkTextBox.TextChanged += UpdateMaTK;
            comboBox1.TextChanged += UpdateMaTK;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                tkTextBox.TextChanged -= UpdateMaTK;
                mkTextBox.TextChanged -= UpdateMaTK;
                comboBox1.TextChanged -= UpdateMaTK;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tkTextBox.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                mkTextBox.Text = row.Cells["MatKhau"].Value.ToString();
                maTKtextBox.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                button6.Enabled = true;
                button5.Enabled = true;

            }
        }

        private void tkTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                tkTextBox.TextChanged -= UpdateMaTK;
                mkTextBox.TextChanged -= UpdateMaTK;
                comboBox1.TextChanged -= UpdateMaTK;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tkTextBox.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                mkTextBox.Text = row.Cells["MatKhau"].Value.ToString();
                maTKtextBox.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                button1.Enabled = false;
                button6.Enabled = true;
                button5.Enabled = true;

            }
        }
    }
}
