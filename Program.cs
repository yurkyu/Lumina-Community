using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CSInputs;
using CSInputs.Enums;
using Lumina_Community;
using SharpHook;
using SharpHook.Native;

namespace Community
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("exmp..."); // This will write something on the console

            Run();
        }

        private static void Run()  // Write your macro here! (Inside the brackets)
        { // Do not delete Util.Focus();
            Util.Focus();

            // For example
            CSInputs.SendInput.Keyboard.Send(KeyboardKeys.Escape, KeyFlags.Down); // Presses Escape

        }
    }
}
