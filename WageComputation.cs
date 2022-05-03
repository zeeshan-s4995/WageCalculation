using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WageCalculation
{
    public class WageComputation
    {
        int WAGE_PER_HOUR = 20;
        int FULL_DAY_HOUR = 8;
        int PART_TIME_HOUR = 4;
        bool IsPresent;
        bool IsFullTime;
        Random generateNum = new Random();

        public void CheckEmpIsPresentOrNot()
        {
            int num = generateNum.Next(0, 2); // 0 or 1 
            if (num == 1)
            {
                IsPresent = true;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                IsPresent = false;
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
