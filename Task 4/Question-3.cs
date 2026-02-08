using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace C_App1
{
    internal class App1
    {

        static void Main(string[] args)
        {
            Console.WriteLine($"OS Version: {Environment.OSVersion}");
            Console.WriteLine($"Os Arch: {RuntimeInformation.OSArchitecture}");
            Console.WriteLine($">NET : {RuntimeInformation.FrameworkDescription}");

            //switch (RuntimeInformation.FrameworkDescription)
            //{
            //    case ".NET":
            //        Console.WriteLine("Modern .NET Runtime");
            //        break;
            //    case ".NET Core":
            //        Console.WriteLine("Modern .NET Runtime");
            //        break;
            //    default:
            //        Console.WriteLine("Legacy Runtime");
            //        break;

            //}
        }
    }

}


