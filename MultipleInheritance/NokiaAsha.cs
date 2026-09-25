using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class NokiaAsha : INokia, INewNokia // Multiple inheritance
    {
       

        public void Call()
        {
            Console.WriteLine("We can make a call.");
        }

        public void SendSms()
        {
            Console.WriteLine("We can send sms.");
        }
        public void Bluetooth()
        {
            Console.WriteLine("We can use bluetooth.");
        }
        public void Wifi()
        {
            Console.WriteLine("We can use wifi.");
        }
    }
}
