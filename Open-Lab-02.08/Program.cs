using System;

namespace Open_Lab_02._08
{
    class Program
    {
        public static bool IsEmpty(string str)
        {
            return (str == "");
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(IsEmpty(a));
        }
    }
}
