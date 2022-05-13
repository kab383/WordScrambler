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
            // List<Words> scrambledWords = wsrRepo.ShuffleWordsGroup(wsrRepo._wordsListDB);

            // Console.WriteLine(scrambledWords[1].ZooAnimals); //should print ilno

            // Console.WriteLine(scrambledWords);
            // ^ convert to variable later to reference
            
            // Console.WriteLine(wsrRepo.ShuffleString("hello"));
            
            // // wsrRepo.ShuffleString(wsrRepo._wordsListDB);
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
            "You have 1 attempt to guess each word. There will be 10 rounds.\n" +
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
                    StartGame("iKnowMyABC");
                    break;
                case "2":
                    StartGame("averageVocabulary");
                    break;
                case "3":
                    StartGame("wordSmith");
                    break;
                case "4":
                    StartGame("spectacularVernacular");
                    break;
                case "5":
                    StartGame("myNameIsMerriamWebster");
                    break;
                default:
                    Console.WriteLine("Try another entry.");
                    break;       
            }
        }

        public void StartGame(string groupTitle)
        {
            Words unscrambledWords = wsrRepo.GetWordsByGroupTitle(groupTitle);

            string[] unscrambledArr = {unscrambledWords.ZooAnimals, unscrambledWords.Presidents, unscrambledWords.Countries, unscrambledWords.Movies, unscrambledWords.Foods, unscrambledWords.Sports, unscrambledWords.TvShows, unscrambledWords.Brands, unscrambledWords.Desserts};

            Words scrambledWords = wsrRepo.ShuffleWordsGroup(unscrambledWords);

            string[] scrambledArr = {scrambledWords.ZooAnimals, scrambledWords.Presidents, scrambledWords.Countries, scrambledWords.Movies, scrambledWords.Foods, scrambledWords.Sports, scrambledWords.TvShows, scrambledWords.Brands, scrambledWords.Desserts};

            // While loop to continue game, or end it with a boolean

                for(int i = 0; i < 9; i++ )
                {
                    Console.Write("Scrambled Word: ");
                    Console.WriteLine(scrambledArr[i]);

                    string guess = GetUserInput();

                    if(guess.ToUpper() == unscrambledArr[i].ToUpper())
                    {
                        Console.WriteLine("Correct! Next Question...");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Sorry, back to main menu... try again.");
                        break;
                    }
            }
        }
    }
}
        

        // PrintScore() - stretch goal.

        // PlayAgain()
        // Console.WriteLine conditional to play again and PrintMainMenu() or quit game with a see you later message.