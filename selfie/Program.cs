using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace selfie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting to take a selfie...");
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Console.WriteLine(userName);
            Console.WriteLine("GetEnvironmentVariables: ");
            IDictionary environmentVariables = Environment.GetEnvironmentVariables();
            foreach (DictionaryEntry de in environmentVariables)
            {
                Console.WriteLine("  {0} = {1}", de.Key, de.Value);
            }
        }
    }
}


