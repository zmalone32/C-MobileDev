using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientForm
{
    public class SynchronousSocketClient
    {
        const int PORT_NUMBER = 11000;
        const string IP_ADDRESS = "127.0.0.1";

        public string ContactServer(string userRequest)
        {
            string responseString = "";

            //
            try
            {
                // create new tcp client
                TcpClient tcpClient = new TcpClient();
                // Connect to the IP Address and the open port number
                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), PORT_NUMBER);
                // Network gets the info from the tcp client to the network stream
                NetworkStream networkStream = tcpClient.GetStream();

                // Server is given any info that the user input
                StreamWriter streamWriter = new StreamWriter(networkStream);
                // Read any information given back from the server
                StreamReader streamReader = new StreamReader(networkStream);

                // Buffer when full data is sent and received to ensure entirety
                streamWriter.AutoFlush = true;
                // Write the users request of joke or consipiracy
                streamWriter.WriteLine(userRequest);
                // Reads whatever comes back
                responseString = streamReader.ReadLine();

                // Close the network stream and tcp client
                networkStream.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                // Catch the error message
                responseString = ex.Message;
            }

            // Catch the error message
            return responseString;
        }
    }
}
