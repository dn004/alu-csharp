﻿using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i <= 98; i++)
        {
            Console.Write($"{i} = 0x{i:X2}\n");
        }
    }
}