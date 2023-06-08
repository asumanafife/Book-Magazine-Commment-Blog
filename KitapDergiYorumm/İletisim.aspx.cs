using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;
namespace KitapDergiYorumm
{
    public partial class İletisim : System.Web.UI.Page
    {
        KitapDergiBlogEntities db= new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.TELEFON= TextBox3.Text;
            t.MESAJ= TextBox4.Text;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
        }
    }
}