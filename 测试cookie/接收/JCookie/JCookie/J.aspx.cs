using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JCookie
{
    public partial class J : System.Web.UI.Page
    {
        /// <summary>
        /// Cookie 发送参数 load事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string j = HttpContext.Current.Request.Cookies["z"].Value;
            if (!string.IsNullOrEmpty(j))
            {
                this.lab.Text = j;
            }
        }
    }
}