using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm;
using KitapDergiYorumm.Entity;

namespace KitapDergiYorumm
{
    public partial class Default : System.Web.UI.Page
    {
        KitapDergiBlogEntities db = new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           var bloglar1= db.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar1;
            Repeater1.DataBind();

            var bloglar2 = db.TBLKATEGORI.ToList();
            Repeater2.DataSource = bloglar2;
            Repeater2.DataBind();

            var bloglar3 = db.TBLBLOG.ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();
        }
    }
}