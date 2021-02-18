using System;
using System.Reflection;
using GetString.Interface;

namespace GetString.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("GetString.Library.dll");
            Type type = assembly.GetType("GetString.Library.MyLibrary");
            MyInterface instance = (MyInterface)Activator.CreateInstance(type);

            Console.WriteLine(instance.GetString());
            Console.ReadKey();
        }
    }
}
