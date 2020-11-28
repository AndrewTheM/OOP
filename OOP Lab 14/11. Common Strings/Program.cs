using System;

namespace CommonStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine(),
                    secondInput = Console.ReadLine();

            string shorterStr = (firstInput.Length <= secondInput.Length)
                                ? firstInput
                                : secondInput;
            
            string longerStr = (firstInput.Length > secondInput.Length)
                                ? firstInput
                                : secondInput;

            bool common = false;

            if (longerStr.Contains(shorterStr))
            {
                common = true;
            }
            else
            {
                foreach (var ch in shorterStr)
                    if (longerStr.Contains(ch))
                    {
                        common = true;
                        break;
                    }
            }

            Console.WriteLine(common ? "yes" : "no");
            Console.ReadKey();
        }
    }
}
