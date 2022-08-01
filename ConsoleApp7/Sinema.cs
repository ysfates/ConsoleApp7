using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Sinema
    {
        public string Adi { get; set; }
        public int Kapasite { get; set; }
        public float TamBiletFiyatı { get; set; }
        public float YarimBiletFiyati { get; set; }
        public double Bakiye { get; set; }
        public int BosKoltukAdedi { get; set; }
        public int ToplamTamBiletAdedi { get; set; }
        public int ToplamYarimBiletAdedi { get; set; }

        public void BiletSat(int tamBiletAdedi, int yarimBiletAdedi)
        {
            this.ToplamTamBiletAdedi += tamBiletAdedi;
            this.ToplamYarimBiletAdedi += yarimBiletAdedi;

            this.BosKoltukAdedi = this.Kapasite - (this.ToplamTamBiletAdedi + this.ToplamYarimBiletAdedi);
            this.Bakiye = this.TamBiletFiyatı * this.ToplamTamBiletAdedi + this.YarimBiletFiyati * this.ToplamYarimBiletAdedi;
        }
    }
}
