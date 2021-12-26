namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private double _rate;

        public NewspaperAd(double fee, double rate, int column) : base(fee)
        {
            _column = column;
            _rate = rate;
        }

        public override double Cost()
        {
            var fee = base.Cost() + _column * _rate;
            return fee;
        }

        public override string ToString()
        {
            string specifier = "$#,#0.00";
            return $"Newspaper:  {Cost().ToString(specifier),11}";
        }
    }
}