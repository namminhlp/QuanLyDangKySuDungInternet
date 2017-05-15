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
        public string sinhMaTuDong(string st)
        {

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
        public List<ChiTiet_TruyCap> lapPhieuBaoTuDong()
        {
            return null;
        }
    }
}
