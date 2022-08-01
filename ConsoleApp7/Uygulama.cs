using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Uygulama
    {
        public void calistir()
        {
            List<OgrenciKayit> ogrenciler = new List<OgrenciKayit>();
            OgrenciKayit ogr = new OgrenciKayit();
            public void Calistir()
            {
                Menu();
                while (true)
                {
                    string secim = Secim();
                    switch (secim)
                    {
                        case "1":
                        case "L":
                        case "l":
                            OgrenciListele();
                            break;
                        case "2":
                        case "E":
                        case "e":
                            OgrenciEkle();
                            break;
                        case "3":
                        case "S":
                        case "s":
                            OgrenciSil();
                            break;
                        case "4":
                        case "N":
                        case "n":
                            NotEkle();
                            break;
                        case "5":
                        case "X":
                        case "x":
                            return;
                        default:
                            Console.WriteLine("Hatalı giriş. Lütfen tekrar deneyiniz.");
                            break;
                    }
                }
            }
            public void Menu()
            {
                Console.WriteLine("-------Öğrenci Kayıt Uygulaması-------");
                Console.WriteLine("1- Öğrencileri Listele (L)");
                Console.WriteLine("2- Öğrenci Ekle (E)");
                Console.WriteLine("3- Öğrenci Sil (S)");
                Console.WriteLine("4- Not Gir (N)");
                Console.WriteLine("5- Çıkış (X)");
                Console.WriteLine();
            }
            public string Secim()
            {
                Console.Write("Yapmak istediğiniz işlem kodunu girin: ");
                return Console.ReadLine();
            }
            public void OgrenciEkle()
            {
                Console.WriteLine("Öğrenci Ekle");
                int no;
                bool OgrenciSistemdeKayitliMi;
                do
                {
                    OgrenciSistemdeKayitliMi = false;
                    Console.Write("No:");
                    no = int.Parse(Console.ReadLine());
                    for (int i = 0; i < ogrenciler.Count; i++)
                    {
                        if (ogrenciler[i].No == 0)
                        {
                            OgrenciSistemdeKayitliMi = true;
                            Console.WriteLine("Bu numaraya ait bir öğrenci sistemde
                           kayıtlı.Başka bir numara girin.");
                        }
                    }
                } while (OgrenciSistemdeKayitliMi);
                ogr.No = no;
                Console.Write("Ad:");
                ogr.Ad = Console.ReadLine();
                Console.Write("Soyadı:");
                ogr.Soyad = Console.ReadLine();
                Console.Write("TC No:");
                ogr.TcNo = Console.ReadLine();
                Console.WriteLine("Öğrenci başarılı bir şekilde eklendi.");
                ogrenciler.Add(ogr);
                Console.WriteLine();
            }
            public void OgrenciListele()
            {
                Console.WriteLine("No" + " " + "Adı Soyadı" + " " +
               "Tc Kimlik No" + " " + "Not Ortalaması");
                Console.WriteLine("------------------------------------------------------------------
                ---------- - ");
            for (int i = 0; i < ogrenciler.Count; i++)
                {
                    Console.WriteLine(ogrenciler[i].No + " " + ogrenciler[i].Ad +
                   " " + ogrenciler[i].Soyad + " " + ogrenciler[i].TcNo + " " +
                   ogrenciler[i].NotOrtalamasi);
                }
            }
            public void OgrenciSil()
            {
                Console.WriteLine("Öğrenci Sil");
                bool OgrenciSistemdeKayitliMi;
                do
                {
                    OgrenciSistemdeKayitliMi = false;
                    Console.Write("Silmek istediğiniz öğrenci no: ");
                    int no = int.Parse(Console.ReadLine());
                    for (int i = 0; i < ogrenciler.Count; i++)
                    {
                        if (ogrenciler[i].No == no)
                        {
                            OgrenciSistemdeKayitliMi = true;
                            ogrenciler.Remove(ogrenciler[i]);
                            Console.WriteLine("Öğrenci başarılı bir şekilde silindi.");
                        }
                    }
                    if (!OgrenciSistemdeKayitliMi)
                    {
                        Console.WriteLine("Girdiğiniz numaraya ait bir öğrenci sistemde bulunamadı.Başka bir numara girin. ");

                    }
                } while (!OgrenciSistemdeKayitliMi);
                Console.WriteLine();
            }
            public void NotEkle()
            {
                Console.WriteLine("Not Ekle");
                int no;
                bool OgrenciSistemdeKayitliMi;
                do
                {
                    OgrenciSistemdeKayitliMi = false;
                    Console.Write("Not eklemek istediğiniz öğrenci no: ");
                    no = int.Parse(Console.ReadLine());
                    for (int i = 0; i < ogrenciler.Count; i++)
                    {
                        if (ogrenciler[i].No == 0)
                        {
                            OgrenciSistemdeKayitliMi = true;
                            Console.Write("Eklenecek not adedi: ");
                            int adet = int.Parse(Console.ReadLine());
                            for (int j = 0; j < adet; j++)
                            {
                                Console.WriteLine((i + 1) + ".Not:");
                                int not = int.Parse(Console.ReadLine());
                                ogrenciler[i].NotEkle(not);
                            }
                            ogrenciler[i].OrtalamaHesapla();
                            Console.WriteLine("Notlar başarılı bir şekilde eklendi.");
                        }
                    }
                    if (!OgrenciSistemdeKayitliMi)
                    {
                        Console.WriteLine("Girdiğiniz numaraya ait bir öğrenci sistemde bulunamadı.Başka bir numara girin. ");

                    }
                } while (!OgrenciSistemdeKayitliMi);
                Console.WriteLine();

            }
        }
    }
