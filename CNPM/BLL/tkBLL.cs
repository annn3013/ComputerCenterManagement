using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;


namespace BLL
{
    public class tkBLL
    {
        tkAccess tkAccess = new tkAccess();
        quyenAccess quyenAccess = new quyenAccess();
        public string CheckLogin(TaiKhoan tk)
        {
            if (tk.TenTaiKhoan == "")
            {
                return "Vui lòng nhập tên tài khoản";
            }
            if (tk.MatKhau == "")
            {
                return "Vui lòng nhập mật khẩu";
            }
            return tkAccess.CheckLogin(tk);
        }
        public string  themTK2(TaiKhoan tk)
        {
            if (tk.TenTaiKhoan == "")
            {
                return "vui lòng nhập tên tài khoản";
            }
            if (tk.MatKhau == "")
            {
                return "vui lòng nhập mật khẩu";
            }
            if (tk.MaQuyen == 0)
            {
                return "vui lòng Phân Quyền";
            }

            return tkAccess.themtk2(tk);
        }
        public int demTK2()
        {

            return tkAccess.demTK2();
        }
        public string DoiPass(string tentk, string matKhauMoi,string matkhaucu,string xacnhanmk,string xacnhan)
        {
            if (matkhaucu == "")
            {
                return "Vui lòng nhập mật khẩu cũ";
            }
            if (matKhauMoi == "")
            {
                return "Vui lòng nhập mật khẩu mới";
            }
            if (xacnhan == "")
            {
                return "Vui lòng xác nhận lại mật khẩu";
            }
            if (matKhauMoi != xacnhan)
            {
                return "Mật khẩu xác nhận không khớp";
            }

            if (matkhaucu !=  xacnhanmk)
            {
                return "Nhập sai mật khẩu cũ";
            }
            return tkAccess.DoiPass(tentk, matKhauMoi);
        }

        public int CheckLogin2(TaiKhoan tk)
        {

            return tkAccess.CheckLogin2(tk);
        }

        public string CheckQuyen(int maquyen)
        {
            return quyenAccess.CheckQuyen(maquyen);
        }
        public DataTable loadTK2()
        {
            return tkAccess.loadTK2();
        }
        public DataTable loadTKT2( string matk)
        {
            if(matk == "")
            {

            }
            return tkAccess.loadTKT2(matk);
        }
        public string suaTK2(TaiKhoan tk)
        {
            if (tk.TenTaiKhoan == "")
            {
                return "vui lòng nhập tên tài khoản";
            }
            if (tk.MatKhau == "")
            {
                return "vui lòng nhập mật khẩu";
            }
            if (tk.MaQuyen == 0)
            {
                return "vui lòng Phân Quyền";
            }
            return tkAccess.suaTK2(tk);
        }
        public string checkTKT2(string matk)
        {
            if (matk == "")
            {
                return "Bạn chưa nhập mã tài khoản";
            }
            return tkAccess.checkTKT2(matk);
        }
        public string xoaTK2(string matk)
        {
            return tkAccess.xoaTK2(matk);
        }
        public string loadMTK2()
        {
            return tkAccess.loadMTK2();
        }
    }
}
