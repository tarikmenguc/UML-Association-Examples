using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Bileşim_
{
    public class Okul
    {
        public string Ad { get; set; }
        public List<Ögrenci> Ogrenciler { get; private set; }

        public Okul(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ögrenci>();
        }

        public void OgrenciEkle(Ögrenci ogrenci)
        {
            Ogrenciler.Add(ogrenci);
        }
    }
}
