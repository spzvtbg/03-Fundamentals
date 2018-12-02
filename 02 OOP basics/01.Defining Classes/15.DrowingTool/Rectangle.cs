﻿using System;

public class Rectangle : Figure
{
    public Rectangle(params int[] parameters) : base(parameters) { }

    public override void Drow()
    {
        for (int i = 0; i < base.Parameters[1]; i++)
        {
            Console.Write("|");
            for (int j = 0; j < base.Parameters[0]; j++)
            {
                if (i == 0 || i == base.Parameters[1] - 1)
                {
                    Console.Write('-');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine("|");
        }
    }
}
