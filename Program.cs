using System;

Console.Write("1-oraliqni kiriting: ");
short firstArgument = Convert.ToByte(Console.ReadLine());
Console.Write("2-oraliqni kiriting: ");
short lastArgument = Convert.ToByte(Console.ReadLine());

for(int i = 1; i <= 9; i++)
{
    for(int j = firstArgument; j <= lastArgument; j++)
    {
        Console.Write($"{j}*{i}={(j*i), -9}");
    }
    Console.WriteLine();
}