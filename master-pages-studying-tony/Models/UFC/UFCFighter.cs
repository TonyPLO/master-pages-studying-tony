using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_pages_studying_tony.Models.UFC
{
    public class UFCFighter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int PowerPunch { get; set; }
        public int[] Record { get; set; } = new int[3]; // wins, losses, draws
        public DateTime LastBattle { get; set; } = DateTime.Now;
        public bool IsHeavy { get; set; } = true;

        //constructor - בנאי
        public UFCFighter(string name, int weight, int height, int powerPunch, int wins, int losses, int draws)
        {
            Name = name;
            Weight = weight;
            Height = height;
            PowerPunch = powerPunch;
            Record[0] = wins;
            Record[1] = losses;
            Record[2] = draws;
        }

        public void DisplayFighterData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Reach: {PowerPunch} cm");
            Console.WriteLine($"Record: {Record[0]}{Record[1]}{Record[2]}");
        }
        public void ChangeWeight(int newWeight)
        {
            Weight = newWeight;
        }

        public void Change(int newHeight, int newPowerPunch, int wins, int losses, int draws)
        {
            Height = newHeight;
            PowerPunch = newPowerPunch;
            Record[0] = wins;
            Record[1] = losses;
            Record[2] = draws;
        }

        public bool HasPositiveRecord()
        {
            return Record[0] > Record[1];
        }
        public override string ToString()
        {
            return $"name={Name},Weight: {Weight},Height: {Height}";
        }
    }
}
