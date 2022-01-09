using System;
using Exceptions;

namespace ExceptionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the dog name:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Please insert the dog age");
            int ageInput =  Convert.ToInt32(Console.ReadLine());

            try
            {
                Dog dg = new Dog(nameInput, ageInput);
            }
            catch (NegativeAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverAgeLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ShortNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("I wish you a great day!");
        }
    }
}
