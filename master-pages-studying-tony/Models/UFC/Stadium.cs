using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_pages_studying_tony.Models.UFC
{

    //Getters & Setters
    public class Stadium
    {

        /*Variables = משתני מחלקה - תכונות*/

        //city, seatsCount, isOpen
        //default, 0
        private int seatsCount = 0;//5,000 - 70,000
        private string city = "";
        private bool isOpen = false;


        //Constructors  = בנאי  = פעולה בונה

        public Stadium() { }
        public Stadium(int seatsCount)
        {

            //should use in the setter
            //this.seatsCount = seatsCount;
            SetSeatsCount(seatsCount);
        }

        public Stadium (int seatsCount, string city, bool isOpen)
        {
            SetSeatsCount(seatsCount);
            SetCity(city);
            SetIsOpen(isOpen);

            //this.isOpen = isOpen;
            //this.seatsCount = seatsCount;
            //this.city = city;


        }



        //Getters & Setters 

        //Set+VariableName
        //SetX
        public void SetSeatsCount (int seatsCount)
        {
            if(seatsCount >= 5000 && seatsCount <= 70_000)
            //"this" refer (=מתייחס) to THIS instance (השכפול הנוכחי) 
            this.seatsCount = seatsCount;
            else Console.WriteLine("The values not in the range: 5,000 - 70,000");
        }



        public void SetCity(string city)
        {
            this.city = city;
        }

        public void SetIsOpen(bool isOpen)
        {
            this.isOpen = isOpen;
        }

        //Get+varName
        public string GetCity() { return this.city; }

        public int GetSeatsCount() { return seatsCount; }


        public bool GetIsOpen() { return this.isOpen; }

        //this will be printed when the instance send to Console.WriteLine(str) 
        public override string ToString()
        {
            //return "Hello stadium";

            return $"Stadium: [seatsCount={seatsCount},city = {city}, isOpen = {isOpen}]";
        }


    }
}
