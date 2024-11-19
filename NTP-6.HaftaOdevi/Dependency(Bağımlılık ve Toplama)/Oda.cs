using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Oda
    {
        public string Tip { get; set; }
        public string Boyut { get; set; }

        public Oda(string tip ,string boyut)
        {
                Tip = tip;
            Boyut = boyut;
        }
    }
}
