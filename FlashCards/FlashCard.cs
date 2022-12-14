using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_FlashCards
{
    public class FlashCard
    {
        private readonly string _term;
        private readonly string _definition;

        public FlashCard(string t, string d)
        {
            _term = t;
            _definition = d;
        }

        public string GetTerm()
        {
            return _term;
        }

        public string GetDefinition()
        {
            return _definition;
        }
    }
}
