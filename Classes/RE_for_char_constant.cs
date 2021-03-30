using System;
using System.Text.RegularExpressions;

namespace Regular_Expression.Classes
{
    class RE_for_char_constant
    {
        public static void char_RE()
        {
            Console.Write("Enter valid char: ");
            string input = Console.ReadLine();
            string pattern = "^$";
            Regex regex = new Regex(pattern);
            bool result = regex.IsMatch(input);

            if (result)
            {
                Console.WriteLine($"{input} is a valid char.");
            }
            else
            {
                Console.WriteLine($"{input} is an invlid char.");
            }
        }
    }
}
