using System;

namespace StringsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings-advanced.md
            Console.WriteLine("1.");
            Console.WriteLine(GetMiddleLetters("a"));
            Console.WriteLine(GetMiddleLetters("ab"));
            Console.WriteLine(GetMiddleLetters("abc"));
            Console.WriteLine(GetMiddleLetters("abcd"));
            Console.WriteLine(GetMiddleLetters("abcde"));

            Console.WriteLine("2.");
            Console.WriteLine(CountOccurrencesOfChar("This iS a string", 's'));

            Console.WriteLine("3.");
            Console.WriteLine(GetPeopleWhoLikedItem(new string[0]));
            Console.WriteLine(GetPeopleWhoLikedItem(new[] {"John"}));
            Console.WriteLine(GetPeopleWhoLikedItem(new[] {"John", "Mary"}));
            Console.WriteLine(GetPeopleWhoLikedItem(new[] {"John", "Mary", "Liz"}));
            Console.WriteLine(GetPeopleWhoLikedItem(new[] {"John", "Mary", "Liz", "Dan"}));
            Console.WriteLine(GetPeopleWhoLikedItem(new[] {"John", "Mary", "Liz", "Dan", "Julia"}));

            Console.WriteLine("4.");
            Console.WriteLine(Ho());
            Console.WriteLine(Ho(Ho()));
            Console.WriteLine(Ho(Ho(Ho())));
            Console.WriteLine(Ho(Ho(Ho(Ho()))));
        }

        // 1.

        public static string GetMiddleLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            decimal middlePosition = input.Length / 2M;

            int roundedValue = (int) Math.Ceiling(middlePosition);

            if (middlePosition == roundedValue)
            {
                return input.Substring((int) middlePosition - 1, 2);
            }

            return input[roundedValue - 1].ToString();
        }

        //2.

        public static int CountOccurrencesOfChar(string input, char charToFind)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (charToFind.ToString().Equals(input[i].ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    count++;
                }
            }

            return count;
        }

        // 3.

        public static string GetPeopleWhoLikedItem(string[] persons)
        {
            if (persons.Length == 0)
            {
                return "No one likes this";
            }

            if (persons.Length == 1)
            {
                return persons[0] + " likes this";
            }

            if (persons.Length == 2)
            {
                return persons[0] + " and " + persons[1] + " like this";
            }

            if (persons.Length == 3)
            {
                return persons[0] + ", " + persons[1] + " and " + persons[2] + " like this";
            }

            return persons[0] + ", " + persons[1] + " and " + (persons.Length - 2) + " others like this";
        }

        // 4.

        public static string Ho()
        {
            return "Ho!";
        }

        public static string Ho(string input)
        {
            return "Ho " + input;
        }
    }
}