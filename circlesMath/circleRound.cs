using System;
using System.Collections.Generic;
using System.Text;

namespace circlesMath
{
    internal class circleRound
    {
        public List<circle> cRound { get; set; } = new List<circle>();

        public double welcome(string prompt)
        {
            Console.Write(prompt);
            double rad = 0;

            bool answer = true;
            while (answer)
            {
                if (double.TryParse(Console.ReadLine(), out rad))
                {
                    answer = false;
                    return rad;
                }
                else
                {
                    Console.WriteLine("Invalid input, Enter only numbers:");
                }
            }

            return rad;
        }

        public double CalculateCircumference(double rad)
        {
            double cir = Math.PI * 2 * rad;
            return cir;
        }

        public string CalculateFormattedCircumference(double cir)
        {
            string fCir = Convert.ToString(Math.Round(cir, 2));
            return fCir;
        }

        public double CalculateArea(double rad)
        {
            double are = Math.PI * (Math.Pow(rad, 2));
            return are;
        }

        public string CalculateFormattedArea(double are)
        {
            string fAre = Convert.ToString(Math.Round(are, 2));
            return fAre;
        }

        public void newCircle(double rad, string fAre, string fCir)
        {
            cRound.Add(new circle(rad, fAre, fCir));
            Console.WriteLine($"\nCircumference: {fCir}");
            Console.WriteLine($"Area: {fAre}");
        }

        public void lookUp()
        {
            Console.WriteLine("\nGoodbye!");
            Console.WriteLine($"You created {cRound.Count} Circle object(s)!");
        }

        public void loop()

        {
            bool safe = true;
            while (safe)
            {
                double rad = welcome("Welcome to the Circle Tester!\nEnter radius: ");
                double are = CalculateArea(rad);
                double cir = CalculateCircumference(rad);
                string fAre = CalculateFormattedArea(are);
                string fCir = CalculateFormattedCircumference(cir);
                newCircle(rad, fAre, fCir);
                Console.WriteLine("\nDo you want to create another circle? (Enter: y/n)");
                string checking = Console.ReadLine().ToLower();

                bool tested = true;
                while (tested)
                {
                    if (checking == "y")
                    {
                        Console.WriteLine();
                        tested = false;
                        safe = true;
                    }
                    else if (checking == "n")

                    {
                        lookUp();
                        tested = false;
                        safe = false;
                    }
                    else
                    {
                        Console.WriteLine("Please only enter: y/n");
                        checking = Console.ReadLine();
                    }
                }
            }
        }
    }
}