using LibNoSourceAccess;
using Oefening1;
using Oefening2;
using System;
using static dotnet.o2sse.BeamExtension;

namespace dotnet.o2sse
{
    class Program
    {
        static void Main(string[] args)
        {
            Oefening1_IsOdd();
            Oefening2_CountChar();
            Oefening3_Beam();
        }

        static void Oefening1_IsOdd()
        {
            int number1 = 53;
            int number2 = 64;
            Console.WriteLine($"{number1} is odd: {number1.isOdd()}");
            Console.WriteLine($"{number2} is odd: {number2.isOdd()}");
        }

        static void Oefening2_CountChar()
        {
            string text = "This is a simple text";
            char c = 'i';
            Console.WriteLine($"Text: {text}; char {c} found {text.CountChar(c)} times in the text.");
        }

        static void Oefening3_Beam()
        {
            Beam beam1 = new Beam(10, 100, 100, 25);
            Beam beam2 = new Beam(20, 200, 200, 75);
            Console.WriteLine(beam1);
            Console.WriteLine(beam2);

            Console.WriteLine($"\nSTACK {StackSide.Width.ToString().ToUpper()}");
            Console.WriteLine(beam1.Stack(beam2, StackSide.Width));
            Console.WriteLine($"\nSTACK {StackSide.Length.ToString().ToUpper()}");
            Console.WriteLine(beam1.Stack(beam2, StackSide.Length));
            Console.WriteLine($"\nSTACK {StackSide.Height.ToString().ToUpper()}");
            Console.WriteLine(beam1.Stack(beam2, StackSide.Height));
        }
    }
}
