using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES
            string car1 = "BMW";
            string car2 = "range rover ";
            string car3 = "volswagen golf7 ";
            string car4 = "hyundai i10";
            string car5 = "kia picanto";
            string comm = "t3aml hna ghir talaba";
           

            int prixcar1 = 250;
            int prixcar2 = 1000;
            int prixcar3 = 550;
            int prixcar4 = 300;
            int prixcar5 = 200;

            while (true)
            {

                Console.WriteLine("Hi in our Rent System !! \n ");
                Console.WriteLine("Please enter your full name: ");
                string fullname = Console.ReadLine();
                Console.WriteLine("hello ,mr " + fullname);
                Console.WriteLine("Please enter your age: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 18)
                {
                    Console.WriteLine("You can't continue your are Minor (under legal age)");
                }

                else if (age >= 18)
                {


                    Console.WriteLine("Enter your Driving License Serial:  ");
                    string lisencecode = Console.ReadLine();

                    if  (lisencecode == "no" || lisencecode == "0" || lisencecode=="non")
                    {
                        Console.WriteLine("Sorry you cant continue, you dont have a liscence id");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter your Id card:  ");
                        string card = Console.ReadLine();

                        Console.WriteLine("this is our available cars choose: \n ");
                        Console.WriteLine(car1);
                        Console.WriteLine(car2);
                        Console.WriteLine(car3);
                        Console.WriteLine(car4);
                        Console.WriteLine(car5);




                        Console.WriteLine("choose wish car you need by taping (dacia, volswagen...) ");
                        string order = Console.ReadLine();
                        if (order == "dacia sandero")
                        {
                            Console.WriteLine("You choose: " + car1);
                            Console.WriteLine($"the price of a rent day is {prixcar1}");
                           
                        }
                        else if (order == "range rover" || order=="evoque")
                        {
                            Console.WriteLine("you choose: " + car2);
                            Console.WriteLine($"the price of a rent day is {prixcar2}");
                           
                        }
                        else if (order == "volswagen " || order=="golf7")
                        {
                            Console.WriteLine("you choose: " + car3);
                            Console.WriteLine($"the price of a rent day is {prixcar3}");
                            
                        }
                        else if (order == "hyundai" || order=="i10")
                        {
                            Console.WriteLine("you choose: " + car4);
                            Console.WriteLine($"the price of a rent day is {prixcar4} ");
                            
                        }
                        else
                        {
                            Console.WriteLine("you choose: " + car5);
                            Console.WriteLine($"the price of a rent day is {prixcar5}");
                            
                        }
                        Console.WriteLine($"are you sure you want {order} (Yes/No) : ");
                        string ha =Console.ReadLine();
                        if (ha == "Yes") { 
                      


                        Console.WriteLine("how many day you need the car");
                        int day = int.Parse(Console.ReadLine());


                        Console.WriteLine("Confirm the rent: (Yes / No)");
                        string KEY= Console.ReadLine();
                        if (KEY == "Yes" )
                        {
                            Console.WriteLine($"Done! you own this car for {day} days");
                           


                        }
                        else 
                        {
                            Console.WriteLine("something went wrong please try again");
                        }
                       
                      
                        int prix = int.Parse(Console.ReadLine());

                        
                    }
                }
                }
                else
                {
                    Console.WriteLine("bye");
                }

                Console.ReadLine();
            }
            }
        }
}
