using master_pages_studying_tony.Models.UFC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace master_pages_studying_tony
{
    public partial class FightersPageDB : System.Web.UI.Page
    {
        
        public static List<UFCFighter> uFCFighters = new List<UFCFighter>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //קורה רק בתחילת הדף ולא בכל שינוי
            if (!IsPostBack)
            {
                uFCFighters = UFCService.CreateData();
                Fighters.DataSource = uFCFighters;
                Fighters.DataBind();
                UFCDao.CreateInitialTables();

            }
        }
        protected void ChangeText(object sender, EventArgs e)
        {
            myText.Text = "UFC";
        }
        protected void AddNewFighterDB(object sender, EventArgs e)
        {
            
            // Retrieve values from TextBox controls
            string name = NameInput.Text;
            //string sign = SignInput.Text;
            int height = int.Parse(HeightInput.Text);
            Random rnd = new Random();
            int id = rnd.Next(100000, 1000000);
            string selectedDate = Birthday.Text;
            DateTime birthday = DateTime.Parse(selectedDate);
            //(int id, string name, int height, DateTime birthday)
            UFCFighterDB fighterDB = new UFCFighterDB(id,name,height,birthday);
            UFCDao.AddFighter(fighterDB);
        }
    }
}