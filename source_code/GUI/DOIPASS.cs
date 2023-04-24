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

namespace GUI
{
    public partial class DOIPASS : Form
    {
        private string tentaikhoan;
        private string matkhau;
        public DOIPASS()
        {
            InitializeComponent();

        }
        public DOIPASS(string tentaikhoan, string matkhau)
        {
            InitializeComponent();
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }


        private void DOIPASS_Load(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                matkhaucuTxt.UseSystemPasswordChar = false;
                matkhaumoiTxt.UseSystemPasswordChar = false;
                xacnhanTxt.UseSystemPasswordChar = false;
            }
            else
            {
                matkhaucuTxt.UseSystemPasswordChar = true;
                matkhaumoiTxt.UseSystemPasswordChar = true;
                xacnhanTxt.UseSystemPasswordChar = true;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                matkhaucuTxt.UseSystemPasswordChar = false;
                matkhaumoiTxt.UseSystemPasswordChar = false;
                xacnhanTxt.UseSystemPasswordChar = false;
            }
            else
            {
                matkhaucuTxt.UseSystemPasswordChar = true;
                matkhaumoiTxt.UseSystemPasswordChar = true;
                xacnhanTxt.UseSystemPasswordChar = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tkBLL tkBLL = new tkBLL();
            string a = tkBLL.DoiPass(this.tentaikhoan, matkhaumoiTxt.Text, matkhaucuTxt.Text, this.matkhau, xacnhanTxt.Text);
            MessageBox.Show(a);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matkhaucuTxt.Clear();
            matkhaumoiTxt.Clear();
            xacnhanTxt.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void xacnhanTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
