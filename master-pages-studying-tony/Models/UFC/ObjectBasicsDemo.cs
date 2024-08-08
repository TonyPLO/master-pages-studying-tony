using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_pages_studying_tony.Models.UFC
{
    public class ObjectBasicsDemo
    {
        public static void FighterDemo()
        {
            UFCFighter fighter1 = new UFCFighter("Conor McGregor", 70, 175, 180, 22, 6, 0);//שם משקל גובה כוח ניצחונות אפסדים תקו
            UFCFighter fighter2 = new UFCFighter("Francis Ngannou", 119, 193, 210, 17, 3, 0);
            UFCFighter fighter3 = new UFCFighter("Tyson Fury", 115, 206, 185, 30, 0, 1);
            UFCFighter fighter4 = new UFCFighter("Tony BASS", 140, 230, 2369, 3579, 0, 1);
            UFCFighter fighter5 = new UFCFighter("Izhar", 80, 178, 185, 4, 480, 74);

            fighter1.DisplayFighterData();
            fighter2.DisplayFighterData();
            fighter3.DisplayFighterData();
            fighter4.DisplayFighterData();
            fighter5.DisplayFighterData();

            fighter2.ChangeWeight(62);
            fighter2.DisplayFighterData();

            Console.WriteLine($"Has positive record: {fighter2.HasPositiveRecord()}");

            Stadium s = new Stadium();
            fighter1.Name = "other name";


            //s.seatsCount = 100;
            s.SetSeatsCount(30);
            Console.WriteLine("Stadium = " + s);
            s.SetSeatsCount(30000);
            Console.WriteLine("Stadium = " + s);

            Console.WriteLine("ths stadium is open ? " + s.GetIsOpen());
            s.SetIsOpen(true);
            Console.WriteLine("ths stadium is open ? " + s.GetIsOpen());

            Stadium st = new Stadium(6000);
            Stadium st3 = new Stadium(7000, "New York", false);
            Console.WriteLine("st3 = " + st3);

        }

        public static void Demo()
        {
            FighterDemo();
        }
    }
}
