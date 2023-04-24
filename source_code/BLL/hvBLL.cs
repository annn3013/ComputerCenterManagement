using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace BLL
{
    public  class hvBLL
    {
        hvAccess a = new hvAccess();
        public string themHV2(HocVien hv)
        {
            if (hv.HoTen == "")
            {
                return "Vui lòng nhập họ tên học viên";
            }
            if (hv.GioiTinh == "")
            {
                return "Vui lòng chọn giới tính";
            }
            if (hv.NgheNghiep == "")
            {
                return "Vui lòng nhập nghề nghiệp";
            }
            if (hv.DiaChi  == "")
            {
                return "Vui lòng nhập địa chỉ";
            }

            if (!int.TryParse(hv.Sdt, out int sdt))
            {
                return "Vui lòng nhập số điện thoại";
            }

            return a.themHV2(hv);
        }
        public string LayMaCuoi2()
        {
            return a.LayMaCuoi2();
        }
        public DataTable loadHV2()
        {
            return a.LoadHV2();
        }
        public DataTable LoadTHV2(string hoten)
        {
            return a.LoadTHV2(hoten);
        }
        public DataTable loadHVT2(string matk)
        {
            return a.LoadHVT2(matk);
        }
        public DataTable loadTHV2(string matk)
        {
            return a.LoadTHV2(matk);
        }
        public string TimHocVien2(string mahv)
        {
            if (mahv =="")
            {
                return "vui lòng nhập mã học viên để tìm kiếm";
            }
            return a.TimHocVien2(mahv);

        }
        public string capNhatHV2(HocVien hv)
        {
            if (hv.HoTen == "")
            {
                return "Vui lòng nhập họ tên học viên";
            }
            if (hv.GioiTinh == "")
            {
                return "Vui lòng chọn giới tính";
            }
            if (hv.NgheNghiep == "")
            {
                return "Vui lòng nhập nghề nghiệp";
            }
            if (hv.DiaChi == "")
            {
                return "Vui lòng nhập địa chỉ";
            }

            if (!int.TryParse(hv.Sdt, out int sdt))
            {
                return "Vui lòng nhập số điện thoại";
            }
            return a.capNhatHV2(hv);
        }
        public string xoaHV2(string mahv)
        {
            return a.xoaHV2(mahv);
        }
        public string TimHocVienT2(string tenhv)
        {
            return a.TimHocVienT2(tenhv);
        }

    }
}
