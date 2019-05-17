using System;

using System.Runtime.InteropServices;

// Namespace
namespace YourProject.Namespace.Goes.Here
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {            

            NativeMethods.SetThreadExecutionState(NativeMethods.ES_DISPLAY_REQUIRED | NativeMethods.ES_CONTINUOUS | NativeMethods.ES_SYSTEM_REQUIRED );

            Console.WriteLine("Program Running!!!");

            Console.Read(); // use this if the project is a console application - it waits for 'enter key' to be entered for exiting terminal
        }

        internal static class NativeMethods

        {

            // Import SetThreadExecutionState Win32 API and necessary flags

            [DllImport("kernel32.dll")]

            public static extern uint SetThreadExecutionState(uint esFlags);

            public const uint ES_CONTINUOUS = 0x80000000;

            public const uint ES_DISPLAY_REQUIRED = 0x00000002;

            public const uint ES_SYSTEM_REQUIRED = 0x00000001;

        }        
    }
}
