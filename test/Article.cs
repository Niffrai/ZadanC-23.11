using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Article : Edition
    {
        public string Journal { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public override string Display()
        {
            return $"Статья {base.Display()} Журнал \"{Journal}\" #{Number} Год издания {Year}";
        }
    }
}
