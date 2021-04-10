using Grpc.Net.Client;
using System;
using System.Text.RegularExpressions;
using ZodiacService.Protos;

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
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ZodiacSignTellerWinter.ZodiacSignTellerWinterClient(channel);

            var input = new DateRequestWinter();

            Console.WriteLine("Write a date (month/day/year):");
            input.Date = Console.ReadLine();

            while (!IsDateValid(input.Date.ToString()))
            {
                Console.WriteLine("Invalid date. Write another one: ");
                input.Date = Console.ReadLine();
            }

            var response = client.SayZodiacSign(input);



            /*Console.WriteLine($"Write your name:");
            input.Name = Console.ReadLine();
            Console.WriteLine($"Write your id:");
            id = Console.ReadLine();
            input.Id = ValidateId(id);

            var proccess = await client.ShowInformationAsync(input);
            var response = await client.RecieveDataAsync(input);
*/
            Console.WriteLine(response);

            Console.ReadLine();
        }
    }
}
