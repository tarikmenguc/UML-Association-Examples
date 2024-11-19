using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Toplama_
{
    public class Calisan
    {
        public  string pozisyon { get; set; }
        public string ad { get; set; }

        public Calisan(string Ad ,string Pozisyon)
        {
            ad = Ad;
            pozisyon = Pozisyon;
        }

        public void CalisanBilgisi()
        {
            Console.WriteLine($"Çalişan adı: {ad} ve Çalışan pozisyonu {pozisyon}");
        }
    }
}
