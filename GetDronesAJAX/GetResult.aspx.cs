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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string option = Request.QueryString["q"];
            switch (option)
            {
                case "Drones":
                case "Manufacturers":
                case "Model Sizes":
                    DisplayContent(option);
                    break;
                default:
                    break;
            }
        }

        public void DisplayContent(string value)
        {
            Service1Client client = new Service1Client();

            if(value == "Drones")
            {
                StringBuilder temp = new StringBuilder("");
                temp = client.GetDrones();
                Response.Write(temp.ToString());
            }
            else if(value == "Manufacturers")
            {
                StringBuilder temp = new StringBuilder("");
                temp = client.GetManufacturerList();
                Response.Write(temp.ToString());
            }
            else
            {
                StringBuilder temp = new StringBuilder("");
                temp = client.GetModelSizeList();
                Response.Write(temp.ToString());
            }
        }

    }
}