using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingRepository
    {
        private List<Outing> _outings = new List<Outing>()
        {
           new Outing("Golf", 200, 10, DateTime.Parse("4/13/2017")),
           new Outing("Bowling",100, 10, DateTime.Parse("5/2/2017")),
           new Outing("Amusement Park", 300, 10, DateTime.Parse("7/3/2017")),
           new Outing("Concert", 400, 10, DateTime.Parse("8/4/2017")),
        };
        public double TotalCostPerOuting()
        {
            double sum = 0;
            foreach (Outing outing in _outings)
            {
                sum += outing.TotalCostPerOuting;
            }
            return sum;
        }
        public List<Outing> GetOutings()
        {
            return _outings;
        }

        public void AddOutingToList(Outing outing)
        {
            _outings.Add(outing);
        }
        public void AddOutingToList(List<Outing> outing)
        {
            foreach (Outing _outing in _outings)

            {
                _outings.Add(_outing);
            }
        }
    }
}
