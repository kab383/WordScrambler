using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordScrambler.Repository
{
    public class WordScramblerRepository
    {
        private List<Words> _wordsListDB = new List<Words>(); // To use a new instance of our list.

        public void AddWordsToDatabase(Words words) // Add Words data to the list
        {
            _wordsListDB.Add(words);
        }

        static Random r = new Random(); // Randomizer for the shuffle
        // FISHER-YATES SHUFFLE
        public void ShuffleString(object[] objects)
        {
            // for (int i = objects.Length - 1; i > 0; i--)
            // {
            //     int j = r.Next(i + 1);
            //     object temp = objects[i];
            //     objects[i] = objects[j];
            //     objects[j] = temp;
            // }
        }

        // AttemptCounter()

        // WordFailed()

        // ScoreCounter()
        


        public void SeedWordData()
        {
            Words iKnowMyABC = new Words("lion", "lincoln", "canada", "jaws", "tomato", "soccer", "friends", "apple", "cake");
            Words averageVocabulary = new Words("rhinoceros", "washington", "denmark", "inception", "spaghetti", "basketball", "futurama", "adidas", "macaron");
            Words wordSmith = new Words("hippopotamus", "roosevelt", "uruguay", "sharknado", "chimichurri", "gymnastics", "reign", "chevrolet", "beignet");
            Words spectacularVenacular = new Words("pangolin", "buchanan", "azerbaijan", "jumanji", "edamame", "fencing", "supernatural", "birkenstock", "baklava");
            Words myNameIsMerriamWebster = new Words("parastratiosphecomyia stratiosphecomyioides", "eisenhower", "liechtenstein", "ratatouille", "bouillabaisse", "taekwondo", "animaniacs", "balenciaga", "marscapone");

            Words[] wordsArr = {iKnowMyABC, averageVocabulary, wordSmith, spectacularVenacular, myNameIsMerriamWebster};

            foreach (Words words in wordsArr)
            {
                AddWordsToDatabase(words);
            }
        }
    }
}