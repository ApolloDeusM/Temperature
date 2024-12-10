using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Converter
{

  static void Main()
  {
        bool Repeatconversion = true;
        bool Newconversion = true;

    while (Newconversion)
    {
            double result = 0;

            Console.WriteLine("Welcome to the Temperature converter!");

            Console.WriteLine("Write the Original Temperature Format in Degrees C,F or K");
            string Originaltemperature = Convert.ToString((Console.ReadLine()));
            string uppercase1 = Originaltemperature.ToUpper();

            Console.WriteLine("Write the Final Temperature Format(C, F or K)");
            string Finaltemperature = Convert.ToString((Console.ReadLine()));
            string uppercase2 = Finaltemperature.ToUpper();

            while (Repeatconversion)
            {
                Console.WriteLine("Write the numerical Temperature value to be converted");
                double value = Convert.ToDouble(Console.ReadLine());
                string unit = null;


                if (uppercase1 == "C" && uppercase2 == "F")
                {
                    result = (value * 9 / 5) + 32;
                    unit = "Degrees Fahrenheit";
                }

                else if (uppercase1 == "C" && uppercase2 == "K")
                {
                    result = value + 273;
                    unit = "Kelvin";
                }

                else if (uppercase1 == "F" && uppercase2 == "C")
                {
                    result = (value - 32) * 5 / 9;
                    unit = "Degrees Centigrade";
                }

                else if (uppercase1 == "F" && uppercase2 == "K")
                {
                    result = ((value - 32) * 5 / 9) + 273;
                    unit = "Kelvin";
                }

                else if (uppercase1 == "K" && uppercase2 == "C")
                {
                    result = value - 273;
                    unit = "Degrees Centigrade";
                }

                else if (uppercase1 == "K" && uppercase2 == "F")
                {
                    result = ((9 / 5) * (value - 273)) + 32;
                    unit = "Degrees Fahrenheit";
                }

                else
                {
                    Console.WriteLine("Syntax Error!");
                }

                Console.WriteLine(" ");
                Console.WriteLine($"Your Resulting Temperature is: {result} {unit}");


                Console.WriteLine(" ");
                Console.WriteLine("PRESS:");
                Console.WriteLine("'R' TO REPEAT THE SAME CONVERSION");
                Console.WriteLine("'N' FOR A NEW CONVERSION");
                Console.WriteLine("'X' TO END THE SESSION");

                char rConvert = Convert.ToChar(Console.ReadLine());
                char nConvert = Convert.ToChar(Console.ReadLine());

                Repeatconversion = false;
                if (rConvert == 'R' || rConvert == 'r')
                {
                    Repeatconversion = true;
                    
                }
            };
            
            

            


    };

        

  }
}