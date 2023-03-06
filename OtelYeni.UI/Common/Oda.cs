using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYeni.UI.Common
{
    public class Oda
    {
        public byte YatakSayisi { get; set; }
        public int Numarasi { get; set; }
        public double Fiyat { get; set; }
        public OdaDurumu OdaDurumu { get; set; }
        // public Musteri Musteri { get; set; }
        public override string ToString()
        {
            
            return " Oda Numarası: "+ Numarasi + "\n Oda Kontenjanı : "+YatakSayisi+" kişik.\n Oda Fiyatı : " + Fiyat + "\n Oda Durumu :" + OdaDurumu.ToString();  
        }
    }
}
