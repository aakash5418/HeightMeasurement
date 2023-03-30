using System;
using System.Text.RegularExpressions;

namespace SecondTallestPerson
{
    class Program
    {
        public static void Main()
        {
            try
            {
                var firstTallestHeight = 0.0;
                var secondTallestHeight = 0.0;
                var firstTallestPersonName = " ";
                var secondTallestPersonName = " ";
                Console.WriteLine("Enter The Personcount");
                var personCount = int.Parse(Console.ReadLine());
                string[] person = new string[personCount];
                double[] height = new double[personCount];
                int res = 0;
                for (int i = 0; i < personCount; i++)
                {
                    Console.WriteLine("Enter The Name ");
                    person[i] = Console.ReadLine();
                    while (string.IsNullOrEmpty(person[i]) || int.TryParse(person[i], out res) == true)
                    {

                        Console.WriteLine("Please Give  Correct Input");
                        Console.Write("Enter a Name : ");
                        person[i] = Console.ReadLine();
                    }

                    Console.WriteLine("Enter The Height");
                    string hght = Console.ReadLine();
                    double hghtval = 0.0;
                    var regexItem = new Regex("^[0-9]{1,2}([.][0-9]{1,2})?$");

                    while (!regexItem.IsMatch(hght))
                    {
                        Console.WriteLine("Enter The Numbers only");
                        Console.WriteLine("Enter The Height");
                        hght = Console.ReadLine();
                    }
                    //while (double.TryParse(hght, out hghtval) == false)
                    //{
                    //    height[i] = hghtval;
                    //    Console.WriteLine("Enter The Numbers only");
                    //    Console.WriteLine("Enter The Height");
                    //    hght = Console.ReadLine();
                    //}
                    height[i] = hghtval;

                    if (height[i] > firstTallestHeight)
                    {
                        secondTallestHeight = firstTallestHeight;
                        firstTallestHeight = height[i];
                        secondTallestPersonName = firstTallestPersonName;
                        firstTallestPersonName = person[i];
                    }
                    else if (height[i] > secondTallestHeight)
                    {
                        secondTallestPersonName = person[i];
                        secondTallestHeight = height[i];
                    }
                }
                Console.WriteLine("Second Tallest Perosn is " + secondTallestPersonName + " " + secondTallestHeight);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter Vaild Input");
                Main();
            }
        }
    }
}
