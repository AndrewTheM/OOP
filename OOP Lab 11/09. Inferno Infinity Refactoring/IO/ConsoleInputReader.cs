using InfernoInfinity.Contracts.Wide;
using System;

namespace InfernoInfinity.IO
{
    public class ConsoleInputReader : IReader
    {
        public string Read() => Console.ReadLine();
    }
}
