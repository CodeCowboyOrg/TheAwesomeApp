using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AwesomeAssemblyUnsigned
{
    public class AwesomeUnsigned
    {
        public string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString() + ".AwesomeUnsigned";
        }
    }
}
