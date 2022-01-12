using System;

namespace Exercise08
{
    public class EmployeePay
    {
        private string _employee;
        private decimal _basePay;
        private decimal _hoursWorked;
        private decimal _workHourLimit = 40m;
        private decimal _minimumWage = 8.00m;
        private decimal _maxHoursWorked = 60m;

        public EmployeePay(string employee, double basePay, decimal hoursWorked)
        {
            _employee = employee;
            _basePay = Convert.ToDecimal(basePay);
            _hoursWorked = hoursWorked;
        }

        public bool IsLessThanMinimumWage()
        {
            return _basePay < _minimumWage;
        }

        public bool WorkedMoreThanAllowedHours()
        {
            return _hoursWorked > _maxHoursWorked;
        }

        public decimal CalculatePay()
        {
            decimal overtime = _hoursWorked - _workHourLimit;
            decimal overtimePay = _basePay * 1.5m;
            return _workHourLimit* _basePay + overtime * overtimePay;
        }

        public string PayoutMessage()
        {
            if (IsLessThanMinimumWage())
            {
                return $"{_employee} base pay must not be less than the minimum wage (${_minimumWage} an hour).";
            }

            if (WorkedMoreThanAllowedHours())
            {
                return $"{_employee} can not work more than {_maxHoursWorked} hours in a week.";
            }

            return $"{_employee} total pay is ${CalculatePay():N2}.";
        }
    }
}
