using System;
using System.Reflection;

namespace BlackBox
{
    class Program
    {
        const BindingFlags nonPublicFlags = BindingFlags.NonPublic | BindingFlags.Instance;

        static void Main(string[] args)
        {
            var type = typeof(BlackBoxInteger);
            var box = Activator.CreateInstance(type, true);
            var field = type.GetField("innerValue", nonPublicFlags);

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "end")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var inputs = line.Split('_');

                try
                {
                    string method = inputs[0];
                    int parameter = int.Parse(inputs[1]);

                    type.GetMethod(method, nonPublicFlags).Invoke(box, new object[] { parameter });
                    Console.WriteLine(field.GetValue(box));
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Invalid method.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
