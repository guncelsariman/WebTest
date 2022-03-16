using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTest2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //sdfsfsf
            var cumle = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["KutuphaneEntities1"].ConnectionString;
            SqlConnection baglanti = new SqlConnection(cumle);
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            string sorgu = "select * from Yazar";
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                var ifade = dr.GetString(0);
            }
        }
    }
}