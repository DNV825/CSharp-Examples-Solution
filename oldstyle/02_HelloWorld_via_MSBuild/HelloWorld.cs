using System;

namespace HelloWorld_via_MSBuild
{
    static class HelloWorld
    {
        public static void Show(string words)
        {
#if DEBUG_CONFIG
            Console.WriteLine("We are in DEBUG CONFIGURATION.");
#endif
            Console.WriteLine(words);
        }
    }
}