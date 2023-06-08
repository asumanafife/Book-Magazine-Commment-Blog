using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;
namespace KitapDergiYorumm.AdminSayfalar
{
    public partial class BlogGüncelle : System.Web.UI.Page
    {
        KitapDergiBlogEntities db = new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["BLOGID"], out int y))
                {
                    var turler = db.TBLTUR.Select(x => new { x.TURAD, x.TURID }).ToList();
                    DropDownList1.DataSource = turler;
                    DropDownList1.DataBind();

                    var kategoriler = db.TBLKATEGORI.Select(x => new { x.KATEGORIAD, x.KATEGORIID }).ToList();
                    DropDownList2.DataSource = kategoriler;
                    DropDownList2.DataBind();

                    var deger = db.TBLBLOG.Find(y);
                    if (deger != null)
                    {
                        TextBox1.Text = deger.BLOGBASLIK;
                        TextBox2.Text = deger.BLOGTARIH.ToString();
                        TextBox3.Text = deger.BLOGGORSEL;
                        TextBox4.Text = deger.BLOGICERIK;
                        DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
                        DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();


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
