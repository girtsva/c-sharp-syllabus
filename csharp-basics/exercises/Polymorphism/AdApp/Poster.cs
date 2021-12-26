using System;

namespace AdApp
{
    public class Poster: Advert
    {
        private double _costPerCopy;
        private int _numberOfCopies;

        public Poster(double fee, double costPerCopy, int numberOfCopies) : base(fee)
        {
            _costPerCopy = costPerCopy;
            _numberOfCopies = numberOfCopies;
        }

        public override double Cost()
        {
            var fee = base.Cost() + _costPerCopy * _numberOfCopies;
            return fee;
        }

        public override string ToString()
        {
            string specifier = "$#,#0.00";
            return $"Poster:     {Cost().ToString(specifier),11}";
        }
    }
}
