using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LearningASP.NET_MVC_V0._0._1
{
    public partial class Default : System.Web.UI.Page
    {
        //It's not asp.net mvc yet. Starting from web forms. I start with web forms to be able to compare it with mvc.
        //Created simple site. 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                btn1.Text = "Proszę kliknij mnie!";
            }
            else
            {
                btn1.Text = tbName.Text;               
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            btn1.Text = tbName.Text;
        }
    }
}