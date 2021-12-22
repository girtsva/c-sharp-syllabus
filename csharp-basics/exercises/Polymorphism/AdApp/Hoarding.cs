namespace AdApp
{
    public class Hoarding: Advert
    {
        private double _rate;
        //per day
        private int _numDays;
        private bool _primeLocation;

        public Hoarding(double fee, int numDays, double rate, bool prime = false) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _primeLocation = prime;
        }

        public override double Cost() 
        {
            var variableCost = _rate * _numDays;

            if (_primeLocation)
            {
                variableCost *= (0.5 + 1); 
            }

            var totalCost = base.Cost() + variableCost;

            return totalCost;
        }

        public override string ToString() 
        {
            string specifier = "$#,#0.00";
            return $"Hoarding:   {Cost().ToString(specifier), 11}";
        }
    }
}