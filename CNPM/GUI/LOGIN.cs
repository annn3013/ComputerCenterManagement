
using DTO;
using BLL;
namespace GUI
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hienmk.Checked)
            {
                mkbox.UseSystemPasswordChar = false;
            }
            else
            {
                mkbox.UseSystemPasswordChar = true;
            }
        }


        private void dangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tkBLL tkBLL = new tkBLL();
            Quyen quyen = new Quyen();
            tk.TenTaiKhoan = tkbox.Text;
            tk.MatKhau = mkbox.Text;
            string getUser = tkBLL.CheckLogin(tk);
            int getUser2 = tkBLL.CheckLogin2(tk);
            String tenquyen = tkBLL.CheckQuyen(getUser2);
            quyen.MaQuyen = getUser2;
            if (getUser == "Vui lòng nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            if (getUser == "Vui lòng nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            if (getUser == "tài khoản hoặc mật khẩu không chính xác")
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không chính xác");
                return;
            }
            MessageBox.Show($"Chào mừng {tenquyen} đến với hệ thống");
            HETHONG hethong = new HETHONG(tenquyen, tk.TenTaiKhoan, tk.MatKhau);
            this.Hide();
            hethong.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}