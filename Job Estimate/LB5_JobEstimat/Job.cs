using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB5_JobEstimat
{
    public class Job
    {
        // Constant
        const decimal TRIP_FEE = 35.00m;

        // Instance Variables
        private string _description;
        private decimal _hoursToComplete;
        private decimal _hourlyFee;
        private decimal _totalFee;

        // Constructor
        public Job(string description,
                    decimal hoursToComplete,
                    decimal hourlyFee)
        {
            _description = description;
            _hoursToComplete = hoursToComplete;
            _hourlyFee = hourlyFee;
        }

        // Getters and Setters
        public string Description { get; set; }
        public decimal HoursToComplete { get; set; }
        public decimal HourlyFee { get; set; }
        public decimal TotalFee 
        {
            get
            {
                return ((HoursToComplete * HourlyFee) + TRIP_FEE);
            }
        }
    }
}
