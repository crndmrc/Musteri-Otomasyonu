using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.SQL
{
    public class Musteri
    {
        public string MusteriGoster()
        {
            return "select * from TBL_MUSTERI";
        }
        public string MusteriEkle()
        {
            return "insert into TBL_MUSTERI (adi, soyadi,TCNo,dogumTarihi,profilResimYolu) values (@adi, @soyadi,@TCNo,@dogumTarihi,@profilResimYolu)";
        }
        public string MusteriGuncelle()
        {
            return "update TBL_MUSTERI set adi=@adi, soyadi=@soyadi TCNo=@TCNo, dogumTarihi=@dogumTarihi, profilResimYolu=@profilResimYolu where id=@id";
        }
        public string MusteriSil()
        {
            return "delete from TBL_MUSTERI where id=@id";
        }
        public string MusteriAra()
        {
            return "select * from dbo.FNC_MUSTERI_ARA(@deger)";
        }
    }
}
