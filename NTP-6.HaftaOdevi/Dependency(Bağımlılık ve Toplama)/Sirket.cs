using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Toplama_
{
    public class Sirket
    {
        public string ad { get; set; }
        public List<Calisan> Calisanlar { get; set; }

        public Sirket(string Ad)
        {
            ad = Ad;
        }
        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);

        }


    }
}
