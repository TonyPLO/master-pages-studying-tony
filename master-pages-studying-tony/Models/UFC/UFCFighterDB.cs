using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_pages_studying_tony.Models.UFC
{
    public class UFCFighterDB
    {
        public UFCFighterDB(int id, string name, int height, DateTime birthday)
        {
            Id = id;
            Name = name;
            Height = height;
            Birthday = birthday;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;


        //constructor - בנאי


        public void DisplayFighterData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height} cm");
        }
        public override string ToString()
        {
            return $"name={Name},Height: {Height}";
        }
    }
}
