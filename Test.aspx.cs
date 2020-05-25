using System;
using System.Web;

namespace WebApplication4
{
    public partial class Test : System.Web.UI.Page
    {
        public int counter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (ViewState["counter"] == null)
            //    ViewState["counter"] = counter;
            //Label1.Text = ViewState["counter"].ToString();

            //if (Session["counter"] == null)
            //    Session["counter"] = counter;
            //Label1.Text = Session["counter"].ToString();

            
            if (Request.Cookies["counter"] == null)
            {
                HttpCookie cookie = new HttpCookie("counter")
                {
                    Value = counter.ToString(),
                    Expires = DateTime.Now.AddDays(30)
                };
                //Response.Cookies["counter"].Value = counter.ToString();
                //Response.Cookies["counter"].Expires = DateTime.Now.AddDays(30);
                Response.SetCookie(cookie);
            }
            Label1.Text = Request.Cookies["counter"].Value.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //counter = (int)ViewState["counter"];
            //counter++;
            //Label1.Text = counter.ToString();
            //ViewState["counter"] = counter;

            //counter = (int)Session["counter"];
            //counter++;
            //Label1.Text = counter.ToString();
            //Session["counter"] = counter;

            counter = Int32.Parse(Request.Cookies["counter"].Value);
            counter++;
            Label1.Text = counter.ToString();
            Response.Cookies["counter"].Value = counter.ToString();
            Response.Cookies["counter"].Expires = DateTime.Now.AddDays(30);
        }
    }
}