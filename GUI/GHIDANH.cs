﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GHIDANH : Form
    {
        private DataTable dtTemp = new DataTable();
        public GHIDANH()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GHIDANH_Load(object sender, EventArgs e)
        {
            hvBLL a = new hvBLL();
            ghdBLL ghdBLL = new ghdBLL();
            dataGridView1.DataSource = a.loadHV2();
            dtTemp = a.loadHV2();
            dataGridView3.DataSource = ghdBLL.loadGhD2();
            chon2.Enabled = false;

        }

        private void tim_Click(object sender, EventArgs e)
        {
            string a = mahv.Text;
            hvBLL hvBLL = new hvBLL();
            string kq = hvBLL.TimHocVien2(a);
            if (kq != "Không tồn tại học viên này trong cơ sở dữ liệu")
            {
                chon.Enabled = true;
                dataGridView1.DataSource = hvBLL.loadHVT2(a);

            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void huy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtTemp;
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            chon2.Enabled = false;
        }

        private void chon_Click(object sender, EventArgs e)
        {
            lhBLL a = new lhBLL();
            comboBox1.DataSource = a.loadLHDK2(mahv.Text);
            comboBox1.DisplayMember = "MaLopHoc";
            comboBox1.ValueMember = "MaLopHoc";
            dataGridView2.DataSource = a.loadLHDK2(mahv.Text);
            chon2.Enabled = true;
        }

        private void chon2_Click(object sender, EventArgs e)
        {
            ghdBLL a = new ghdBLL();
            string kq = a.themGhD2(mahv.Text, comboBox1.SelectedValue.ToString());
            if (kq == "Thêm dữ liệu vào bảng ghidanh thành công")
            {
                dataGridView3.DataSource = a.loadGhD2();
                dataGridView1.DataSource = dtTemp;
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
                chon2.Enabled = false;
            }
            MessageBox.Show(kq);

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            ghdBLL a = new ghdBLL();
            string kq = a.xoaGhD2(textBox1.Text, textBox2.Text);
            if (kq == "Xóa dữ liệu từ bảng ghidanh thành công")
            {
                dataGridView3.DataSource = a.loadGhD2();
                hvBLL b = new hvBLL();
                ghdBLL ghdBLL = new ghdBLL();
                dataGridView1.DataSource = b.loadHV2();
                dtTemp = b.loadHV2();
                dataGridView3.DataSource = ghdBLL.loadGhD2();
                chon2.Enabled = false;
            }
            MessageBox.Show(kq);
        }
    }
}
