using StackImplementation.Collections;
using System;
using System.Linq;

namespace StackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var inputs = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string command = inputs[0];

                try
                {
                    switch (command)
                    {
                        case "Push":
                            {
                                var items = inputs.Skip(1)
                                                    .Select(int.Parse)
                                                    .ToArray();

                                foreach (var item in items)
                                    stack.Push(item);
                                break;
                            }
                        case "Pop":
                            {
                                stack.Pop();
                                break;
                            }
                        default:
                            throw new InvalidOperationException("Invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < 2; ++i)
                foreach (var item in stack)
                    Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
