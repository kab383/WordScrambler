using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordScrambler.Repository;

namespace WordScrambler.ConsoleApp
{
    public class UserInterface
    {
    
        private bool isRunning = true;

        WordScramblerRepository wsrRepo = new WordScramblerRepository();

        public void Run()
        {
            wsrRepo.SeedWordData();

            while(isRunning)
            {
                PrintMainMenu();

                string input = GetUserInput();
            }
        }

        private void PrintMainMenu()
        {
            Console.WriteLine("Welcome to Word Scrambler!\n" +
            "You have 3 attempts to guess each word. There will be 5 rounds.\n" +
            "Enter a difficulty to start the game:\n" +
            "1. I know my ABC's...\n" +
            "2. Average vocabulary\n" +
            "3. Wordsmith\n" +
            "4. Spectacular vernacular\n" +
            "5. My name is Merriam-Webster");
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

    }
}