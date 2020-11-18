using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseProect
{
    public class SwitchCase
    {
        public void Example()
        {
            Console.Write("Enter a Number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Case 1 select");
                    Console.WriteLine("Case 1 select-2");
                    break;
                case 2:
                    Console.WriteLine("Case 2 select");
                    Console.WriteLine("Case 2 select-2");
                    break;
                case 3:
                    Console.WriteLine("Case 3 select");
                    Console.WriteLine("Case 3 select-2");
                    break;
                case 4:
                    Console.WriteLine("Case 4 select");
                    Console.WriteLine("Case 4 select-2");
                    break;

                default:
                    Console.WriteLine("Default select");
                    break;
            }
        }
    }
}
