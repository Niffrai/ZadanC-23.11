using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Book : Edition
    {
        public int Year { get; set; }
        public string Publisher { get; set; }

        public override string Display()
        {
            return $"Книга {base.Display()} Год издания {Year} Издательство \"{Publisher}\"";
        }
    }
}
