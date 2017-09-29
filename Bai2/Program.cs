using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Domain to IP
            string Host;
            Console.WriteLine("Input domain name:");
            Host = Console.ReadLine();

            foreach (IPAddress ip in Dns.GetHostAddresses(Host))
            {
                Console.WriteLine("Domain's IP Address:" +ip.ToString());
            }
            //IP to Domain
            string IPAdd;
            Console.WriteLine("Input IP Address: ");
            IPAdd = Console.ReadLine();

            foreach (IPHostEntry ip in Dns.GetHostByName(IPAdd))
            {
                Console.WriteLine("Domain's name:" + ip.ToString());
            }

        }
    }
}
