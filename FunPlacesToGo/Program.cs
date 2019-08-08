using System;

namespace FunPlacesToGo
{
    class Program
    {
        static void Main(string[] args)
        {
         Start:
            Console.WriteLine("Hello. Please choose an activity.");
            Console.WriteLine("Press 1 for Action, 2 for Exploring, 3 for Danger, or 4 for Food.");
                        
                int result1;

                    if (int.TryParse(Console.ReadLine(), out result1))
                    {
                        if (result1 == 1)
                        Console.WriteLine("You've selected Action!");
                        else if (result1 == 2)
                            Console.WriteLine("You've selected Exploring!");
                        else if (result1 == 3)
                            Console.WriteLine("You've selected Danger!");
                        else if (result1 == 4)
                            Console.WriteLine("You've selected Food!");
                        else
                            Console.WriteLine("Incorrect response...");
                    }
                                    
         
                                    { 
                                    if (result1 == 1)
                            
                                        Console.WriteLine("You should go to a Boxing Match! How many people will be with you?");  
                            
                                    else if (result1 == 2)
                            
                                        Console.WriteLine("You should go Canoeing! How many people will be with you?");  
                            
                                    else if (result1 == 3)
                            
                                        Console.WriteLine("You should go Shark Diving! How many people will be with you?");
                            
                                    else if (result1 == 4)
                            
                                        Console.WriteLine("You should go to a Steakhouse! How many people will be with you?");
                                    else
                                        Console.WriteLine("Incorrect response...");
         
                                    }

                                            int result2;

         

                                                if (int.TryParse(Console.ReadLine(), out result2))
                                                {
                                                    if (result2 == 0)
                                                        Console.WriteLine("Riding solo? No problem, just be sure to travel in some decent sneakers!");

                                                    else if (result2 > 0 && result2 < 5)
                                                        Console.WriteLine("Fun with the besties? Roadtrip! Take a car and drive.");

                                                    else if (result2 >= 5 && result2 < 11)
                                                        Console.WriteLine("Bringing the whole crew? Take a bus!");

                                                    else if (result2 >= 11)
                                                        Console.WriteLine("That's a huge group! Take an airplane!");
                                                    else
                                                        Console.WriteLine("Incorrect response...");
         
                                                }

                                                    Console.WriteLine("Have a great time! Goodbye!");
            
         Console.ReadLine();
         goto Start;
            
        }
    }
}
