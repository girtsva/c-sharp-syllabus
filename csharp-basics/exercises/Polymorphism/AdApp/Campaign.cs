using System;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign;

        public Campaign() 
        {
            _campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a) 
        {
            _campaign.Add(a);
        }

        public double GetCost()
        {
            return _campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            string specifier = "$#,#0.00";

            var result = "Advert Campaign Costs:\n";
            result += ("------------------------\n");

            foreach (var advert in _campaign)
            {
                result += advert.ToString() + "\n";
            }

            result += "------------------------\n";
            result += $"Total:      {GetCost().ToString(specifier),11}";
            return result;
        }
    }
}