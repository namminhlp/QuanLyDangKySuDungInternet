using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class NhanVienBUS
    {
        QLDKSDIDataContext db = new QLDKSDIDataContext();
        public List<NhanVien> load()
        {
            return db.NhanViens.ToList();
        }
        public bool checkDangNhap(string strTK, string strMK)
        {
                 var query = from u in db.NhanViens
                             where u.TenTruyCap == strTK && u.MatKhau == strMK && Convert.ToBoolean(u.QuyenHan) == true
                             select u;
                 if (query.Any())
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
        }
    }
}
