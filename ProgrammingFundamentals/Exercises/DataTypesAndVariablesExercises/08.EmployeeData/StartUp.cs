﻿namespace _08.EmployeeData
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long persIdNumber = long.Parse(Console.ReadLine());
            decimal uniqEmployeeNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {persIdNumber}");
            Console.WriteLine($"Unique Employee number: {uniqEmployeeNum}");
        }
    }
}
