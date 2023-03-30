using System;
using System.Text.RegularExpressions;

namespace BelowAndAboveAverage
{
    public class Program
    {
        public static void Main()
        {
            try
            {

                double average;
                double sum = 0;
                int below = 0;
                int above = 0;
                int res = 0;
                Console.WriteLine("Enter the Count:");
                var personCount = int.Parse(Console.ReadLine());
                string[] person = new string[personCount];
                double[] height = new double[personCount];

                for (int i = 0; i < personCount; i++)
                {
                    Console.WriteLine("Enter the Name:");
                    person[i] = (Console.ReadLine());


                    while (string.IsNullOrEmpty(person[i]) || int.TryParse(person[i], out res) == true)
                    {
                        Console.WriteLine("Please Give  Correct Input");
                        Console.Write("Enter a Name : ");
                        person[i] = Console.ReadLine();
                    }

                    Console.WriteLine("Enter the Height:");
                    string hght = Console.ReadLine();
                    double hghtval = 0.0;
                    var regexItem = new Regex("^[0-9]{1,2}([.][0-9]{1,2})?$");

                    while (!regexItem.IsMatch(hght))
                    {
                        height[i] = hghtval;
                        Console.WriteLine("Enter The Numbers only");
                        Console.WriteLine("Enter The Height");
                        hght = Console.ReadLine();
                    }
                    while (double.TryParse(hght, out hghtval) == false)
                    {
                        height[i] = hghtval;
                        Console.WriteLine("Enter The Numbers only");
                        Console.WriteLine("Enter The Height");
                        hght = Console.ReadLine();
                    }
                    height[i] = hghtval;

                    sum += height[i];

                }
                average = sum / height.Length;
                Console.WriteLine("average:" + average);

                for (int i = 0; i < personCount; i++)
                {
                    //ternary operator 
                    //(discard of int)indicates that our code never uses the variable.
                    _ = (height[i] < average) ? below++ : above++;

                }
                Console.WriteLine("Above:" + above);
                Console.WriteLine("Below:" + below);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Vaild Input");
                Main();
            }
        }
    }
}

