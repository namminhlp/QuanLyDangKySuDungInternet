using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
   public class ChiTiet_TruyCapBUS
    {
        QLDKSDIDataContext db = new QLDKSDIDataContext();
        public string sinhMaTuDong()
        {
            var q = (from u in db.PhieuBaos
                     orderby u.MaPhieu descending
                     select u);
            PhieuBao pb = q.FirstOrDefault();
            string st;
            st = (pb == null) ? "" : pb.MaPhieu.ToString();
            if (st == null || st == "")
            {
                return "CT0001";
            }
            else
            {
                int i = int.Parse(st.Substring(2));
                i += 1;
                if (i < 10)
                    return "CT000" + i.ToString();
                else if (i >= 10 && i < 100)
                    return "CT00" + i.ToString();
                else if (i >= 100 && i < 1000)
                    return "CT0" + i.ToString();
                else
                    return "CT" + i.ToString();
            }

        }
        public List<ChiTiet_TruyCap> load()
        {
            return db.ChiTiet_TruyCaps.ToList();
        }
        public List<ChiTiet_TruyCap> xemChiTietTruyCap (string MaPhieuBao)
        {
            var query = from u in db.ChiTiet_TruyCaps
                        where u.MaPhieu == MaPhieuBao
                        select u;
            return query.ToList();
        }

    }
}
