using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYeni.UI.Common
{
    public class OdaRezervasyon
    {
        public Oda Oda { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime GirisTarihi { get; set; }
        public override string ToString()
        {
            return Musteri.AdSoyad ;
        }
    }
}
