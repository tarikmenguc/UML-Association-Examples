using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ÇiftYönlüİlişki
{
    public class Kitap
    {
        public Yazar yazar { get; set; }
        public DateTime YayınTarihi { get; set; }
        public string Baslik { get; set; }

        public Kitap(string baslik,DateTime yayintarihi)
        {
            Baslik = baslik;
            YayınTarihi = yayintarihi;

        }
        public void YazarAtama(Yazar Yazar)
        {
            Yazar = yazar;
            yazar.KitapEkle(this);
        }


    }
   
}
