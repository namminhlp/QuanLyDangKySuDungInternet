using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        QLDKSDIDataContext db = new QLDKSDIDataContext();
        public TaiKhoanBUS()
        {
            
        }
        public bool checkDangNhap (string strTK, string strMK)
        {
               var query = from u in db.TaiKhoans
                            where u.TenTruyCap == strTK && u.MatKhau == strMK
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

        public List<TaiKhoan> load()
        {
            return db.TaiKhoans.ToList();
        }

        public bool themTaiKhoan(string TenTruyCap, string Matkhau, string MaHD, string Email, string DCCD, string DCTT, string TrangThai)
        {
            if (TenTruyCap == "" || Matkhau == "" || MaHD == "" || Email == "" 
                || DCCD == "" || DCTT == "" || TrangThai == null || TrangThai == ""
                || TenTruyCap.Length <= 6)
            {
                return false;
            }
            else
            {
                // Tìm trong tài khoản có chưa, nếu có rồi thì thôi
                var query = from u in db.TaiKhoans
                            select u;
                if (query.Any())
                {
                    var queryTK = from u in db.TaiKhoans
                                  where u.TenTruyCap == TenTruyCap || u.Email == Email
                                  select u;
                    if (queryTK.Any())
                    {
                        return false;
                    }
                    else
                    {
                        var queryHD = from u in db.HopDongs
                                      where u.MaHD == MaHD
                                      select u;
                        if (queryHD.Any())
                        {
                            TaiKhoan tk = new TaiKhoan();
                            tk.TenTruyCap = TenTruyCap;
                            tk.MatKhau = Matkhau;
                            tk.Email = Email;
                            tk.TrangThai = Convert.ToBoolean(TrangThai);
                            tk.MaHD = MaHD;
                            tk.DiaChiCaiDat = DCCD;
                            tk.DiaChiThanhToan = DCTT;
                            db.TaiKhoans.InsertOnSubmit(tk);
                            db.SubmitChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
             
            }
        }

        public bool suaTaiKhoan(string TenTruyCap, string Matkhau, string MaHD, string Email, string DCCD, string DCTT,string TrangThai)
        {
            try
            {
                TaiKhoan tk = db.TaiKhoans.Single(x => x.TenTruyCap == TenTruyCap);
                tk.TenTruyCap = TenTruyCap;
                tk.MatKhau = Matkhau;
                tk.MaHD = MaHD;
                tk.Email = Email;
                tk.DiaChiCaiDat = DCCD;
                tk.DiaChiThanhToan = DCTT;
                tk.TrangThai = Convert.ToBoolean(TrangThai);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                db.SubmitChanges();
                return false;
            }
        }

        public bool xoaTaiKhoan(string TenTruyCap)
        {
            var tk = db.TaiKhoans.Single(t => t.TenTruyCap == TenTruyCap);
            try
            {
                var queryPB = from u in db.PhieuBaos
                              where u.TenTruyCap == TenTruyCap
                              select u;
                foreach ( var x in queryPB)
                {
                    db.PhieuBaos.DeleteOnSubmit(x);
                }
                db.TaiKhoans.DeleteOnSubmit(tk);
                db.SubmitChanges();
            }
            catch
            {
                db.SubmitChanges();
                return false;
            }
            return true;
        }
        public bool checkSoLuong (string MaHD)
        {
            int count = (from u in db.TaiKhoans
                         where u.MaHD == MaHD
                         select u.TenTruyCap).Count();
            var queryHD = db.HopDongs.FirstOrDefault(x => x.MaHD == MaHD);
            if ( count < Convert.ToInt32(queryHD.TongTK)) return true;
            else return false;

        }
        public List<TaiKhoan> xemChuaKichHoat ()
        {
            var query = (from u in db.TaiKhoans
                         select u);
            List<TaiKhoan> lsTaiKhoan = new List<TaiKhoan>();
            lsTaiKhoan = query.Where(u => Convert.ToBoolean(u.TrangThai) == false ).ToList();
            return lsTaiKhoan;
        }
        public List<TaiKhoan> timTaiKhoan (string TenTruyCap)
        {
            var query = from u in db.TaiKhoans
                        where u.TenTruyCap == TenTruyCap
                        select u;
            return query.ToList();
        }
        
    }
}
