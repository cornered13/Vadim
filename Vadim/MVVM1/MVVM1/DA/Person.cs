using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM1.DA
{
    internal class Person
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public static Person[] GetPersons()   
        {
            var result = new Person[]
            {
                new Person() { Name ="Альбек", FirstName ="Арберта"},
                new Person() { Name ="Буракидзе", FirstName ="Корт"},
                new Person() { Name ="Мадрик", FirstName ="Карин"}
            };
            return result;
        }
            
    }
}
