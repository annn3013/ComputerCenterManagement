using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class THONGKEHOCPHI : Form
    {
        public THONGKEHOCPHI()
        {
            InitializeComponent();
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHP2();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void THONGKEHOCPHI_Load(object sender, EventArgs e)
        {

        }

        private void tim_Click(object sender, EventArgs e)
        {
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHPTK2(hoten.Text);
        }

        private void chuadong_Click(object sender, EventArgs e)
        {
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHPC2();
        }

        private void dongthieu_Click(object sender, EventArgs e)
        {
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHPT2();
        }

        private void dongdu_Click(object sender, EventArgs e)
        {
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHPD2();
        }

        private void dongdu2_Click(object sender, EventArgs e)
        {
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHPDu2();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            hpBLL a = new hpBLL();
            dataGridView1.DataSource = a.loadHP2();
        }
    }
}
