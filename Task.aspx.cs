using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApplication4
{
    [Serializable]
    public class TaskL
    {
        private static int Count = 0;

        public TaskL()
        {
            ID = ++Count;
        }
        public int ID { get; set; }
        public string Title { get; set; }
    }


    public partial class Task : System.Web.UI.Page
    {
        public List<TaskL> tasks = new List<TaskL>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Request.Cookies.Get("");
            //Response.Cookies.Set(...);

            //Session_ID
            //Session["data"] = 10;
            //ViewState[];

            //if (Session["tasks"] == null) { Session["tasks"] = tasks; }
            //tasks = (List<TaskL>)Session["tasks"];

            //if (!String.IsNullOrEmpty(newTask.Text))
            //{
            //    TaskL task = new TaskL() { Title = newTask.Text };
            //    //tasks = (List<TaskL>)ViewState["tasks"];
            //    tasks.Add(task);
            //    ViewState["tasks"] = tasks;
            //}

            //Repeater1.DataSource = tasks;


            if (Request.Cookies.Get("tasks") != null)
            {
                tasks = JsonConvert.DeserializeObject<List<TaskL>>(Request.Cookies.Get("tasks").Value);
            }
           
            else
            {
                Response.Cookies["tasks"].Value = JsonConvert.SerializeObject(tasks);
                Response.Cookies["tasks"].Expires = DateTime.Now.AddDays(1);
            }
            Repeater1.DataSource = tasks;
            DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(newTask.Text))
            //{
            //    TaskL task = new TaskL() { Title = newTask.Text };
            //    tasks.Add(task);
            //}

            //if (!String.IsNullOrEmpty(newTask.Text))
            //{
            //    TaskL task = new TaskL() { Title = newTask.Text };
            //    //tasks = (List<TaskL>)ViewState["tasks"];
            //    tasks.Add(task);
            //    Session["tasks"] = tasks;
            //}
        }
    }
}