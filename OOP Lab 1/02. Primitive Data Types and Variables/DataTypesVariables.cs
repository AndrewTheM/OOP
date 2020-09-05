using System;

class DataTypesVariables
{
    static void Main()
    {
        Problem5();

        Console.WriteLine();

        Problem6();

        Console.WriteLine();

        Problem7();

        Console.ReadKey();
    }

    static void Problem5()
    {
        sbyte value1 = -100;
        byte value2 = 128;
        short value3 = -3540;
        ushort value4 = 64876;
        uint value5 = 2147483648;
        int value6 = -1141583228;
        long value7 = -1223372036854775808;

        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value5);
        Console.WriteLine(value6);
        Console.WriteLine(value7);
    }

    static void Problem6()
    {
        decimal value1 = 3.141592653589793238M;
        double value2 = 1.60217657;
        decimal value3 = 7.8184261974584555216535342341M;

        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    static void Problem7()
    {
        string value1 = "Software University";
        char value2 = 'B',
            value3 = 'y',
            value4 = 'e';
        string value5 = "I love programming";

        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
        Console.WriteLine(value4);
        Console.WriteLine(value5);
    }
}
