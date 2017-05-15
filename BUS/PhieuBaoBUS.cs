using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class PhieuBaoBUS
    {
        QLDKSDIDataContext db = new QLDKSDIDataContext();
        public List<PhieuBao> load()
        {
            return db.PhieuBaos.ToList();
        }
        public string sinhMaTuDong()
        {
            var q = (from u in db.PhieuBaos
                     orderby u.MaPhieu descending
                     select u);
            PhieuBao pb = q.FirstOrDefault();
            string st;
            st = (pb == null)? "":pb.MaPhieu.ToString();
            if (st == null || st == "")
            {
                return "PB0001";
            }
            else
            {
                int i = int.Parse(st.Substring(2));
                i += 1;
                if (i < 10)
                    return "PB000" + i.ToString();
                else if (i >= 10 && i < 100)
                    return "PB00" + i.ToString();
                else if (i >= 100 && i < 1000)
                    return "PB0" + i.ToString();
                else
                    return "PB" + i.ToString();
            }

        }
        public void lapPhieuBaoTuDong()
        {
                DateTime HienTai = DateTime.Now;
                var queryTK = from u in db.TaiKhoans
                              where Convert.ToBoolean(u.TrangThai) == true
                              select u;
                foreach (var x in queryTK)
                {
                    var query = from u in db.PhieuBaos
                                where x.TenTruyCap == u.TenTruyCap && Convert.ToInt32(u.ThangLap) == HienTai.Month
                                select u;
                    if (!query.Any())
                    {
                        PhieuBao item = new PhieuBao();
                        item.MaPhieu = sinhMaTuDong();
                        item.TenTruyCap = x.TenTruyCap;
                        item.NgayLap = HienTai;
                        item.ThangLap = HienTai.Month.ToString();
                        item.TinhTrang = Convert.ToBoolean(false);
                        item.NgayTT = null;
                        item.HinhThucTT = null;
                        item.TongTien = 0;
                        db.PhieuBaos.InsertOnSubmit(item);
                        db.SubmitChanges();
                    }
                 }
            
        }
        public void tinhCuocPhiTuDong()
        {

            DateTime HienTai = DateTime.Now;
            if (HienTai.Day == 15)
            {
                var queryPB = from u in db.PhieuBaos
                              where Convert.ToDateTime(u.NgayLap).Month == (HienTai.Month -1) &&
                                      Convert.ToDateTime(u.NgayLap).Year == HienTai.Year
                              select u;
                foreach (var x in queryPB)
                {
                    var queryChiTiet = from u in db.ChiTiet_TruyCaps
                                       group u by new
                                       {
                                           u.MaPhieu,
                                           u.MaLoai
                                       } into grp
                                       where grp.Key.MaPhieu == x.MaPhieu
                                       select new
                                       {
                                           MaPhieu = grp.Key.MaPhieu,
                                           MaLoai = grp.Key.MaLoai,
                                           TongSoPhut = grp.Sum(g => g.TongSoPhut)
                                       };
                    foreach (var y in queryChiTiet)
                    {
                        LoaiTG_TruyCap loai = new LoaiTG_TruyCap();
                        var queryLoaiTG = from u in db.LoaiTG_TruyCaps
                                          where u.MaLoai == y.MaLoai
                                          select u;
                        if (queryLoaiTG.Any()) loai = queryLoaiTG.FirstOrDefault();
                        x.TongTien += (y.TongSoPhut * loai.Gia);
                        x.NgayLap = DateTime.Now;
                        db.SubmitChanges();
                    }
                                                     
                 }
            }
        }
      }
}