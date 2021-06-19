using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochanda_code
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralCoding generalCoding = new GeneralCoding();
            generalCoding.PrintTheNumbersInFormat();
            Console.ReadKey();
        }
        class GeneralCoding
        {
            public void PrintTheNumbersInFormat()
            {

                for (int number = 1; number <= 100; number++)
                {
                    //checking for the condition multiple by 3
                    if (number % 3 == 0)
                    {
                        if (Math.Abs(number) % 10 == 6) //checking for the condition multiple by 3  & checking for the last number
                        {
                            Console.WriteLine("{0} multiple of 3, ends in 6", number);
                        }
                        else // statisfied condition multiple by 3
                        {
                            Console.WriteLine("{0} multiple of 3 ", number);

                        }
                    }
                    else if (Math.Abs(number) % 10 == 6) // checking for the last number
                    {
                        Console.WriteLine("{0} ends in 6", number);
                    }
                }

                //1st question:
                //Yes, its possible. we can use object array.
                var mixed = new object[2];
                mixed[0] = 3;
                mixed[1] = "3";

                foreach (var item in mixed)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.ReadKey();

            }
            //2nd question
            public bool IsDave(string sample)
            {
                if (!string.IsNullOrEmpty(sample))
                {
                    if (sample == "Dave")
                    {
                        return true;
                    }
                }
                return false;
            }

        }
        //3rd question
        // Yes, Below are the modified code.
        public bool IsDave(string sample)
        {
            return !string.IsNullOrEmpty(sample) && sample == "Dave";
        }

        //4th question
        // we can use regular expression too but not recommend in this scenario 
        public void brands()
        {
            string[] brands = { "Volvo", "BMW", "Ford", "Mazda", "Fait", "Bently" };
            //way 1
            string[] brandstartswithF = brands.Where(obj => obj[0] == 'F').ToArray();
            //way 2
            List<string> brandstartswithFList = new List<string>();
            foreach (string brand in brands)
            {
                if (brand[0] == 'F')
                {
                    brandstartswithFList.Add(brand);

                }
            }
            //way 3
            List<string> brandstartswithFList2 = new List<string>();
            foreach (string brand in brands)
            {
                if (brand.StartsWith("F"))
                {
                    brandstartswithFList2.Add(brand);
                }
            }


        }

        //5th question
        public void circle()
        {
            Func<double, double> func = CircumferenceOfCircle;
            Circle circle = new Circle();
            circle.radius = 10.0;
            double result = circle.Caluclate(func);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static double CircumferenceOfCircle(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public sealed class Circle
        {
            public double radius;

            public double Caluclate(Func<double, double> op)
            {
                return op(radius);
            }
        }


        
    }
}


