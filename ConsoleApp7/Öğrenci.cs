using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Öğrenci
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public float NotOrtalamasi { get; set; }
        public List<int> Notlar { get; set; }
        public OgrenciKayit()
        {
            NotOrtalamasi = 0;
        }
        public void OrtalamaHesapla()
        {
            float toplam = 0;
            for (int i = 0; i < Notlar.Count; i++)
            {
                toplam += Notlar[i];
            }
            NotOrtalamasi = toplam / Notlar.Count;
        }
        public void NotEkle(int not)
        {
            Notlar.Add(not);
        }
    }
}
