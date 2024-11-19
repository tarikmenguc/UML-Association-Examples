using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Cocuk
    {
        public Ebeveyn Ebeveyn { get; set; }
        public int Yas { get; set; }
        public string ad { get; set; }

        public Cocuk(int yas,string Ad)
        {
            Yas = yas;
            ad = Ad;
        }

        public void EbevynAtama(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
            ebeveyn.CocukEkle(this);
        }
    }
}
