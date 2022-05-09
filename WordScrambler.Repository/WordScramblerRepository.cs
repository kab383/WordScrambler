using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordScrambler.Repository
{
    public class WordScramblerRepository
    {
        private List<Words> _wordsListDB = new List<Words>();

        public void AddWordsToDatabase(Words words)
        {
            _wordsListDB.Add(words);
        }

        public void SeedWordData()
        {
            Words _iKnowMyABC = new Words("lion", "lincoln", "canada", "jaws", "tomato", "soccer", "friends", "apple", "cake");
            Words _averageVocabulary = new Words("rhinoceros", "washington", "denmark", "inception", "spaghetti", "basketball", "futurama", "adidas", "macaron");
            Words _wordSmith = new Words("hippopotamus", "roosevelt", "uruguay", "sharknado", "chimichurri", "gymnastics", "reign", "chevrolet", "beignet");
            Words _spectacularVenacular = new Words("pangolin", "buchanan", "azerbaijan", "jumanji", "edamame", "fencing", "supernatural", "birkenstock", "baklava");
            Words _myNameIsMerriamWebster = new Words("parastratiosphecomyia stratiosphecomyioides", "eisenhower", "liechtenstein", "ratatouille", "bouillabaisse", "taekwondo", "animaniacs", "balenciaga", "marscapone");

            Words[] wordsArr = {_iKnowMyABC, _averageVocabulary, _wordSmith, _spectacularVenacular, _myNameIsMerriamWebster};

            foreach(Words words in wordsArr)
            {
                AddWordsToDatabase(words);
            }
        }

    }
}