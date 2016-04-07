using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using GetDronesAJAX.DronesListService;

namespace GetDronesAJAX
{
    public partial class GetExtend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string querystring = Request.QueryString["q"];
            string[] querypart = querystring.Split('!');

            switch (querypart[0])
            {
                case "Drones":
                case "Manufacturers":
                case "Model Sizes":
                    DisplayDetailedContent(querypart[0], querypart[1]);
                    break;
                default:
                    break;
            }
        }

        public void DisplayDetailedContent(string choice, string now_select)
        {
            Service1Client client = new Service1Client();

            if (choice == "Drones")
            {
                string Text = client.GetDroneById(now_select);
                Response.Write(Text);
            }
            else if (choice == "Manufacturers")
            {
                string Text = client.GetDronesByManufacturerId(now_select);
                Response.Write(Text);
            }
            else {
                string Text = client.GetDronesByModelSizeId(now_select);
                Response.Write(Text);
            }
        }
    }
}