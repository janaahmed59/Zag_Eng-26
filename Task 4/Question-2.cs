using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Question_1
{
    internal class program2
    {
        static void Main(string[] args)
        {
            feature f1 = new feature("login", true, 1.0);//false
            feature f2 = new feature("Export", false, 2.0);//false
            feature f3 = new feature("AdminPAnel", true, 3.0);//true

            Console.WriteLine(f1.isCanRun());
            Console.WriteLine(f2.isCanRun());
            Console.WriteLine(f3.isCanRun());
        }
    }
    class versions
    {
        public const double ver = 3.0;
    }
    class feature
    {
        public bool Enabled;
        public string Name;
        public readonly double minReq;
        public feature(string name, bool enabled, double minReq)
        {
            Enabled = enabled;
            Name = name;
            minReq = minReq;
        }
        public bool isCanRun()
        {
            return Enabled && versions.ver >= minReq   ? true : false;
        }
    }


}
