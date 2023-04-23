using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public class tkAccess:DbAccess
    {
        public string CheckLogin(TaiKhoan tk)
        {
            string info = CheckLoginData(tk);
            return info;
        }
        public string themtk2(TaiKhoan tk)
        {
            string info = themTK( tk);
            return info;
        }
        
        public int demTK2()
        {
            return demTK();
        }
        public DataTable loadTKT2(string matk)
        {
            return loadTKT(matk);
        }
        public string suaTK2(TaiKhoan tk)
        {
            return suaTK(tk);
        }
        public string checkTKT2(string matk)
        {
            return checkTKT(matk);
        }
        public int CheckLogin2(TaiKhoan tk)
        {
            int info = CheckLoginData2(tk);
            return info;
        }
        public string xoaTK2(string matk)
        {
            return xoaTK(matk);
        }
        public string loadMTK2()
        {
            return LoadMTK();
        }
        public string DoiPass(string tentk, string matKhauMoi) 
        {
            string info= doiMK(tentk, matKhauMoi);
            return info;
        }
        public DataTable loadTK2()
        {
            return loadTK();
        }
    }
}
