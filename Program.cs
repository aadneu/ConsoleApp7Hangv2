// See https://aka.ms/new-console-template for more information

using System.Net.Mime;
using ConsoleApp7;


Run();


string CurrentWord(out string displayWord1, out int guesses1, out int antallBokstaver1)
{
    var AddWords = new WordLibrary();
    string s = AddWords.RandomWord();
    displayWord1 = new string('*', s.Length);
    guesses1 = 0;
    antallBokstaver1 = s.Length;
    return s;
}

void Run()
{
    var display = new DisplayHangman();
    var currentWord = CurrentWord(out var displayWord, out var guesses, out var antallBokstaver);
    WelcomeToHangman(antallBokstaver);
    while (displayWord != currentWord && guesses <= 6)
    {
        HangmanGame();
    }

    GameOver();

    void WelcomeToHangman(int antallBokstaver2)
    {
        Console.WriteLine("\n Velkommen til Hangman! \n______________________________________ \n");
        Console.WriteLine($"Ordet vi skal frem til inneholder {antallBokstaver2} bokstaver.\n");
    }

    void HangmanGame()
    {
        Console.WriteLine(displayWord);

        bool correctWord = false;
        var input = Console.ReadLine()[0];
        display.Show(guesses);
        for (int i = 0; i < currentWord.Length; i++)
        {
            if (input == currentWord[i])
            {
                correctWord = true;
                displayWord = displayWord.Substring(0, i) + input + displayWord.Substring(i + 1);
            }
        }

        if (!correctWord)
        {
            guesses++;
        }

        Console.SetCursorPosition(0, 6);
    }

    void GameOver()
    {
        if (displayWord == currentWord)
        {
            Console.WriteLine($"Gratulerer du vant! Ordet var {currentWord}");
        }
        else
        {
            Console.WriteLine("You cannot escape death!");
        }

        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Do you want to play again? Type 'yes' to play again!");
        string PlayAgainRespone = Console.ReadLine();
        if (PlayAgainRespone == "yes")
        {
            Console.Clear();
            Run();
        }
    }
}



