using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Yazar
    {
        public string ad { get; set; }
        public string ülke { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public Yazar(string Ad ,string Ülke )
        {
            ad = Ad;
            ülke=Ülke;
            Kitaplar = new List<Kitap>();
        }
        public void KitapEkle(Kitap kitap)
        {
         
            Kitaplar.Add(kitap);
            kitap.yazar = this;
        }
    }
}
