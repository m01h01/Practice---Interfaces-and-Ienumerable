﻿namespace Practice___Interfaces_and_Ienumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolClass prog124 = new SchoolClass();
            foreach (Student student in prog124)
            {
                Console.WriteLine(student);
            }
        }
    }
}