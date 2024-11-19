using CiftYonluIliski;
using System.Collections.Generic;
using System;

public class Doktor
{
    public string Ad { get; set; }
    public string Brans { get; set; }
    public List<Hasta> Hastalar { get; private set; }

    public Doktor(string ad, string brans)
    {
        Ad = ad;
        Brans = brans;
        Hastalar = new List<Hasta>(); // Liste başlatılır
    }

    public void HastaEkle(Hasta hasta)
    {
        if (!Hastalar.Contains(hasta))
        {
            Hastalar.Add(hasta);
            hasta.DoktorAtama(this); // Hastaya da doktor atanır
        }
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Doktor: {Ad}, Branş: {Brans}");
        Console.WriteLine("Hastaları:");
        foreach (var hasta in Hastalar)
        {
            Console.WriteLine($"- {hasta.Ad}, TC: {hasta.TCNo}");
        }
    }
}