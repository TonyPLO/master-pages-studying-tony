using master_pages_studying_tony.Models.UFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace master_pages_studying_tony
{
    public partial class FighersPage : System.Web.UI.Page
    {
        public static List<UFCFighter> uFCFighters = new List<UFCFighter>();
        protected void Page_Load(object sender, EventArgs e)
        {
            uFCFighters = UFCService.CreateData();
            Fighters.DataSource = uFCFighters;
            Fighters.DataBind();
        }
        protected void ChangeText(object sender, EventArgs e)
        {
            myText.Text = "UFC";
        }
    }
}