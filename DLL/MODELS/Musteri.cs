using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.MODELS
{

    public class Musteri
    {
        //global
        SQL.Musteri _sql = new SQL.Musteri();
        web_localhost.WebService1 _ws = new web_localhost.WebService1();
        //properties
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int TCNo { get; set; }
        public DateTime dogumTarihi { get; set; }
        public string profilResimYolu { get; set; }
        public string aranacakDeger { get;set;}
        //actions
        public DataTable MusteriListele()
        {
            return _ws.r_Musteri(_sql.MusteriGoster());
        }
        public bool MusteriEkle(Musteri _musteri)
        {
            return _ws.c_Musteri(_sql.MusteriEkle(), adi, soyadi, TCNo, dogumTarihi, profilResimYolu);
        }
        public bool MusteriGuncelle(Musteri _musteri)
        {
            return _ws.u_Musteri(_sql.MusteriGuncelle(), id, adi, soyadi, TCNo, dogumTarihi, profilResimYolu);
        }
        public bool MusteriSil(Musteri _musteri)
        {
            return _ws.d_Musteri(_sql.MusteriSil(), id);
        }
        public bool MusteriAra(Musteri _musteri)
        {
            return true;// _ws.f_Musteri(_sql.MusteriAra(), aranacakDeger);
        }
    }
}
