using System;
// Author: Jenna Ptak
// Date 2/6/2022
// Assignment T-3- CAD to USD Currency Converter

namespace T3_Assignment_JennaPtak
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double conversion;
            double usd; 
            // Ask the user for $ input
            Console.Write("Enter a CAD increment value: ");
            // Use try catch block to validate user input
            try
            {
                //gather data from user input
                string input = Console.ReadLine();
                //Perform interative statements
                int cad_value = int.Parse(input);
                // If the calue of the input is between 0 and 25, execute for loop
                if ((cad_value > 5) && (cad_value <= 25)) 
                {
                    // declare cad to usd conversion rate
                    conversion = 0.792367;
                    //Write the CAD Increment Value to the table
                    Console.WriteLine("CAD Increment Value = " + input +"\n");
                    //write the header of the table 
                    Console.WriteLine("CAD" + "\t" + "US$"); 
                    // for loop
                    for (int i = 0; i <= 200; i = i + cad_value) 
                    {
                        //calculate usd based on loop value and conversion rate
                        usd = i * conversion;
                        //write data to table
                        string msg = i.ToString() + "\t" + usd;
                        Console.WriteLine(msg);
                    }
                }
                else
                {
                    // error message if user doesn't enter a value between 5 and 25
                    Console.WriteLine("Please enter a CAD increment value between 5 and 25");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            } // end of try
            catch
            {
                // error message
                Console.WriteLine("Please enter a CAD increment value between 5 and 25");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } // end of catch
        } // end of main
    } // end of class
} // end of namespace
