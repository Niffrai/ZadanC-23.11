using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Programmer
    {
        public string Name { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public byte Age { get; set; } //возраст
        public byte Experience { get; set; } //стаж работы
        public string Language { get; set; } //язык на котором пишет 
        public override string ToString()
        {
            return $"Имя: {Name}\r\nФаммилия: {Surname}\r\nВозраст: {Age} лет\r\nСтаж работы: {Experience} лет\r\nПишет на {Language}";
        }
    }
}
