using System;

namespace ConsoleApp1
{
    public class HelloService : IHelloService
    {
        public void SayHello()
        {
            Console.Write("Hello !");
            Console.Read();
        }
    }
}
