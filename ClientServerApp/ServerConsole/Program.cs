using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerConsole
{
    class Program
    {
        /// <summary>
        /// Console listens for the client and user to input something
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Welome message to the console
            Console.WriteLine("Welcome to the Server Application:");
            Console.WriteLine("----------------------------------");

            // Starts the user client and links to the console and the console stays listening to the client
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Users\zmalone\source\repos\ClientServerApp\ClientForm\bin\Debug\ClientForm.exe";
            process.Start();
            SynchronousSocketListener ssl = new SynchronousSocketListener();
            ssl.StartListening();
        }
    }
}
