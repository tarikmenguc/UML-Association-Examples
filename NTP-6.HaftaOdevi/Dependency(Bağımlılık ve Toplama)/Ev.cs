using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ÇiftYönlüİlişki
{
    public class Ev
    { 
        public List<Oda> Odalar { get; set; }
        public string Ad { get; set; }

        public Ev(string ad)
        {
            Ad = ad;
            Odalar = new List<Oda>();
        }
        public void OdaEkle(Oda oda)
        {
            Odalar.Add(oda);

        }

    }
}
