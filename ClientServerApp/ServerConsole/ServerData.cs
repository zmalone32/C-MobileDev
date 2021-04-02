using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ServerConsole
{
	/// <summary>
	/// Method to store the files and read the files as well
	/// </summary>
    public class ServerData
    {
		Random rand = new Random();
		// Stored variables to read the files in the class
		const string JOKE_FILE = "jokes.txt";
		const string CONSIPIRACY_FILE = "conspiracies.txt";
		string[] allJokes;
		string[] allConspiracies;
		/// <summary>
		/// Load and read the files listed in the program
		/// </summary>
        public void LoadFiles()
        {
			// Try to read all the files, if not, then display a message
			try
			{
				allJokes = File.ReadAllLines(JOKE_FILE);
				allConspiracies = File.ReadAllLines(CONSIPIRACY_FILE);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
        }
		/// <summary>
		/// Gets a random joke from the file
		/// </summary>
		/// <returns></returns>
		public string GetRandomJoke()
		{
			return allJokes[rand.Next(allJokes.Length)];
		}
		/// <summary>
		/// gets a random conspiracy from the file
		/// </summary>
		/// <returns></returns>
		public string GetRandomConspiracy()
		{
			return allConspiracies[rand.Next(allConspiracies.Length)];
		}
    }
}
