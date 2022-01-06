using System;
using System.Collections ;

namespace TelephoneBook
{
    class Program
{
    

    
   static void Main(string[] args)
    {   var PhoneBook = new PhoneBook() ;
        
        contact a = new contact("Baris" ,"Gulyorek" , "154145") ;
        contact b = new contact("Hamza" ,"Zeyt" , "3513354") ;
        contact c = new contact("" ,"Hocam" , "6554666") ;
        contact d = new contact("Suleyman" ,"" , "5646543") ;
        contact e = new contact("Kara" ,"Cemal" , "56465463") ;
        PhoneBook.AddContact(a) ;
        PhoneBook.AddContact(b) ;
        PhoneBook.AddContact(c) ;
        PhoneBook.AddContact(d) ;
        PhoneBook.AddContact(e) ;

        int sel=0;
        
        string info ; 

        while (true)
        {  
            Console.Clear(); 
            Console.WriteLine("1 : enter information");
            Console.WriteLine("2 : delete information");
            
            Console.WriteLine("3 : edit information");
            Console.WriteLine("4 : display information");
            
            Console.WriteLine("5 : search information");
            
            Console.WriteLine("6 : exit");

            Console.Write("\nenter your choose : ");
           
            sel = Convert.ToInt32(Console.ReadLine());

            switch (sel)
            {
                case 1:
                     Console.Clear();
                     Console.Write("enter name : ");
                     string name = Convert.ToString(Console.ReadLine());

                     Console.Write("enter family : ");
                     string family = Convert.ToString(Console.ReadLine());

                     Console.Write("enter number : ");
                      string tel = Convert.ToString(Console.ReadLine());

                     contact newContact = new contact (name , family , tel) ;

                     PhoneBook.AddContact(newContact) ; 
                     
                    break;
                case 2:
                       { while (true)
                       {Console.Clear();
                         Console.WriteLine("Please write the name or surname of the contact which do you want to delete.") ;
                         info = Convert.ToString(Console.ReadLine()) ; 
                            try {PhoneBook.RemoveContact(info) ; 
                                    break ;
                            }
                            catch {
                                
                                Console.WriteLine("There is no matching with your searching word. Please select.") ;
                                Console.WriteLine("* Select for ending to delete operation :(1)") ;
                                Console.WriteLine("* Continue deleting operation   : (2)") ;
                                int Enter = Int32.Parse(Console.ReadLine()) ;
                                        if (Enter==1) 
                                        {
                                            break ;
                                        }
                                        else if (Enter == 2)
                                        {
                                            continue ;
                                        }
                                        
                            }}
                     break;}
                case 3:{ while (true)
                       {Console.Clear();
                         Console.WriteLine("Please write the name or surname of the contact which do you want to edit.") ;
                         info = Convert.ToString(Console.ReadLine()) ; 
                            try {PhoneBook.EditContact(info) ; 
                                    break ;
                            }
                            catch {
                                
                                Console.WriteLine("There is no matching with your entering word. Please select.") ;
                                Console.WriteLine("* Select to end for editing operation :(1)") ;
                                Console.WriteLine("* Continue editing operation   : (2)") ;
                                int Enter = Int32.Parse(Console.ReadLine()) ;
                                        if (Enter==1) 
                                        {
                                            break ;
                                        }
                                        else if (Enter == 2)
                                        {
                                            continue ;
                                        }
                                        
                            }}}
                    break;
                case 4:
                    Console.Clear() ;
                    PhoneBook.DisplayallContacts() ;
                    Console.ReadLine() ;
                    break;
                case 5:
                        {   Console.Clear() ;
                            Console.WriteLine("Please Select  for determining the type of searching parameters");
                            Console.WriteLine ("*******************************") ;
                            Console.WriteLine("Search by using name or surname: (1)");
                            Console.WriteLine("Search by using telephone number: (2)");

                         int n = 0 ;
                       
                        n = Convert.ToInt32(Console.ReadLine()) ;
                        
                        
                        switch (n)
                        { case 1 :  Console.Clear() ;
                                    Console.WriteLine ("Please write name or surname to search") ;
                                    info = Convert.ToString(Console.ReadLine()) ;
                                    Console.Clear () ;
                                    Console.WriteLine ("Results") ;
                                    Console.WriteLine ("*******************************") ;
                                    PhoneBook.DisplayMatchingContacts(info) ;
                                    Console.WriteLine ("Press Enter to Continue") ;
                                    Console.ReadLine() ;

                                 break ;       
                         case 2 :
                            Console.Clear() ;
                            Console.WriteLine ("Please enter a telephone number") ;
                             var searchnumber = Convert.ToString(Console.ReadLine()) ;
                
                             PhoneBook.DisplayContact(searchnumber) ;
                             Console.WriteLine ("Press Enter to Continue") ;
                             Console.ReadLine() ;
                            break;}}
                    break;
            }
            


}
    }}}






