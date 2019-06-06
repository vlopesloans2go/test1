using System;

namespace ConsoleApp1
{
    public class HelloService : IHelloService
    {
        public string GetSayHelloMsg()
        {
            return "Hello !";
        }
    }
}
