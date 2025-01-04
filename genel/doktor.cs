using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    public class doktor : poliklinik
    {
        public int id {  get; set; }
        public string doktorisim { get; set; }
        public string doktorsoyisim { get; set; }
        public string kullanici { get; set; }
        public string sifre {  get; set; }
        public string poliklinik { get; set; }


    }
}
