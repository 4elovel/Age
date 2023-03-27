using System;
using static System.Console;
class MyClass
{
    static void Main()
    {
        Int16 x;
        Int16 y;
        Int16 z;
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                for(int k = 1; k < 10; k++)
                {
                    if (i + j + k == 13 && i * j * k == 36)
                    {
                        WriteLine($"First: {i} Second: {j} Third:{k}");
                    }
                }
            }
        }
    }
}