using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Intro_to_Methods_Part_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputX;
            int inputY;
            Console.WriteLine("Do you want to draw some pictures?");
            Console.ReadLine();
            Console.WriteLine("Select a position for the drawings");
            Console.WriteLine("X - Position:");
            inputX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y - Position:");
            inputY = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(inputX, inputY);
                drawCow();
                drawPig();
                drawBird();
            Console.Clear();
            Console.WriteLine("Now do you want to hear a joke?");
            Console.ReadLine();
            knockKnockJoke();
            Console.Clear();
        }
        //Part One: ASCII Art
        public static void drawCow()
        {
            var (x, y) = Console.GetCursorPosition();
            Console.SetCursorPosition(x, y);
            Console.WriteLine("((...))");            
            Console.WriteLine("( O O )");            
            Console.WriteLine(" [   ] ");           
            Console.WriteLine(" (`_`) ");
            Console.WriteLine("");
            Thread.Sleep(500);
        }
        public static void drawPig()
        {
            Console.WriteLine("    _____  ");
            Console.WriteLine("^..^     \\9");
            Console.WriteLine("(oo)_____/ ");
            Console.WriteLine("   WW  WW");
            Console.WriteLine("");
            Thread.Sleep(500);
        }
        public static void drawBird()
        {
            Console.WriteLine("      __/)");
            Console.WriteLine("   .-(__(=:");
            Console.WriteLine("|\\ |    \\)");
            Console.WriteLine("\\ ||");
            Console.WriteLine(" \\||");
            Console.WriteLine("  \\|");
            Console.WriteLine("   |");
            Console.WriteLine("");
            Thread.Sleep(1000);
        }
        //Part Two: Knock Knock Joke
        public static void knockKnockJoke()
        {
            Thread.Sleep(500);
            Console.WriteLine("Knock Knock...");
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Candice");
            Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Candice joke get any worse?");
            Thread.Sleep(2000);
            Console.WriteLine("Did you like my joke?");
            Console.ReadLine();

        }
        
    }
}