using System;
using System.Text.RegularExpressions;

namespace Regular_Expression.Classes
{
    class RE_for_url
    {
        public static void url_RE()
        {
            Console.Write("Enter valid url: ");
            string input = Console.ReadLine();
            string pattern = "^[+-]?[0-9]+[.][0-9]+$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(input);

            if (result)
            {
                Console.WriteLine($"{input} is a valid url.");
            }
            else
            {
                Console.WriteLine($"{input} is an invlid url.");
            }
        }
    }
}
