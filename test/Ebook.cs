using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Ebook : Edition
    {
        public string Href { get; set; }
        public string Annotation { get; set; }
        public override string Display()
        {
            return $"Электронный ресурс {base.Display()} Аннотация {Annotation} Ссылка {Href}";
        }
    }
}
