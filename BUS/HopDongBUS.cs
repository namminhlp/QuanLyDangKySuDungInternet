using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class HopDongBUS
    {
        QLDKSDIDataContext db = new QLDKSDIDataContext();
        public List<HopDong> load()
        {
            return db.HopDongs.ToList();
        }
        public string sinhMaTuDong()
        {
            var q = (from u in db.HopDongs
                     orderby u.MaHD descending
                     select u);
            HopDong hd = q.FirstOrDefault();
            string st;
            st = (hd == null) ? "" : hd.MaHD.ToString();
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
        public bool themHopDong(string MaHD, string MaKH, string TongTK, string ChiPhi, string NgayDK)
        {
            if (MaHD == "" || MaKH == "" || TongTK == "" || ChiPhi == "" || NgayDK=="")
            {
                return false;
            }
            else
            {
                // DateTime Ngay = Convert.ToDateTime(NgayDK);
                // DateTime NgayHD = Convert.ToDateTime(NgayDKHP);
                DateTime NgayHienTai = DateTime.Now;
                DateTime tempNgayDK;
                try
                {
                   tempNgayDK = Convert.ToDateTime(NgayDK);
                }
                catch
                {
                    return false;
                }
                if (tempNgayDK > NgayHienTai)
                {
                    return false;
                }
                else
                {
                    var query = from u in db.KhachHangs
                                where u.MaKH == MaKH
                                select u;
                    if (query.Any())
                    {
                        var queryHD = from u in db.HopDongs
                                      select u;
                        if (queryHD.Any())
                        {
                            var queryHD1 = from u in db.HopDongs
                                           where u.MaHD == MaHD 
                                           select u;
                            if (queryHD1.Any())
                            {
                                return false;
                            }
                            HopDong hd = new HopDong();
                            hd.MaHD = MaHD;
                            hd.MaKH = MaKH;
                            hd.TongTK = TongTK;
                            hd.ChiPhi = int.Parse(ChiPhi);
                            hd.NgayDK = Convert.ToDateTime(NgayDK);
                            hd.NgayKyHD = null;
                            db.HopDongs.InsertOnSubmit(hd);
                            db.SubmitChanges();
                            return true;
                         }
                         else
                         {
                                HopDong hd = new HopDong();
                                hd.MaHD = MaHD;
                                hd.MaKH = MaKH;
                                hd.TongTK = TongTK;
                                hd.ChiPhi = int.Parse(ChiPhi);
                                hd.NgayDK = Convert.ToDateTime(NgayDK);
                            hd.NgayKyHD = null;
                                db.HopDongs.InsertOnSubmit(hd);
                                db.SubmitChanges();
                                return true;
                          }
                      }
                      else
                      {
                           return false;
                      }
                }
                
            }
        }

        public bool suaHopDong(string MaHD, string MaKH, string TongTK, string ChiPhi, string NgayDK, string NgayKyHD)
        {
            DateTime NgayHienTai = DateTime.Now;
            DateTime tempNgayDK, tempNgayKyHD;
            try
            {
                tempNgayDK = Convert.ToDateTime(NgayDK);
                tempNgayKyHD = Convert.ToDateTime(NgayKyHD);
            }
            catch
            {
                return false;
            }
            if (tempNgayDK > NgayHienTai || tempNgayKyHD < tempNgayDK || tempNgayKyHD > NgayHienTai)
            {
                return false;
            }
            else
            {
                try
                {
                    HopDong hd = db.HopDongs.Single(x => x.MaHD == MaHD);
                    hd.MaKH = MaKH;
                    hd.TongTK = TongTK;
                    hd.ChiPhi = int.Parse(ChiPhi);
                    hd.NgayDK = tempNgayDK;
                    hd.NgayKyHD = tempNgayKyHD;
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        public bool xoaHopDong(string MaHD)
        {
            var hd = db.HopDongs.Single(t => t.MaHD == MaHD);
            try
            {
                var query = from u in db.TaiKhoans
                            where u.MaHD == MaHD
                            select u;
                var items = query.ToList();
                foreach (var item in items)
                {
                    db.TaiKhoans.DeleteOnSubmit(item);
                }
                db.HopDongs.DeleteOnSubmit(hd);
                db.SubmitChanges();

            }
            catch
            {
                return false;
            }
            return true;

        }
        public List<HopDong> xemDanhSachCho()
        {
            var query = (from u in db.HopDongs
                         select u);
            List<HopDong> lsHopDong = new List<HopDong>();
            lsHopDong = query.Where(u => u.NgayKyHD.ToString() == "" || u.NgayKyHD == null).ToList();
            return lsHopDong;
        }
        public List<HopDong> timHopDong(string MaHD)
        {
            var query = from u in db.HopDongs
                          where u.MaHD == MaHD
                          select u;
            return query.ToList();
        }
    }
}
