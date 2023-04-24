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
    public  class blBLL
    {
        blAccess a = new blAccess();
        public string themBL2(BienLai bl)
        {
            if (bl.MaHocVien == "")
            {
                return "vui lòng nhập Mã Học Viên";
            }
            if (bl.TenNguoiDong == "")
            {
                return "vui lòng nhập tên người đóng";
            }
            if (bl.SoTien == 0)
            {
                return "Vui lòng nhập đúng số tiền cần đóng";
            }
            
            return a.themBL2(bl);
        }
        public string xoaBL2(string id)
        {
            return a.xoaBL2(id);
        }
        public string suaBL2(BienLai bl)
        {
            if (bl.MaHocVien == "")
            {
                return "vui lòng nhập Mã Học Viên";
            }
            if (bl.TenNguoiDong == "")
            {
                return "vui lòng nhập tên người đóng";
            }
            if (bl.SoTien == 0)
            {
                return "Vui lòng nhập đúng số tiền cần đóng";
            }
            return a.suaBL2(bl);
        }
        public DataTable loadBL2()
        {
            return a.loadBL2();
        }
        public DataTable loadBLT2(string mahv)
        {
            return a.loadBLT2(mahv);
        }
        public string autoBL2()
        {
            return a.autoBL2();
        }
        public string CheckBL2(string mahv)
        {
            return a.CheckBL2(mahv);
        }
        public string CheckMBL2(string id)
        {
            if (id == "")
            {
                return "Vui lòng nhập mã biên lai";
            }
            return a.CheckMBL2(id);
        }
        public DataTable loadBLID2(string id)
        {
            return a.loadBLID2(id);
        }
    }
}
