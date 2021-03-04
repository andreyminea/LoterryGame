using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery
{
    public class EntryPerson
    {
        public string Name { get; set; }
        public List<int> Numbers { get; set; }
        public string Sum { get; set; }
        public Date Date { get; set; }

        public string GetNumbers()
        {
            return Numbers[0] + " " + Numbers[1] + " " + Numbers[2];
        }
    }
}
