using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // feeding the neighborhood - calculate pb&j sandwiches
            
            string again = "y";

            int slcBread = 2;
            int spJelly = 4;
            int spPb = 2;

            int loafBread = 28;
            int jarJelly = 48;
            int jarPb = 32;


            while (again == "y")
            {

                // Ask user input 
                Console.WriteLine();
                Console.WriteLine("Hi There! Let's get ready to feed the neighborhood.\n");
                Console.WriteLine("How many people are we making PB & Js for?");

                // take user input
                string input = Console.ReadLine();
                int numPpl;
                Int32.TryParse(input, out numPpl);

                int ttlBread = slcBread * numPpl;
                int ttlJelly = spJelly * numPpl;
                int ttlPb =  spPb * numPpl;

                // test user input
                Console.WriteLine();
                Console.WriteLine($"Awesome! with {numPpl} showing up, you need:\n");

                Console.WriteLine(ttlBread + " pieces of bread");
                Console.WriteLine(ttlJelly + " spoonfuls of jelly");
                Console.WriteLine(ttlPb + " spoonfuls of peanut butter\n");


                Console.WriteLine("\t which is...\n");

                // calculate total of ingredients and store as double
                double ttlLoaf = ((double)ttlBread) / ((double)loafBread);
                double ttlJarJelly = ((double)ttlJelly) / ((double)jarJelly);
                double ttlJarPb = ((double)ttlPb) / ((double)jarPb);


                // store and output result rounded up
                double resultLoaf = Math.Ceiling(ttlLoaf);
                double resultJelly = Math.Ceiling(ttlJarJelly);
                double resultPb = Math.Ceiling(ttlJarPb);

                Console.WriteLine($"\t {resultLoaf} loaves of bread");
                Console.WriteLine($"\t {resultJelly} jars of jelly");
                Console.WriteLine($"\t {resultPb} jars of peanut butter\n\n");


                Console.WriteLine("Do we need to calculate that again?\n\n");
                Console.WriteLine("Enter Y to calculate again");
                Console.WriteLine("Any other key to quit");
                again = Console.ReadLine();
               


                if (again != "y")
                {
                    Console.WriteLine("GoodBye!\n\n");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadLine();
                    break;
                }
            }

          

        }
    }
}


