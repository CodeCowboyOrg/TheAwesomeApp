using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AwesomeAssemblySigned
{
    public class AwesomeSigned
    {
        public string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString() + ".AwesomeSigned.LOCAL";
        }
    }
}
