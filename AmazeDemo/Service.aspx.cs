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
            RedisClient client = new RedisClient("192.168.91.128", 6379);
            client.Set<string>("username", "bryant");
            var username = client.Get<string>("username");
            Response.Write(username);
        }
    }
}