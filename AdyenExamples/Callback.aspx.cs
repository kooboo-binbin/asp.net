using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Callback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var path = Server.MapPath("~/App_data/log.txt");
        using (var sw = new StreamWriter(path, true))
        {
            var message = DateTime.Now + " " + Request.UserHostAddress + "\r\n" + Request.QueryString.ToString() + "\r\n" + Request.Form.ToString();
            sw.Write(message);
        }
    }
}