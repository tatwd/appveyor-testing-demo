using HelloVayor.Common;
using System;

namespace HelloAppVayor.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Demo.Hello("Jaron King");
            Console.WriteLine(name);
        }
    }
}
