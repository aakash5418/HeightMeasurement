using ClosestHeight;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace closestHeight
{
    public static class Program
    {
        public static void Main()
        {
            double result = ClosestTo(Persons());
            Console.WriteLine("Closest Height : " + result);
        }
        public static double ClosestTo(List<Persons> collection)
        {
            double closest = double.MaxValue;
            double minDifference = double.MaxValue;
            double sum = 0;
            double average = 0.0;
            int i = 0;
            collection.Sort(delegate (Persons p1, Persons p2) { return p1.height.CompareTo(p2.height); });
            foreach (var element in collection)
            {
                while (i < collection.Count)
                {
                    sum += collection[i].height;
                    i++;
                }
                average = sum / collection.Count();
                var difference = Math.Abs((double)element.height - average);
                difference = Math.Round(difference,2);
               if (minDifference > difference)
                {
                    minDifference = (int)difference;
                    closest = element.height;
                }
            }
            return closest;
        }
        public static List<Persons> Persons()
        {
            try
            {
                List<Persons> lstperson = new List<Persons>();
                Console.WriteLine("Enter The PersonCount:");
                var personCount = int.Parse(Console.ReadLine());
                double sum = 0;

                for (int i = 0; i < personCount; i++)
                {
                    var person = new Persons();
                    Console.WriteLine("Enter The Name :");
                    person.name = Console.ReadLine();
                    Console.WriteLine("Enter The Height:");
                    person.height = Convert.ToDouble(Console.ReadLine());
                    lstperson.Add(person);
                    sum += person.height;
                }
                Console.WriteLine("Sum of PersonHeight : " + sum);
                double average = sum / lstperson.Count();
                Console.WriteLine("Average Height of All Person: " + average);


                return lstperson;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

    }
}
