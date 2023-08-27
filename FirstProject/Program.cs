using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator BMI");
            Console.WriteLine("Podaj swoją masę ciała (w kg):");

            string massString = Console.ReadLine();
            double mass = double.Parse(massString);


            Console.WriteLine("Podaj swój wzrost (w metrach):");

            string heightString = Console.ReadLine();
            double height = double.Parse(heightString);

            double bmi = mass / (height * height);

            Console.WriteLine("Twój wynik BMI to: " + bmi);
            if(bmi < 18.5)
            {
                Console.WriteLine("Wyniki BMI to: niedowaga");
            }
            else if(bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Wyniki BMI to: waga normalna");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Wyniki BMI to: nadwaga");
            }
            else if (bmi >= 30 && bmi < 35)
            {
                Console.WriteLine("Wyniki BMI to: otyłość");
            }
            else
            {
                Console.WriteLine("Wyniki BMI to: otyłość olbrzymia");

            }
        }
    }
}


