using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOT7
{
    public class ShortTerm : ILoan
    {
        public ShortTerm(string name, string type, double balance, double payment, double interestRate)
            : base (name, type, balance)
        {
            Payment = payment;
            InterestRate = interestRate;
        }

        double Payment { get; set; }
        double InterestRate { get; set; }

        double balancebeforeinterest;
        double balanceafterinterest;

    }
}
