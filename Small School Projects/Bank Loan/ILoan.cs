using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HOT7
{
    public class ILoan
    {
        public ILoan(string name, string type, double balance)
        {
            Name = name;
            Type = type;
            Balance = balance; 
        }

        string Name { get; }
        string Type { get; }
        double Balance { get; }

    }
}
