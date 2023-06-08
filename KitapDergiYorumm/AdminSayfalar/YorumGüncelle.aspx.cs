using KitapDergiYorumm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KitapDergiYorumm.AdminSayfalar
{
    public partial class YorumGüncelle : System.Web.UI.Page
    {
        KitapDergiBlogEntities db = new KitapDergiBlogEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["BLOGID"], out int y))
                {
                    var yorumlar = db.TBLTUR.Select(x => new { x.TURAD, x.TURID }).ToList();
                   

                    var kategoriler = db.TBLKATEGORI.Select(x => new { x.KATEGORIAD, x.KATEGORIID }).ToList();
                    

                    var deger = db.TBLBLOG.Find(y);
                    if (deger != null)
                    {
                        TextBox1.Text = deger.BLOGBASLIK;
                        TextBox2.Text = deger.BLOGTARIH.ToString();
                        TextBox5.Text = deger.BLOGGORSEL;


                    }
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string metin = TextBox1.Text;
            TextBox1.Text = "Aktarılan Metin: " + metin;
        }
    }
}