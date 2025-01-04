using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    public static class datastore
    {
        public static List<(string HastaAdi, string HastaSoyadi, string RandevuTarihi, string RandevuSaati, string DoktorAdi)> randevular = new List<(string, string, string, string, string)>();
        
        public static List<doktor> doktorListesi = new List<doktor>()
        {
            new doktor { id = 1, doktorisim = "Nisa", doktorsoyisim = "Tozmaz", kullanici = "Nisa", sifre = "Tozmaz", poliklinik = "Göz Polikliniği" },
            new doktor { id = 2, doktorisim = "Namık", doktorsoyisim = "Kemal", kullanici = "Namık", sifre = "Kemal", poliklinik = "Göz Polikliniği" },
            new doktor { id = 3, doktorisim = "Ayşe", doktorsoyisim = "Yılmaz", kullanici = "Ayşe", sifre = "Yılmaz", poliklinik = "Göz Polikliniği" },
            new doktor { id = 4, doktorisim = "Mehmet", doktorsoyisim = "Demir", kullanici = "Mehmet", sifre = "Demir", poliklinik = "Dahiliye Polikliniği" },
            new doktor { id = 5, doktorisim = "Hüseyin", doktorsoyisim = "Öztürk", kullanici = "Hüseyin", sifre = "Öztürk", poliklinik = "Dahiliye Polikliniği" },
            new doktor { id = 6, doktorisim = "Zeynep", doktorsoyisim = "Kaya", kullanici = "Zeynep", sifre = "Kaya", poliklinik = "Dahiliye Polikliniği" },
            new doktor { id = 7, doktorisim = "Ali", doktorsoyisim = "Aslan", kullanici = "Ali", sifre = "Aslan", poliklinik = "Çocuk Hastalıkları Polikliniği" },
            new doktor { id = 8, doktorisim = "Fatma", doktorsoyisim = "Yıldız", kullanici = "Fatma", sifre = "Yıldız", poliklinik = "Çocuk Hastalıkları Polikliniği" },
            new doktor { id = 9, doktorisim = "Hakan", doktorsoyisim = "Aydın", kullanici = "Hakan", sifre = "Aydın", poliklinik = "Çocuk Hastalıkları Polikliniği" },
            new doktor { id = 10, doktorisim = "Seda", doktorsoyisim = "Aksoy", kullanici = "Seda", sifre = "Aksoy", poliklinik = "Kadın Hastalıkları Polikliniği" },
            new doktor { id = 11, doktorisim = "Ömer", doktorsoyisim = "Çetin", kullanici = "Ömer", sifre = "Çetin", poliklinik = "Kadın Hastalıkları Polikliniği" },
            new doktor { id = 12, doktorisim = "Mehmet", doktorsoyisim = "Akın", kullanici = "Mehmet", sifre = "Akın", poliklinik = "Kadın Hastalıkları Polikliniği" },
            new doktor { id = 13, doktorisim = "Murat", doktorsoyisim = "Çalışkan", kullanici = "Murat", sifre = "Çalışkan", poliklinik = "Ortopedi Polikliniği" },
            new doktor { id = 14, doktorisim = "İsmail", doktorsoyisim = "Korkmaz", kullanici = "İsmail", sifre = "Korkmaz", poliklinik = "Ortopedi Polikliniği" },
            new doktor { id = 15, doktorisim = "Gülcan", doktorsoyisim = "Yılmaz", kullanici = "Gülcan", sifre = "Yılmaz", poliklinik = "Ortopedi Polikliniği" },
            new doktor { id = 16, doktorisim = "Veli", doktorsoyisim = "Güler", kullanici = "Veli", sifre = "Güler", poliklinik = "KBB Polikliniği" },
            new doktor { id = 17, doktorisim = "Narin", doktorsoyisim = "Demirtaş", kullanici = "Narin", sifre = "Demirtaş", poliklinik = "KBB Polikliniği" },
            new doktor { id = 18, doktorisim = "Büşra", doktorsoyisim = "Polat", kullanici = "Büşra", sifre = "Polat", poliklinik = "KBB Polikliniği" },
            new doktor { id = 19, doktorisim = "Serdar", doktorsoyisim = "Öztürk", kullanici = "Serdar", sifre = "Öztürk", poliklinik = "Diyetisyenlik Polikliniği" },
            new doktor { id = 20, doktorisim = "Rana", doktorsoyisim = "Kaya", kullanici = "Rana", sifre = "Kaya", poliklinik = "Diyetisyenlik Polikliniği" },
            new doktor { id = 21, doktorisim = "Hülya", doktorsoyisim = "Uslu", kullanici = "Hülya", sifre = "Uslu", poliklinik = "Diyetisyenlik Polikliniği" },
            new doktor { id = 22, doktorisim = "Merve", doktorsoyisim = "Yılmaz", kullanici = "Merve", sifre = "Yılmaz", poliklinik = "Psikiyatri Polikliniği" },
            new doktor { id = 23, doktorisim = "Fatih", doktorsoyisim = "Karaca", kullanici = "Fatih", sifre = "Karaca", poliklinik = "Psikiyatri Polikliniği" },
            new doktor { id = 24, doktorisim = "Emine", doktorsoyisim = "Ozan", kullanici = "Emine", sifre = "Ozan", poliklinik = "Psikiyatri Polikliniği" }
        };
    }
}
