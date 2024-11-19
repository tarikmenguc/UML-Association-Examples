using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekYönlüİlişki
{
    public class Ürün
    {
        public string ad { get; set; }
        private  int fiyat { get; set; }

        public void ÜrünBilgisi(Sipariş sipariş)
        {
            Console.WriteLine($"{fiyat} {ad} {sipariş.Toplam} {sipariş.Tarih}");
        }

    }
}
