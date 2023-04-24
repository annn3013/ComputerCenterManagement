using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class gdBLL
    {
        gdAccess c  = new gdAccess();
        public string themGD2(string a, string b)
        {
            return c.themGD2(a, b);
        }
        public string xoaGD2(string a, string b)
        {
            if (a == "")
            {
                return "vui lòng nhập mã giáo viên";
            }
            if (b == "")
            {
                return "vui lòng nhập tên giáo viên";
            }
            return c.xoaGD2(a, b);
        }
        public DataTable timGD2(string b)
        {
            return c.timGD2(b);
        }
        public DataTable loadGD2()
        {
            return c.loadGD2();
        }
    }
}
