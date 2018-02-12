using System;
using System.Globalization;
namespace TestCulture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CultureInfo info = new CultureInfo("da-DK");
            CultureInfo.CurrentCulture = info;
            Console.WriteLine(CultureInfo.CurrentCulture);
            decimal d = 9.4356M;
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
