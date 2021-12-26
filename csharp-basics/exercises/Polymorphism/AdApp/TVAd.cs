namespace AdApp
{
    public class TVAd: Advert
    {
        private double _rate;
        private int _seconds;
        private bool _peakTime;

        public TVAd(double fee, double rate, int seconds, bool peakTime = false) : base(fee)
        {
            _rate = rate;
            _seconds = seconds;
            _peakTime = peakTime;
        }
        
        public override double Cost() 
        {
            var variableCost = _rate * _seconds;

            if (_peakTime)
            {
                variableCost *= 2;
            }

            var totalCost = base.Cost() + variableCost;

            return totalCost;
        }

        public override string ToString() 
        {
            string specifier = "$#,#0.00";
            return $"TV Ad:      {Cost().ToString(specifier),11}";
        }
    }
}