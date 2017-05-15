using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class ChiTiet_TruyCapBUS
    {
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

    }
}
