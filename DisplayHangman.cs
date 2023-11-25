using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class DisplayHangman
    {
        string[] display = {
            @"
              +---+
              |   |
                  |
                  |
                  |
                  |
            =========",

            @"
              +---+
              |   |
              O   |
                  |
                  |
                  |
            =========",

            @"
              +---+
              |   |
              O   |
              |   |
                  |
                  |
            =========",

            @"
              +---+
              |   |
              O   |
             /|   |
                  |
                  |
            =========",

            @"
              +---+
              |   |
              O   |
             /|\  |
                  |
                  |
            =========",

            @"
              +---+
              |   |
              O   |
             /|\  |
             /    |
                  |
            =========",

            @"
              +---+
              |   |
              O   |
             /|\  |
             / \  |
                  |
            ========="
            
        };
        public void Show(int i){
          
            Console.WriteLine(display[i]);
            
        }
        
    }
}
