using System;
using static System.Math;
namespace ToysComparer
{

    public struct Toy : IComparable
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public int CompareTo(object other)
        {
            if (other is not Toy)
                throw new ArgumentException("Сравнивать можно только структуры типа Toy");
            return Sign(Price - ((Toy)other).Price);
        }

        public override string ToString()
        {
            return $"{Name};{Price};{AgeMin};{AgeMax}";
        }
    }
}