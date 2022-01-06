using System;
using System.Collections.Generic;
namespace TelephoneBook
{
    class contact
    {   public contact (string name, string surname, string number)
        {   Name= name ;
            Surname = surname;
            Number= number ;
        }
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Number {get; set;}
    }

}