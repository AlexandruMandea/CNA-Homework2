using Grpc.Net.Client;
using System;
using System.Text.RegularExpressions;
using ZodiacService.Protos;

namespace ZodiacClient
{
    class Program
    {
        private enum Season
        { 
            Winter,
            Spring,
            Summer,
            Autumn,
            _NULL
        };

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

        private static Season GetSeason(string date)
        {
            string[] dateParts = date.Split("/");

            int month = Int32.Parse(dateParts[0]);

            switch (month)
            {
                case 12: case 1: case 2:
                    return Season.Winter;
                case 3: case 4: case 5:
                    return Season.Spring;
                case 6: case 7: case 8:
                    return Season.Summer;
                case 9: case 10: case 11:
                    return Season.Autumn;
            }

            return Season._NULL;
        }

        static void Main(string[] args)
        {
            string date = "*null*";
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            string response = "*null*";

            Console.WriteLine("Write a date (month/day/year):");
            date = Console.ReadLine();

            while (!IsDateValid(date))
            {
                Console.WriteLine("Invalid date. Write another one: ");
                date = Console.ReadLine();
            }

            switch (GetSeason(date))
            {
                case Season.Winter:
                    var client1 = new ZodiacSignTellerWinter.ZodiacSignTellerWinterClient(channel);
                    var input1 = new DateRequestWinter();

                    input1.Date = date;
                    response = client1.SayZodiacSign(input1).ToString();
                    break;

                case Season.Spring:
                    var client2 = new ZodiacSignTellerSpring.ZodiacSignTellerSpringClient(channel);
                    var input2 = new DateRequestSpring();

                    input2.Date = date;
                    response = client2.SayZodiacSign(input2).ToString();
                    break;

                case Season.Summer:
                    var client3 = new ZodiacSignTellerSummer.ZodiacSignTellerSummerClient(channel);
                    var input3 = new DateRequestSummer();

                    input3.Date = date;
                    response = client3.SayZodiacSign(input3).ToString();
                    break;

                case Season.Autumn:
                    var client4 = new ZodiacSignTellerAutumn.ZodiacSignTellerAutumnClient(channel);
                    var input4 = new DateRequestAutumn();

                    input4.Date = date;
                    response = client4.SayZodiacSign(input4).ToString();
                    break;
            }

            Console.WriteLine(response);

            Console.ReadLine();
        }
    }
}
