using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Bileşim_
{
    public class Otomobil
    {
        public string Marka { get; set; }
        public Motor Motor { get; private set; }

        public Otomobil(string marka)
        {
            Marka = marka;
        }

        public void MotorOlustur(int guc, string tip)
        {
            Motor = new Motor(guc, tip);
        }
    }
}
