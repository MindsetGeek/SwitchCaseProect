using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseProect
{
    public class ExcerciseOne
    {
        public void UserInput()
        {
            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int returnvalue = CheckCondition(number);

            Console.WriteLine(returnvalue);
        }

        public int CheckCondition(int num)
        {
            if (num > 100)
            {
                return 3 * (num-100);
            }
            return num;

        }
    }
}
