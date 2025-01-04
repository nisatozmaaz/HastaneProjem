using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    public class hastane
    {
        public virtual string poliklinik { get; set; }
        public virtual string doktoradi { get; set; }
        public virtual string randevutarihi { get; set; }
        public virtual string randevusaati { get; set; }


        public override string ToString()
        {
            return $"{randevusaati} - {randevutarihi} - {poliklinik} - {doktoradi}";
        }
    }
}
