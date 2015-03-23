using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Build.Tasks
{
    class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 5)
            {
                Console.Error.WriteLine("Wrong number of arguments.  Expects: AssemblyName IntermediateFilePath OutputSourceFilePath ResxFilePath DebugOnly");
            }

            var task = new GenerateResourcesCode
            {
                AssemblyName = args[0],
                IntermediateFilePath = args[1],
                OutputSourceFilePath = args[2],
                ResxFilePath = args[3],
                DebugOnly = bool.Parse(args[4]),
            };


            if (!task.Execute())
            {
                Console.Error.WriteLine("GenerateResourcesCode task failed.");
                return 1;
            }

            return 0;
        }
    }
}
