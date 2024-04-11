using System;
using System.Text;
using CSInputs;
using CSInputs.Enums;
using Community;
using SharpHook;
using SharpHook.Native;

namespace Community
{
    partial class Program
    {

        public static void Main(string[] args) // MAKE SURE YOUR ROBLOX IS OPEN BEFORE TESTING YOUR MACRO!
        {
            Console.WriteLine("exmp..."); // This will write something on the console
            Thread.Sleep(1000);
            Run();
        }

        private static void Run()  // Write your macro here! (Inside the brackets)
        { // Do not touch Focus();
            Focus();

            WaitOneSec(); // Waits one second

            // For example
            // HoldE(); - Holds E
            

        }
    }
}
