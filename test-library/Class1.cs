using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace test_library
{
    public class Class1
    {
        public static void DoIt() 
        {
            Console.WriteLine("Hello World123: " + DateTime.UtcNow.ToString("D") + " :-)");
            Console.WriteLine("EnvVar: " + Environment.GetEnvironmentVariable("MyVar", EnvironmentVariableTarget.Machine));
			Type type = Type.GetType("Mono.Runtime");
if (type != null)
{
    MethodInfo displayName = type.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
    if (displayName != null)
        Console.WriteLine(displayName.Invoke(null, null));
}
        }
    }
}
