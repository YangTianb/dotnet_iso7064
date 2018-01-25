using dotnet.iso7064;
using System;

namespace dotnet_iso7064
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //身份证号码最后一位使用该算法
            PureSystemCalculator calc = new Mod11_2();
            
            var r = calc.Compute("51112419910919341");

            Console.Write(r);
            Console.ReadLine();

        }
    }
}
