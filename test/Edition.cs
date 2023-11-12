using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class Edition
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public virtual string Display()
        {
            return $"Автор {Author} Название: \"{Name}\"";
        }
        public bool IsThisEdition(string author)
        {
            return Author.Equals(author, StringComparison.OrdinalIgnoreCase);
        }
    }
}
