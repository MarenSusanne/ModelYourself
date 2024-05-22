using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgramering
{
    public class Person
    {
        public string Name;
        public string Age;
        public string HairColor;
        public string Hobby;
        public string FavoriteMeal;
        public Person(string name, string age, string hairColor, string hobby, string favoriteMeal)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
            Hobby = hobby;
            FavoriteMeal = favoriteMeal;
            
        }
    }
}
