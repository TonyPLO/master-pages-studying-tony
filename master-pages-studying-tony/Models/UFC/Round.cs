using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace master_pages_studying_tony.Models.UFC
{
    public class Round
    {

        public UFCFighter fighter1;
        public UFCFighter fighter2;
        public int fighter1Points;
        public int fighter2Points;

        public void Punch(int fighter)
        {
            if(fighter == 1)
            {
                fighter1Points++;
            }
            else
            {
                fighter2Points++;
            }

        }

    }
}
