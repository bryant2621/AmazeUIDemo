using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceStack.Redis;

namespace AmazeDemo
{
    public partial class Service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dbManager = DBBase.CreateManager();
            using (IRedisClient client = dbManager.GetClient())
            {
                client.Set<string>("username", "bryant");
                var username = client.Get<string>("username");
                Response.Write(username);
            }

        }
    }
}