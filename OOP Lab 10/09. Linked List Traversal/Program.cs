using LinkedListTraversal.Collections;
using System;
using System.Text;

namespace LinkedListTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            int operationCount;
            while (!int.TryParse(Console.ReadLine(), out operationCount) || operationCount < 1)
                Console.WriteLine("Number of operations should be a positive integer.");

            for (int i = 0; i < operationCount; ++i)
            {
                try
                {
                    var inputs = Console.ReadLine().Split(' ');
                    string command = inputs[0];
                    int number = int.Parse(inputs[1]);

                    switch (command)
                    {
                        case "Add":
                            {
                                list.Add(number);
                                break;
                            }
                        case "Remove":
                            {
                                list.Remove(number);
                                break;
                            }
                        default: throw new InvalidOperationException("Invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    --i;
                }
            }

            Console.WriteLine(list.Count);

            var strBuilder = new StringBuilder();

            foreach (var item in list)
                strBuilder.Append($"{item} ");

            Console.WriteLine(strBuilder.ToString().TrimEnd());

            Console.ReadKey();
        }
    }
}
