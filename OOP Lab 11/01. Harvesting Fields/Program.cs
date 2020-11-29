using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HarvestingFields
{
    class RichSoilLand
    {
        private int testInt;
        public double testDouble;
        protected string testString;
        private long testLong;
        protected double aDouble;
        public string aString;
        private System.Globalization.Calendar aCalendar;
        public System.Text.StringBuilder aBuilder;
        private char testChar;
        public short testShort;
        protected byte testByte;
        public byte aByte;
        protected System.Text.StringBuilder aBuffer;
        private System.Numerics.BigInteger testBigInt;
        protected System.Numerics.BigInteger testBigNumber;
        protected float testFloat;
        public float aFloat;
        private System.Threading.Thread aThread;
        public System.Threading.Thread testThread;
        private object aPredicate;
        protected object testPredicate;
        public object anObject;
        private object hiddenObject;
        protected object fatherMotherObject;
        private string anotherString;
        protected string moarString;
        public int anotherIntBitesTheDust;
        private System.Exception internalException;
        protected System.Exception inheritableException;
        public System.Exception justException;
        public System.IO.Stream aStream;
        protected System.IO.Stream moarStreamz;
        private System.IO.Stream secretStream;
    }

    class Program
    {
        const BindingFlags nonPublicFlags = BindingFlags.NonPublic | BindingFlags.Instance;

        static void Main(string[] args)
        {
            var commands = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "HARVEST")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                switch (line)
                {
                    case "private":
                    case "public":
                    case "protected":
                    case "all":
                        {
                            commands.Add(line);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid modifier.");
                            break;
                        }
                }
            }

            var type = typeof(RichSoilLand);

            foreach (var command in commands)
            {
                Console.WriteLine();

                var fields = command switch
                {
                    "private" => type.GetFields(nonPublicFlags)
                                    .Where(f => f.IsPrivate),
                    "protected" => type.GetFields(nonPublicFlags)
                                    .Where(f => f.IsFamily),
                    "public" => type.GetFields(),
                    "all" => type.GetFields(BindingFlags.Public | nonPublicFlags),
                    _ => null
                };

                foreach (var field in fields)
                {
                    string modifier = command;

                    if (command == "all")
                    {
                        if (field.IsPrivate)
                            modifier = "private";
                        else if (field.IsFamily)
                            modifier = "protected";
                        else if (field.IsPublic)
                            modifier = "public";
                        else
                            modifier = "<unknown>";
                    }

                    Console.WriteLine($"{modifier} {field.FieldType.Name} {field.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
