using System;
using System.Collections.Generic;

namespace CiftYonluIliski
{
    public class Hasta
    {
        public string TCNo { get; set; }
        public string Ad { get; set; }
        public Doktor Doktor { get; private set; } // Atanan doktor bilgisi

        public Hasta(string tcNo, string ad)
        {
            TCNo = tcNo;
            Ad = ad;
        }

        public void DoktorAtama(Doktor doktor)
        {
            // Mevcut doktordan kaldırma
            if (Doktor != null)
            {
                Doktor.Hastalar.Remove(this);
            }

            // Yeni doktor ile ilişkilendirme
            Doktor = doktor;
            if (doktor != null && !doktor.Hastalar.Contains(this))
            {
                doktor.HastaEkle(this); // Doktorun hasta listesine eklenir
            }
        }

        public void BilgiGoster()
        {
            Console.WriteLine($"Hasta: {Ad}, TC: {TCNo}");
            if (Doktor != null)
            {
                Console.WriteLine($"Atanan Doktor: {Doktor.Ad}, Branş: {Doktor.Brans}");
            }
            else
            {
                Console.WriteLine("Atanan doktor yok.");
            }
        }
    }

   

 
}

