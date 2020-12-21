using System;

namespace PrintFace
{
    public static class Program
    {
        /// <summary>
        /// Print "Hello, world!" in a separate line.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("  Hello, world! ");
        }

        /// <summary>
        /// Print "Hello, userName!" in a separate line.
        /// </summary>
        /// <param name="userName">Name of user.</param>
        public static void SayHelloUser(string userName)
        {
            Console.WriteLine("Hello, Alex!");
        }
        
        /// <summary>
        /// Print this face.
        ///   +"""""+
        ///  (| o o |)
        ///   |  ^  |
        ///   | '-' |
        ///   +-----+
        /// </summary>
        public static void PrintFace()
        {
            Console.WriteLine(" +\"\"\"\"\"+ ");
            Console.WriteLine("(| &#176; &#176; |)");
            Console.WriteLine(" |  ^  | ");
            Console.WriteLine(" | '-' | ");
            Console.WriteLine(" +-----+ ");

        }
    }
}
