using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Bileşim_
{
    public class Bilgisayar
    {
        public string Model { get; set; }
        public İslemci Islemci { get; private set; }

        public Bilgisayar(string model)
        {
            Model = model;
        }

        public void IslemciOlustur(int cekirdekler, int frekans)
        {
            Islemci = new İslemci(cekirdekler, frekans);
        }
    }
}
