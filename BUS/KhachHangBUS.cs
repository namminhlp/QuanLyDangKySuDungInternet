using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class KhachHangBUS
    {
        QLDKSDIDataContext db = new QLDKSDIDataContext();
        public List<KhachHang> load()
        {
            return db.KhachHangs.ToList();
        }
        public string sinhMaTuDong()
        {
            var q = (from u in db.KhachHangs
                     orderby u.MaKH descending
                     select u);
            KhachHang kh = q.FirstOrDefault();
            string st;
            st = (kh == null) ? "" : kh.MaKH.ToString();
            if (st == null || st == "")
            {
                return "KH0001";
            }
            else
            {
                int i = int.Parse(st.Substring(2));
                i += 1;
                if (i < 10)
                    return "KH000" + i.ToString();
                else if (i >= 10 && i < 100)
                    return "KH00" + i.ToString();
                else if (i >= 100 && i < 1000)
                    return "KH0" + i.ToString();
                else
                    return "KH" + i.ToString();
            }

        }
        public bool themKhachHang(string MaKH, string HoTen, string DiaChi, string CMND, string LoaiKH, string SoDT)
        {
            if (MaKH == "" || HoTen == "" || DiaChi == "" || CMND == "" || LoaiKH == "" || SoDT == "")
            {
                return false;
            }
            else
            {
                var query = from u in db.KhachHangs
                            select u;
                if (query.Any())
                {
                    var queryKH = from u in db.KhachHangs
                                  where u.MaKH == MaKH || u.HoTen == HoTen || u.CMND == CMND
                                  select u;
                    if (queryKH.Any())
                    {
                        return false;
                    }
                    else
                    {
                        KhachHang kh = new KhachHang();
                        kh.MaKH = MaKH;
                        kh.HoTen = HoTen;
                        kh.DiaChi = DiaChi;
                        kh.CMND = CMND;
                        kh.LoaiKH = LoaiKH;
                        kh.SoDT = int.Parse(SoDT);
                        db.KhachHangs.InsertOnSubmit(kh);
                        db.SubmitChanges();
                        return true;
                    }
                }
                else
                {
                    KhachHang kh = new KhachHang();
                    kh.MaKH = MaKH;
                    kh.HoTen = HoTen;
                    kh.DiaChi = DiaChi;
                    kh.CMND = CMND;
                    kh.LoaiKH = LoaiKH;
                    kh.SoDT = int.Parse(SoDT);
                    db.KhachHangs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    return true;
                }
            }
        }

        public bool suaKhachHang (string MaKH, string HoTen, string DiaChi, string CMND, string LoaiKH, int SoDT)
        {
            try
            {
                KhachHang kh = db.KhachHangs.Single(x => x.MaKH == MaKH);
                kh.HoTen = HoTen;
                kh.DiaChi = DiaChi;
                kh.CMND = CMND;
                kh.LoaiKH = LoaiKH;
                kh.SoDT = SoDT;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                db.SubmitChanges();
                return false;
            }
        }

        public bool xoaKhachHang(string MaKH)
        {
            var queryKH = from u in db.KhachHangs
                     where u.MaKH == MaKH
                     select u;
            try
            {
                var queryHD = from u in db.HopDongs
                              where u.MaKH == MaKH
                              select u;
                if (queryHD.Any())
                {
                    return false;
                }
                else
                {
                    foreach (var x in queryKH)
                    {
                        db.KhachHangs.DeleteOnSubmit(x);
                         db.SubmitChanges();
                    }
                }

            }
            catch
            {
                return false;
            }
            return true;
        }
        public List<KhachHang> timKhachHang(string MaKH)
        {
            var queryKH = from u in db.KhachHangs
                          where u.MaKH == MaKH
                          select u;
            return queryKH.ToList();
        }
    }
}
