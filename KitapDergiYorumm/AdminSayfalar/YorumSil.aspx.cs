using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;
namespace KitapDergiYorumm.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        KitapDergiBlogEntities db= new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(x);
            db.TBLYORUM.Remove(yorum);
            db.SaveChanges();
            Response.Redirect("BlogYorumlar.aspx");
        }
    }
}