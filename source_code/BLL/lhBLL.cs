using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System;
using System.Data;

namespace BLL
{
    
    public  class lhBLL
    {
        lhAccess a = new lhAccess();
        public string themLH2(LopHoc lh)
        {
            if (lh.TenLopHoc == "")
            {
                return "Vui Lòng Nhập Tên Lớp học";
            }
            string sisoStr = lh.SiSo;
            int siso;

            if (int.TryParse(sisoStr, out siso))
            {
                if (siso <= 0)
                {
                    return "Sĩ số phải lớn hơn 0, vui lòng nhập lại";
                }
            }
            else
            {
                return "Vui lòng nhập giá trị hợp lệ cho sĩ số";
            }
            if (lh.MaPhongHoc == "")
            {
                return "vui lòng nhập mã phòng học";
            }
            if (lh.CaHoc == "")
            {
                return "vui lòng nhập ca học";
            }
            string caHocStr = lh.CaHoc;
            int caHoc;

            if (int.TryParse(caHocStr, out caHoc))
            {
                if(caHoc<=0 || caHoc > 5)
                {
                    return "Chỉ có các ca học 1-5 , vui lòng chọn lại";
                }
            }
            else
            {
                return " vui lòng nhập đúng giá trị cho ca học";

            }
            if (lh.MaPhongHoc == "")
            {
                return " Vui lòng nhập mã phòng học";
            }
            int compareResult = DateTime.Compare(lh.NgayBatDau, lh.NgayKetThuc);
            if(compareResult >= 0)
            {
                return "Ngày bắt đầu phải lớn hơn ngày kết thúc";
            }

            return a.themLH2(lh);
        }
        public string suaLH2(LopHoc lh)
        {
            if (lh.TenLopHoc == "")
            {
                return "Vui Lòng Nhập Tên Lớp học";
            }
            string sisoStr = lh.SiSo;
            int siso;

            if (int.TryParse(sisoStr, out siso))
            {
                if (siso <= 0)
                {
                    return "Sĩ số phải lớn hơn 0, vui lòng nhập lại";
                }
            }
            else
            {
                return "Vui lòng nhập giá trị hợp lệ cho sĩ số";
            }
            if (lh.MaPhongHoc == "")
            {
                return "vui lòng nhập mã phòng học";
            }
            if (lh.CaHoc == "")
            {
                return "vui lòng nhập ca học";
            }
            string caHocStr = lh.CaHoc;
            int caHoc;

            if (int.TryParse(caHocStr, out caHoc))
            {
                if (caHoc <= 0 || caHoc > 5)
                {
                    return "Chỉ có các ca học 1-5 , vui lòng chọn lại";
                }
            }
            else
            {
                return " vui lòng nhập đúng giá trị cho ca học";

            }
            if (lh.MaPhongHoc == "")
            {
                return " Vui lòng nhập mã phòng học";
            }
            int compareResult = DateTime.Compare(lh.NgayBatDau, lh.NgayKetThuc);
            if (compareResult >= 0)
            {
                return "Ngày bắt đầu phải lớn hơn ngày kết thúc";
            }
            return a.suaLH2(lh);
        }
        public string xoaLH2(string maLopHoc)
        {
            return a.xoaLH2(maLopHoc);
        }
        public DataTable loadLH2()
        {
            return a.loadLH2();
        }
        public DataTable loadLHC2()
        {
            return a.loadLHC2();
        }
        public DataTable loadLHT2(string malh) {
            return a.loadLHT2(malh);
        }
        public string layMa2()
        {
            return a.layMa2();
        }
        public string autoLH2()
        {
            return a.autoLH2();
        }
        public string checkLH2(string b)
        {
            if (b == "")
            {
                return "vui lòng nhập mã lớp";
            }
            return a.checkLH2(b);
        }
        public DataTable loadLHDK2(string b)
        {
            return a.loadLHDK2(b);
        }


    }
}
