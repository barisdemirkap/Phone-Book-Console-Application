using System ;
using System.Collections.Generic;

namespace TelephoneBook 
{
    class PhoneBook
    {
        private List <contact> _contacts {get; set ;} = new List<contact> () ;

        private void DisplayContacts (List<contact> contacts) 
        {       foreach (var contact in  contacts)
                {
                    DisplayContactDetails(contact) ;
                }

        }

        private void DisplayContactDetails (contact Contact)
        {
                Console.WriteLine($"Contact: {Contact.Name +" "+ Contact.Surname}, {Contact.Number}  ") ;
                Console.WriteLine("-");
        }

        public void AddContact (contact Contact) 
        {
            _contacts.Add(Contact) ;
        }

    public void DisplayContact(string number)
    {
        var Contact  = _contacts.FirstOrDefault (c=> c.Number == number) ;
        if(Contact==null)
        {
            Console.WriteLine("Contact not found") ;

        }
        else
        {
            DisplayContactDetails(Contact) ;
        }
    }

    public void DisplayallContacts ()
    {
        DisplayContacts(_contacts) ;
    }


    public void DisplayMatchingContacts (string searchPhrase)
    {
        var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList()  ;
        var matchingContacts2 = _contacts.Where(c => c.Surname.Contains(searchPhrase)).ToList() ;
        DisplayContacts(matchingContacts) ;
        DisplayContacts(matchingContacts2) ;        
    }

    public void RemoveContact (string contact)
    {
        var matchingContacts = _contacts.Where(c => c.Name.Contains(contact)).ToList()  ;
        var matchingContacts2 = _contacts.Where(c => c.Surname.Contains(contact)).ToList() ;
        foreach(var item in matchingContacts)
            {
                Console.WriteLine("You are deleting the person which is named "+ item.Name + " " + item.Surname + ". Are you sure? (y/n)") ;
                char enter = Convert.ToChar(Console.ReadLine()) ;
                if(enter == 'y')    
                   { Console.WriteLine(item.Name + " " + item.Surname +   ":   deleted") ;
                     _contacts.Remove(item) ;
                     Console.WriteLine ("Press Enter to Continue") ;
                    Console.ReadLine() ;
                }else {

                }
                
            }
        
        
    }
    public void EditContact (string contact)
    {
        var matchingContacts = _contacts.Where(c => c.Name.Contains(contact)).ToList()  ;
        var matchingContacts2 = _contacts.Where(c => c.Surname.Contains(contact)).ToList() ;
        foreach(var item in matchingContacts)
            {
                Console.WriteLine("You are editing the person which is named "+ item.Name + " " + item.Surname + ". Are you sure? (y/n)") ;
                char enter = Convert.ToChar(Console.ReadLine()) ;
                if(enter == 'y')
                    {   Console.WriteLine("Enter new name");
                        string newName = Convert.ToString(Console.ReadLine()) ;
                        Console.WriteLine("Enter new surname");
                        string newSurName = Convert.ToString(Console.ReadLine()) ;
                        
                        Console.WriteLine(item.Name + " " + item.Surname +   " were changed" + newName + " " + newSurName) ;
                        item.Name = newName ;
                        item.Surname = newSurName ;
                     _contacts.Remove(item) ;
                     Console.WriteLine ("Press Enter to Continue") ;
                    Console.ReadLine() ;
                }else {

                }
                
            }
        
        
    }
    }
}