using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Bağımlılık_ve_Bileşim_
{
    public class Motor
    {
        public int Guc { get; set; }
        public string Tip { get; set; }

        public Motor(int guc, string tip)
        {
            Guc = guc;
            Tip = tip;
        }

        public string MotorBilgisi()
        {
            return $"Güç: {Guc} HP, Tip: {Tip}";
        }
    }
}
