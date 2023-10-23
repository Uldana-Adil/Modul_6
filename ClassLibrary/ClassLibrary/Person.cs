using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PersonUtility
    {
        public static string GetPersonInfo(Person person)
        {
            return $"Name: {person.FirstName} {person.LastName}, Age: {person.Age}";
        }
    }
}

