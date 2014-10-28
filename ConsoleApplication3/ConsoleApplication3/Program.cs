using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //create vowel counter
        static int VowelCounter(string inputString)
        {
            //declare counter for vowels
            int numberOfVowelsFound = 0;

            //loop over each letter of the string
            for (int i = 0; i < inputString.Length; i += 1) ;
            {
                string letter = inputString[i].ToString().ToLower;

                //check if letter is a vowel
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u") ;
                {
                    //found a vowel!
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                }

                //alternate way of checking to see if it's a vowel
                if ("aeiou".Contains(letter))
                
                {

                }

                //loop complete, time to write the output
                Console.WriteLine(inputString + "has" + numberOfVowelsFound + "vowels in it");
                return numberOfVowelsFound;
            }
        }

        static void VowelCounterTest
        {
            //count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += VowelCounter("I hate your mashed potatoes, they taste like burnt hair and tar");

        }
       
    }
}
