using InfernoInfinity.Contracts.Wide;
using System;

namespace InfernoInfinity.IO
{
    public class ConsoleOutputWriter : IWriter
    {
        public void Write(string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
                Console.WriteLine(text);
        }
    }
}
