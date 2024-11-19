using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYönlüİlişki
{
    public class Çalışan
    {
        public string ad { get; set; }
        public string pozisyon { get; set; }
        public Departman Departman { get; set; }



        public void DepartmanAtama( Departman departman)
        {
           Departman = departman;
        }

    }
 
}
