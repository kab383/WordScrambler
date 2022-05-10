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

                UserInputSwitchCase(input);
            }
        }

        private void PrintMainMenu()
        {
            Console.Write("Welcome to Word Scrambler!\n" +
            "You have 3 attempts to guess each word. There will be 5 rounds.\n" +
            "1. I know my ABC's\n" +
            "2. Average vocabulary\n" +
            "3. Wordsmith\n" +
            "4. Spectacular vernacular\n" +
            "5. My name is Merriam-Webster\n" +
            "Enter a difficulty to start the game: ");
        }
        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch(input)
            {
                case "1":
                //not sure yet. start game 1, and so on?
                    break;
            }
        }

        // private string GetUserAnswer()
        // {
        //     return Console.ReadLine();
        // }
        public string StarrtRound(string answer)
        {
            // NEEDS WORK
            Console.WriteLine("Unscramble this word ${}");
            GetUserAnswer();
        }

        // PrintScore()

        // PlayAgain()

    }
}