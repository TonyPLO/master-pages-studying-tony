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
            //קורה רק בתחילת הדף ולא בכל שינוי
            if (!IsPostBack)
            {
                uFCFighters = UFCService.CreateData();
                Fighters.DataSource = uFCFighters;
                Fighters.DataBind();
            }
        }
        protected void ChangeText(object sender, EventArgs e)
        {
            myText.Text = "UFC";
        }
        protected void AddNewFighter(object sender, EventArgs e)
        {
            //UFCFighter fighter2 = new UFCFighter("Francis Ngannou", 119, 193, 210, 17, 3, 0);
            //UFCFighter fighter3 = new UFCFighter("Tyson Fury", 115, 206, 185, 30, 0, 1);
            // Retrieve values from TextBox controls
            string name = NameInput.Text;
            //string sign = SignInput.Text;
            int height = int.Parse(HeightInput.Text);
            UFCFighter fighter2 = new UFCFighter(name, 119,height, 210, 17, 3, 0);
            fighter2.IsHeavy = IsHeavyInput.Checked;

            string selectedDate = Birthday.Text;
            DateTime parsedDate;

            if (DateTime.TryParse(selectedDate, out parsedDate))
            {
                // Use the parsedDate as needed
                // Example: Show it in a label or use it in logic
                fighter2.LastBattle = parsedDate;
            }
        uFCFighters.Add(fighter2);
            Fighters.DataSource = uFCFighters;
            Fighters.DataBind();
        }

    }
}