using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;
namespace KitapDergiYorumm.AdminSayfalar
{
    public partial class BlogYorumlar : System.Web.UI.Page
    {
        KitapDergiBlogEntities db =new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar=(from x in db.TBLYORUM
                          select new
                          {
                              x.YORUMID,
                              x.KULLANICIAD,
                              x.TBLBLOG.BLOGBASLIK
                          }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}