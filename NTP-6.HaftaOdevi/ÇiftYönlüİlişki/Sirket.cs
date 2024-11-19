using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Sirket
    { 
     public List<Calisan> Calisanlar { get; set; }
    public string Konum { get; set; }
    public string ad { get; set; }

        public Sirket(string konum,string Ad)
        {
            ad = Ad;
            Konum = konum;
            Calisanlar = new List<Calisan>();
        }
        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
            calisan.sirketi = this;
        }



    }
}
