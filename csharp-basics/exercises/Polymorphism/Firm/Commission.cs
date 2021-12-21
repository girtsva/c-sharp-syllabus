using System;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;
        
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double comissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _totalSales = 0;
            _commissionRate = comissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _totalSales * _commissionRate;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }
    }
}
