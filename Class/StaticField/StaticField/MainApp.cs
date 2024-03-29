﻿using System;

namespace StaticField
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassB();
            new ClassA();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}
