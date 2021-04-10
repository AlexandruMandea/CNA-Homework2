using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ZodiacService.Utilities
{
    public class Utility
    {
        public static string GetZodiacSign(string date, string filePath)
        {
            XmlReader reader = XmlReader.Create(@filePath);

            string[] dateParts = date.Split("/");
            int month = Int32.Parse(dateParts[0]);
            int day = Int32.Parse(dateParts[1]);
            int year = Int32.Parse(dateParts[2]);

            DateTime dateRecieved = new DateTime(year, month, day);

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name.ToString())
                    {
                        case "Sign":
                            string dateRead = reader.GetAttribute(1);
                            string[] dateReadParts = dateRead.Split(new char[] { '/', '-' });
                            DateTime intervalStart = new DateTime(year, Int32.Parse(dateReadParts[0]), Int32.Parse(dateReadParts[1]));
                            DateTime intervalEnd = new DateTime();
                            if (Int32.Parse(dateReadParts[0]) == 12)
                            {
                                intervalEnd = new DateTime(year + 1, Int32.Parse(dateReadParts[2]), Int32.Parse(dateReadParts[3]));
                            }
                            else
                            {
                                intervalEnd = new DateTime(year, Int32.Parse(dateReadParts[2]), Int32.Parse(dateReadParts[3]));
                            }
                            if (dateRecieved >= intervalStart && dateRecieved <= intervalEnd)
                            {
                                return reader.GetAttribute(0);
                            }
                            break;
                    }
                }
            }
            return "*null*";
        }
    }
}
