global using System;
global using Colorful;
global using System.Drawing;
global using Console = Colorful.Console;

namespace TarotReading_Labb1
{
    // I've used Factory Method, Observer and Singleton pattern in this app
    internal class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Start();
        }
    }
}