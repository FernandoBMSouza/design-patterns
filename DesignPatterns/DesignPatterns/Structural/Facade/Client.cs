using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.WriteLine(facade.Operation());
        }

        public void Main()
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
