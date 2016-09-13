﻿using System;



class MethodLibraries
{
    static string readString(string prompt)
    {
        string result;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine();
        } while (result == "");
        return result;
    }

    static int readInt(string prompt, int low, int high)
    {
        int result;

        do
        {
            string intString = readString(prompt);
            result = int.Parse(intString);
        } while ((result < low) || result > high);

        return result;
    }

    static void Main(string[] args)
    {
        string name;
        name = readString("Enter yur name : ");
        Console.WriteLine("Name: " + name);

        int age;
        age = readInt("Enter your age : ", 0, 100);
        Console.WriteLine("Age : " + age);
    }
}

