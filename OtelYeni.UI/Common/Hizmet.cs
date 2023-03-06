using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelYeni.UI.Common
{
    public class Hizmet
    {
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public override string ToString()
        {
            return UrunFiyati.ToString();
        }
    }
}
