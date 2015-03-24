using System;

namespace Microsoft.DotNet.Build.Tasks
{
    class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.Error.WriteLine("Wrong number of arguments.  Expects: AssemblyName OutputSourceFilePath ResxFilePath DebugOnly");
                return 2;
            }

            var task = new GenerateResourcesCode
            {
                AssemblyName = args[0],
                OutputSourceFilePath = args[1],
                ResxFilePath = args[2],
                DebugOnly = bool.Parse(args[3]),
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
