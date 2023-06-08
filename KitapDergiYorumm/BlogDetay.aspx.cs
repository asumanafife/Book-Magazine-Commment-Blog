using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KitapDergiYorumm.Entity;
namespace KitapDergiYorumm
{
    public partial class BlogMaster : System.Web.UI.Page
    {
         KitapDergiBlogEntities db = new KitapDergiBlogEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id= Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog=db.TBLBLOG.Where(x=>x.BLOGID== id).ToList();
            Repeater1.DataSource=blog;
            Repeater1.DataBind();

            var yorumlar=db.TBLYORUM.Where(x => x.YORUMBLOG == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BLOGID"]);
            TBLYORUM t = new TBLYORUM();
            t.KULLANICIAD = TextBox1.Text;
            t.MAIL= TextBox2.Text;
            t.YORUMICCERIK= TextBox3.Text;
            t.YORUMBLOG = id;
            db.TBLYORUM.Add(t);
            db.SaveChanges();
            Response.Redirect("BlogDetay.Aspx?BLOGID=" + id);
        }

        
        

       
    }
}
