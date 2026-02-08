using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"OS Version: {Environment.OSVersion}");
            Console.WriteLine($"Os Arch: {RuntimeInformation.OSArchitecture}");
            Console.WriteLine($">NET : {RuntimeInformation.FrameworkDescription}");

            switch (RuntimeInformation.FrameworkDescription)
            {
                case string r when RuntimeInformation.FrameworkDescription.Contains(".NET"):
                    Console.WriteLine("Modern .NET Runtime");
                    break;
                case string r when RuntimeInformation.FrameworkDescription.Contains(".NET Core"):
                    Console.WriteLine("Modern .NET Runtime");
                    break;
                default:
                    Console.WriteLine("Legacy Runtime");
                    break;

            }
        }
    }
}
