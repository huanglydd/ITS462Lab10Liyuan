using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Text;

namespace GetDronesAJAX
{
    public partial class GetDones : System.Web.UI.Page
    {
        
        string[] options = { "Drones", "Manufacturers", "Model Sizes" };

            public void Page_Load(object sender, EventArgs e)
        {
            string subKey = Request.QueryString["q"].ToLower();
            StringBuilder suggestions = new StringBuilder("");

            foreach (string key in options)
            {
                if (key.ToLower().Contains(subKey))
                    suggestions.Append("<li value='" + key.ToLower() + "' "
                        + " onclick=\"selectItem(this.innerHTML);\" >" + key + "</li>");
            }

            Response.Write(suggestions.ToString());
        }
        
    }
}