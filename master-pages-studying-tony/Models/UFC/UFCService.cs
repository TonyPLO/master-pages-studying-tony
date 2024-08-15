using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace master_pages_studying_tony.Models.UFC
{
    public class UFCService
    {
        public static List<UFCFighter> CreateData() 
        {

            UFCFighter fighter1 = new UFCFighter("Conor McGregor", 70, 175, 180, 22, 6, 0);//שם משקל גובה כוח ניצחונות אפסדים תקו
            UFCFighter fighter2 = new UFCFighter("Francis Ngannou", 119, 193, 210, 17, 3, 0);
            UFCFighter fighter3 = new UFCFighter("Tyson Fury", 115, 206, 185, 30, 0, 1);
            UFCFighter fighter4 = new UFCFighter("Tony BASS", 140, 230, 2369, 3579, 0, 1);
            UFCFighter fighter5 = new UFCFighter("Izhar", 80, 178, 185, 4, 480, 74);

            List<UFCFighter> myFighters = new List<UFCFighter>();
            myFighters.Add(fighter1);
            myFighters.Add(fighter2);
            myFighters.Add(fighter3);
            myFighters.Add(fighter4);
            myFighters.Add(fighter5);

            return myFighters;
        }
    }
}