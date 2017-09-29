using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get local host name
            String StrHostName = string.Empty;
            StrHostName = Dns.GetHostName();
            Console.WriteLine("Ten may: " + StrHostName);
            //Get IP Address
            IPHostEntry ipEntry = Dns.GetHostEntry(StrHostName);
            IPAddress[] addr = ipEntry.AddressList;
            foreach (IPAddress ip4 in addr.Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork))
            {
                Console.WriteLine(ip4.ToString());
            }  
            Console.ReadLine();

        }
    }
}
