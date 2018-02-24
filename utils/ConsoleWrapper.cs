using System;

namespace utils
{
    public class ConsoleWrapper
    {
        public static int ReadInt() {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
