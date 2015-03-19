using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signed=AwesomeAssemblySigned;
using UnSigned=AwesomeAssemblyUnsigned;

namespace TheAwesomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Signed.AwesomeSigned signed = new Signed.AwesomeSigned();
            UnSigned.AwesomeUnsigned unsigned = new UnSigned.AwesomeUnsigned();

            Console.WriteLine(signed.GetVersion());
            Console.WriteLine(unsigned.GetVersion());
            Console.Read();

        }
    }
}
