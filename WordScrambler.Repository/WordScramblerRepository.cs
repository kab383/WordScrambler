using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordScrambler.Repository
{
    public class WordScramblerRepository
    {
        public List<Words> _wordsListDB = new List<Words>(); // To use a new instance of our list.

        public void AddWordsToDatabase(Words words) // Add Words data to the list
        {
            _wordsListDB.Add(words);
        }

        public Words GetWordsByGroupTitle(string groupTitle)
        {
            foreach(Words word in _wordsListDB)
            {
                if (groupTitle == word.GroupTitle)
                {
                return word;
                }
            }
            return null;
        }

        public string ShuffleString(string wordToShuffle)
        {
            Random r = new Random();
            string originalWord = wordToShuffle;

            string shuffledWord = new string(originalWord.ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());

            return shuffledWord;
        }

        public Words ShuffleWordsGroup(Words word)
        {

                string groupTitle = word.GroupTitle;
                string zooAnimal = ShuffleString(word.ZooAnimals);
                string presidents = ShuffleString(word.Presidents);
                string countries = ShuffleString(word.Countries);
                string movies = ShuffleString(word.Movies);
                string food = ShuffleString(word.Foods);
                string sports = ShuffleString(word.Sports);
                string tvShows = ShuffleString(word.TvShows);
                string brands = ShuffleString(word.Brands);
                string desserts = ShuffleString(word.Desserts);

                Words scrambledWords = new Words(groupTitle, zooAnimal, presidents, countries, movies, food, sports, tvShows, brands, desserts);

            return scrambledWords;
        }
        
        public void SeedWordData()
        {
            Words iKnowMyABC = new Words("iKnowMyABC", "lion", "lincoln", "canada", "jaws", "tomato", "soccer", "friends", "apple", "cake");
            Words averageVocabulary = new Words("averageVocabulary", "rhinoceros", "washington", "denmark", "inception", "spaghetti", "basketball", "futurama", "adidas", "macaron");
            Words wordSmith = new Words("wordSmith", "hippopotamus", "roosevelt", "uruguay", "sharknado", "chimichurri", "gymnastics", "reign", "chevrolet", "beignet");
            Words spectacularVernacular = new Words("spectacularVernacular", "pangolin", "buchanan", "azerbaijan", "jumanji", "edamame", "fencing", "supernatural", "birkenstock", "baklava");
            Words myNameIsMerriamWebster = new Words("myNameIsMerriamWebster", "parastratiosphecomyiastratiosphecomyioides", "eisenhower", "liechtenstein", "ratatouille", "bouillabaisse", "taekwondo", "animaniacs", "balenciaga", "marscapone");

            Words[] wordsArr = {iKnowMyABC, averageVocabulary, wordSmith, spectacularVernacular, myNameIsMerriamWebster};

            foreach (Words words in wordsArr)
            {
                AddWordsToDatabase(words);
            }
            
        }
    }
}
