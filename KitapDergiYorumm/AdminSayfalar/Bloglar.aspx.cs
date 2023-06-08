using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;

namespace KitapDergiYorumm.AdminSayfalar
{
    public partial class Bloglar : System.Web.UI.Page
    {
        KitapDergiBlogEntities db = new KitapDergiBlogEntities();

        protected Repeater GetRepeater1()
        {
            return Repeater1;
        }

        protected void Page_Load(object sender, EventArgs e, Repeater repeater1)
        {
            Repeater1.DataSource = db.TBLBLOG.ToList();
            Repeater1.DataBind();
        }
    }
}