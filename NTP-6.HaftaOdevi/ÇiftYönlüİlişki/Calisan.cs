using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Calisan
    {
        public Sirket sirketi { get; set; }
        public string pozisyon { get; set; }
        public string ad { get; set; }

        public Calisan(string Pozisyon ,string Ad)
        {
            pozisyon = Pozisyon;
            ad = Ad;
         
        }
        public void SirketAtama(Sirket sirket)
        {
            sirketi = sirket;
            sirket.CalisanEkle(this);
        }
    }
}
