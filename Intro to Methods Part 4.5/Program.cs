using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Intro_to_Methods_Part_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to draw some pictures?");
            Console.ReadLine();
            drawCow();
            drawPig();
            drawBird();
        }
        //Part One ASCII Art
        public static void drawCow()
        {
            Console.WriteLine("((...))");
            Console.WriteLine("( O O )");
            Console.WriteLine(" [   ] ");
            Console.WriteLine(" (`_`) ");
            Thread.Sleep(500);
        }
        public static void drawPig()
        {
            Console.WriteLine("    _____  ");
            Console.WriteLine("^..^     \\9");
            Console.WriteLine("(oo)_____/ ");
            Console.WriteLine("   WW  WW");
            Thread.Sleep(500);
        }
        public static void drawBird()
        {
            //finish
            Thread.Sleep(500);
        }
    }
}