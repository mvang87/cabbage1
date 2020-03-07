using System;

namespace Cabbage1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //This is just a preface to asks the user to input a word, I tested with a-z,1-9, & h for maximum set of characters.
            Console.WriteLine("This console app is designed to pull the first pair of letters that occur from either end of the word.\nEnter word to be tested: ");
            
            //static int is used to have the variable remains the same through the program
            static int findfirstduplicatechar(string s)
            {

                // this is O(N^2) method 
                int p = -1, i, j;

                /*In the for "i" loop, the first character would be check with all letters in the "j" loop, if the conitions
                are not met, "i" would be incremented by one, and "j" would be checked again*/
                /*In "i" loop, "c" is compared to "a, b, b, a, g, e" from "j" loop. Condition not met. "i" is incremented.
                  "i" is incremented, "a" is compared to "b, b, a." Since the condition is met, the loop is broken.*/
                for (i = 0; i < s.Length; i++)
                {
                    for (j = i + 1; j < s.Length; j++)
                    {
                        //below will break, if the condition is met
                        if (s[i] == s[j])
                        {
                            p = i;
                            break;
                        }
                    }
                    //Word does not meet the criteria, this breaks and prints the error msg.
                    if (p != -1)
                        break;
                }
                return p;
            }

            {
                /*Asks the user to input any word a string of characters, also converts all input to lowercase.
                Otherwise, if a there are matching letters and one is uppercase, it will be invalid.*/
                string word = Console.ReadLine().ToLower();
                int pos = findfirstduplicatechar(word);
                //The if below returns the output if no duplicates are found.
                if (pos == -1)
                    Console.WriteLine("No repeated characters are found.");
                //Else will return the duplicate letter found.
                else
                    Console.WriteLine(word[pos]);
            }
        }
    }
}
