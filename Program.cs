using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Problem3_LAWAAN
{

    public static class Program 
    {
        public static void Main() 
        {
           Console.WriteLine(" Welcome to Employee Time Keeping System");
           
            Console.WriteLine("*****************************************************");
            
            Console.WriteLine($"Today's Date: {DateTime.Today.ToShortDateString()}");

            Console.WriteLine();

            //time-in

            Console.Write("Time-in Enter your employee id:");
            string employeeId = Console.ReadLine();
            
            TimeSpan timeIn = new TimeSpan(8, 0, 0);
            Console.WriteLine($"Your login time is recorded: {timeIn}");

            //time-out

            Console.WriteLine("*********************************");
            Console.WriteLine();

            Console.Write("To log your time-out enter your employee id:");
            employeeId = Console.ReadLine();

            TimeSpan timeOut = new TimeSpan(16, 0, 0);
            Console.WriteLine($"Your time-out recorded: {timeOut}");

            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();

            //lunch break duration

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);

            //total number of hours employee worked

            TimeSpan totalHours = (timeOut - timeIn) - lunchBreakDuration;
            Console.WriteLine($"Your total hours worked is: {totalHours}");

            //total office working hours

            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);

            //late time-in computation

            TimeSpan lateIn = new TimeSpan(0, 0, 0);

            if (timeIn > regularHoursStart)
            {
                lateIn = timeIn - regularHoursStart;
            }

            //undertime time-out computation

            TimeSpan underTime = new TimeSpan(0, 0, 0);
            TimeSpan totalUndertime = new TimeSpan(0, 0, 0);

            if (timeOut < regularHoursEnd)
            {
                underTime = timeOut - regularHoursEnd;

                totalUndertime = regularHoursEnd - timeOut; 
            }

           
            //total of regular hours an employee has fulfilled

            TimeSpan totalRegularHours = totalHours - (lateIn - underTime);

            Console.WriteLine($"Your total regular hours worked is: {totalRegularHours}");

            Console.WriteLine($"Your total undertime: {totalUndertime}");

        }
    }
}
       
       
