using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
   public class Outing
    {
        //--Constructor
        public Outing(string eventType, int numberOfPeople, double totalCost, DateTime date)
        {
            EventType = eventType;
            NumberOfPeople = numberOfPeople;
            TotalCostPerOuting = totalCost;
            Date = date;
            
        }

        public string EventType { get; set; }
        public int NumberOfPeople { get; set; }
        public double CostPerPerson => TotalCostPerOuting / NumberOfPeople;
        public double TotalCostPerOuting { get; set; }
        public DateTime Date { get; set; }


        public override string ToString()
        {
            return $"{EventType}\n" +
                   $"Total cost per outing: {TotalCostPerOuting}\n" +
                   $"Total cost per person: {CostPerPerson}\n" +
                   $"Number of people per outing: {NumberOfPeople}\n" +
                   $"Date of outing: {Date}\n";

        }
    }
}
