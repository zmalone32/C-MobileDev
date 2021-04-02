using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerConsole
{
    /// <summary>
    /// Listener for the user input to page the server from what was entered
    /// </summary>
    public class SynchronousSocketListener
    {
        // Class scope instance for the variables
        ServerData serverData;
        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string JOKE = "JOKE";
        const string CONSPIRACY = "CONSPIRACY";
        // Listen for the tcp connection
        TcpListener tCPListener;

        /// <summary>
        /// Instantiate it inside the constructor method
        /// </summary>
        public SynchronousSocketListener()
        {
            // This will call and load the files
            serverData = new ServerData();
            serverData.LoadFiles();
        }
        /// <summary>
        /// Uses the tcplistener to open a port and ip address and allows multi users as threads
        /// </summary>
        public void StartListening()
        {
            // Parses Ip and starts the socket and can use many threads
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            tCPListener = new TcpListener(iPAddress, PORT);
            tCPListener.Start();
            Thread thread = new Thread(new ThreadStart(ProcessSocket));
            thread.Start();
        }

        /// <summary>
        /// Method to return either a joke or a conspiracy
        /// </summary>
        public void ProcessSocket()
        {
            // creates a socket as null
            Socket socket = null;

            // repeating loop to test if it is a joke, conspiracy or unknown text by the user
            while (true)
            {
                try
                {
                    // Creates new streamwriter and reader
                    socket = tCPListener.AcceptSocket();
                    NetworkStream ns = new NetworkStream(socket);
                    StreamReader reader = new StreamReader(ns);
                    StreamWriter writer = new StreamWriter(ns);

                    // Wipe and receive the users input
                    writer.AutoFlush = true;
                    string userData = reader.ReadLine();
                    Console.WriteLine($"Received from client: {userData}");

                    // If user writes joke in any form, then return a joke
                    if (userData.ToUpper() == JOKE)
                    {
                        string joke = $"Joke: {serverData.GetRandomJoke()}";
                        Console.WriteLine(joke);
                        writer.WriteLine(joke);
                    }
                    // If user writes conspiracy in any form, then return a conspiracy
                    else if (userData.ToUpper() == CONSPIRACY)
                    {
                        string conspiracy = $"Conspiracy: {serverData.GetRandomConspiracy()}";
                        Console.WriteLine(conspiracy);
                        writer.WriteLine(conspiracy);
                    }
                    // If joke nor conspiracy is written then return the message below
                    else
                    {
                        writer.WriteLine($"Could not do anything with {userData}");
                    }


                }
                // Detect if ther is an error, if so, then display it
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
