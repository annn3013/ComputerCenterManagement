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
    public partial class BIENLAI : Form
    {
        private DataTable dtTemp = new DataTable();
        public BIENLAI()
        {
            InitializeComponent();
        }
        void clearAll(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    // Nếu control là TextBox, thì xóa dữ liệu
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

        private void button1_Click(object sender, EventArgs e)
        {
            BienLai bl = new BienLai();
            blBLL blBLL = new blBLL();
            bl.MaHocVien = mahv.Text;
            bl.TenNguoiDong = nguoidong.Text;
            float value2 = 0;
            if (float.TryParse(sotien.Text, out value2))
            {
                bl.SoTien = value2;

            }
            else
            {
                bl.SoTien = 0;
            }
            bl.NgayDong = ngaydong.Value;
            bl.ID = blBLL.autoBL2();
            string kq = blBLL.themBL2(bl);
            if (kq == "Thêm dữ liệu vào bảng BienLai thành công")
            {
                dataGridView1.DataSource = blBLL.loadBL2();
                dtTemp = blBLL.loadBL2();
                clearAll(this);
            }
            else
            {
                MessageBox.Show(kq);

            }

        }

        private void BIENLAI_Load(object sender, EventArgs e)
        {
            blBLL a = new blBLL();
            dataGridView1.DataSource = a.loadBL2();
            dtTemp = a.loadBL2();
            sua.Enabled = false;
            xoa.Enabled = false;
        }

        private void sua_Click(object sender, EventArgs e)
        {
            BienLai bl = new BienLai();
            blBLL blBLL = new blBLL();
            bl.MaHocVien = mahv.Text;
            bl.TenNguoiDong = nguoidong.Text;
            float value2 = 0;
            if (float.TryParse(sotien.Text, out value2))
            {
                bl.SoTien = value2;

            }
            else
            {
                bl.SoTien = 0;
            }
            bl.NgayDong = ngaydong.Value;
            bl.ID = id.Text;
            string kq = blBLL.suaBL2(bl);
            if (kq == "Cập nhật thông tin Biên Lai thành công")
            {
                dataGridView1.DataSource = blBLL.loadBL2();
                dtTemp = blBLL.loadBL2();
                sua.Enabled = false;
                xoa.Enabled = false;
                xacnhan.Enabled = true;
                clearAll(this);

            }
            else
            {
                MessageBox.Show(kq);

            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string ID = id.Text;
            blBLL blBLL = new blBLL();
            string kq = blBLL.xoaBL2(ID);
            if (kq == "xóa biên lai thành công")
            {
                dataGridView1.DataSource = blBLL.loadBL2();
                dtTemp = blBLL.loadBL2();
                sua.Enabled = false;
                xoa.Enabled = false;
                xacnhan.Enabled = true;

            }
            MessageBox.Show(kq);

        }

        private void chon_Click(object sender, EventArgs e)
        {
            blBLL blBLL =     new blBLL();
            string kq = blBLL.CheckMBL2(id.Text);
            if(kq== "ID đã tồn tại trong bảng BiênLai")
            {
                xacnhan.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
            }
            else
            {
                MessageBox.Show(kq);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            blBLL blBLL = new blBLL();
            string kq = blBLL.CheckBL2(mahv2.Text);
            if (kq == "Mã học viên đã tồn tại trong bảng BiênLai")
            {
                dataGridView1.DataSource = blBLL.loadBLT2(mahv2.Text);
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtTemp;
        }
    }
}
