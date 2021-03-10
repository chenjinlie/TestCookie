using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FCookie
{
    public partial class F : System.Web.UI.Page
    {
        /// <summary>
        /// Cookie 发送参数 load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("f","发送参数");
            //cookie.Domain = "http://localhost:9902/";
            cookie.HttpOnly = true;
            cookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
    }
}