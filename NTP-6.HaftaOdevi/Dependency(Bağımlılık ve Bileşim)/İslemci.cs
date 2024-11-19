using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Bileşim_
{
    public class İslemci
    {
        public int Cekirdekler { get; set; }
        public int Frekans { get; set; }

        public İslemci(int cekirdekler, int frekans)
        {
            Cekirdekler = cekirdekler;
            Frekans = frekans;
        }

        public string IslemciBilgisi()
        {
            return $"Çekirdekler: {Cekirdekler}, Frekans: {Frekans} MHz";
        }
    }
}

