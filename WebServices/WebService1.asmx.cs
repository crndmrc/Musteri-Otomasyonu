using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //global
        List<SqlParameter> _params = new List<SqlParameter>();
        Execute _execute = new Execute();

        [WebMethod]
        public DataTable r_Musteri(string _sql)
        {
            DataTable dtResult = new DataTable();

            string _hataMesaji = "";
            dtResult = _execute.executeDT(_sql, null, false, ref _hataMesaji);
            dtResult.TableName = "dtTable";

            return dtResult;
        }

        [WebMethod]
        public bool c_Musteri(string _sql,string adi, string soyadi,int TCNo,DateTime dogumTarihi,string profilResimYolu)
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Add(new SqlParameter("@adi", adi));
            _params.Add(new SqlParameter("@soyadi", soyadi));
            _params.Add(new SqlParameter("@TCNo",TCNo));
            _params.Add(new SqlParameter("@dogumTarihi", dogumTarihi)); 
            _params.Add(new SqlParameter("@profilResimYolu", profilResimYolu));

            result = _execute.execute(_sql, _params.ToArray(), false, ref _hataMesaji);

            return result;
        }

        [WebMethod]
        public bool u_Musteri(string _sql,int id, string adi, string soyadi, int TCNo, DateTime dogumTarihi, string profilResimYolu)
        {
            bool result = true;
            string _hataMesaji = "";
            _params.Add(new SqlParameter("@id", id));
            _params.Add(new SqlParameter("@adi", adi));
            _params.Add(new SqlParameter("@soyadi", soyadi));
            _params.Add(new SqlParameter("@TCNo", TCNo));
            _params.Add(new SqlParameter("@dogumTarihi", dogumTarihi));
            _params.Add(new SqlParameter("@profilResimYolu", profilResimYolu));

            result = _execute.execute(_sql, _params.ToArray(), false, ref _hataMesaji);

            return result;
        }

        [WebMethod]
        public bool d_Musteri(string _sql,int id)
        {
            bool result = true;
            string _hataMesaji = "";

            _params.Add(new SqlParameter("@id", id));

            result = _execute.execute(_sql, _params.ToArray(), false, ref _hataMesaji);

            return result;
        }
        public bool f_Musteri(string _sql,string deger)
        {
            bool result =true;
            string _hataMesaji ="";
            _params.Add(new SqlParameter("@deger",deger));

            result=_execute.execute(_sql, _params.ToArray(),false, ref _hataMesaji);
            return result;
        }
    }
}
