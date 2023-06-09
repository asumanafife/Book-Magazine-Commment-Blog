﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;
namespace KitapDergiYorumm.AdminSayfalar
{
    public partial class BlogSil : System.Web.UI.Page
    {
        KitapDergiBlogEntities db = new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = db.TBLBLOG.Find(x);
            db.TBLBLOG.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}