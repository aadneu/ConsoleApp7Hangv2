using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class WordLibrary
    {
        private string[] WordsArray =
        {
            "hangman",
            "epletre",
            "oljeplattform",
            "appelsinjuice",
        };

        private List<string> WordList = new List<string>
        {
            "hangman",
            "epletre",
            "oljeplattform",
            "appelsinjuice",
        };

        public void WordListAdder(string word)
        {
            WordList.Add(word);
        }

        public string RandomWord()
        {
            var rand = new Random();
            var RandomWord = WordList[rand.Next(WordList.Count)];
            return RandomWord;
        }
    }
}
