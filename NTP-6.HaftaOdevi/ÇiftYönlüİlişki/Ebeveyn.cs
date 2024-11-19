using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Ebeveyn
    {
        public List<Cocuk> Cocuklar { get; set; }
        public int Yas { get; set; }
        public string ad { get; set; }

        public Ebeveyn(int yas,string Ad)
        {
           Yas = yas;
            ad = Ad;
            Cocuklar = new List<Cocuk>();   
        }
        public void CocukEkle(Cocuk cocuk)
        {
            Cocuklar.Add(cocuk);
            cocuk.Ebeveyn = this;
        }
    }
}
