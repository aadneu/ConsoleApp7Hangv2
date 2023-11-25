// See https://aka.ms/new-console-template for more information

using System.Net.Mime;
using ConsoleApp7;

var display = new DisplayHangman();
Console.WriteLine("\n Velkommen til Hangman! \n______________________________________ \n");
string currentWord = "hangman";
string displayWord = new string('*', currentWord.Length);
int guesses = 0;

int antallBokstaver = currentWord.Length;
Console.WriteLine($"Ordet vi skal frem til inneholder {antallBokstaver} bokstaver.\n");


while (displayWord != currentWord)
{
    Run();
}
Console.WriteLine("Gratulerer du vant!");


void Run()
{
    Console.WriteLine(displayWord);
    var input = Console.ReadLine()[0];
    
  
    
    for (int i = 0; i < currentWord.Length; i++)
    {
        if (input == currentWord[i])
        {
            displayWord = displayWord.Substring(0, i) + input + displayWord.Substring(i + 1);
           
        } 

    }
    Console.SetCursorPosition(0, 6);


}
/*
void Run()
{

    var input = Console.ReadLine()[0];
    Console.WriteLine(displayWord);
    bool correctGuess = false;

    for (int i = 0; i < currentWord.Length; i++)
    {
        if (input == currentWord[i])
        {
            displayWord = displayWord.Substring(0, i) + input + displayWord.Substring(i + 1);
            correctGuess = true;
        }

    }

    if (!correctGuess)
    {
        guesses++;
        Console.WriteLine(guesses);
    }
    display.Show(guesses);
    Console.SetCursorPosition(0, 6);

}

*/
