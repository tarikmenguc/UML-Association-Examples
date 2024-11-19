using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Toplama_
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar{ get; set; }
        public string ad { get; set; }

        public Kutuphane(string Ad)
        {
            ad = Ad;    
        }
        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }
}
