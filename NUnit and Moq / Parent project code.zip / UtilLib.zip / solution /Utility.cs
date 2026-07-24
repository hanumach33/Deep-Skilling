using System;

namespace UtilLib
{
    public class Utility
    {
        public bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public int Square(int number)
        {
            return number * number;
        }

        public int Cube(int number)
        {
            return number * number * number;
        }

        public string Reverse(string value)
        {
            if (value == null)
                return null;

            char[] chars = value.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }
    }
}
