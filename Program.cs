using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Build4Performance
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            List<string> games = new List<string>();
            games = CreateGameList();
            for(int i =0; i < games.Count(); i++)
            {
                Console.WriteLine(games[i]);
            }
        }

        public static List<string> CreateGameList()
        {
            List<string> games = new List<string>();
            using(StreamReader reader = new StreamReader("games.txt"))
            {
                string line = null;
                while (null != (line = reader.ReadLine()))
                {
                    games.Add(reader.ReadLine());
                }
            }
            return games;
        }

    }
}
