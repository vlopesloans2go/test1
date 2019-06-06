using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IHelloService, HelloService>();

            var serviceInstance = container.Resolve<IHelloService>();

            Console.Write(serviceInstance.GetSayHelloMsg());

            Console.Read();
        }
    }
}
