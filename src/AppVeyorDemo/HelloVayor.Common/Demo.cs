using System;

namespace HelloVayor.Common
{
    public class Demo
    {
        public static string Hello(string name)
        {
            Console.WriteLine($"{name} Hello AppVayor!");
            return name;
        }
    }
}
