using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    internal class Client
    {
        public void Main()
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);
        }

        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
