using System;
using System.Text.RegularExpressions;

namespace ZodiacClient
{
    class Program
    {
        private static bool IsDateValid(String date)
        {
            string[] dateParts = date.Split("/");
            int month = Int32.Parse(dateParts[0]);
            int day = Int32.Parse(dateParts[1]);
            int year = Int32.Parse(dateParts[2]);
            bool is_leap = false;
            bool is_valid = true;

            if (year >= 1800 && year <= 9999)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    is_leap = true;
                }

                if (month >= 1 && month <= 12)
                {
                    if (month == 2)
                    {
                        if (is_leap && day == 29)
                        {
                            is_valid = true;
                        }
                        else if (day > 28)
                        {
                            is_valid = false;
                        }
                    }
                    else if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        if (day > 30)
                        {
                            is_valid = false;
                        }
                    }
                    else if (day > 31)
                    {
                        is_valid = false;
                    }
                }
                else
                {
                    is_valid = false;
                }
            }
            else
            {
                is_valid = false;
            }

            if (is_valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string date;

            Console.WriteLine("Write a date (month/day/year):");
            date = Console.ReadLine();
            
            while(!IsDateValid(date))
            {
                Console.WriteLine("Invalid date. Write down another: ");
                date = Console.ReadLine();
            }
        }
    }
}
