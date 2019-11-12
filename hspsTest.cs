using System;

namespace AssociateDev
{
    class Program
    {
        static void Main(string[] args)
        {
            //input string to hold user input
            string inString = null;
            //integer to help verify user input
            int verify = 1;
            //get input string from user
            //verify input is at least three characters long which is the shortest csv can be e.g. "x"
            while (verify > 0)
            {
                Console.WriteLine("Please enter a string in CSV format");
                inString = Console.ReadLine();
                if(inString.Length < 3)
                {
                    Console.WriteLine("The input was too short.  Please Try again");
                    verify = 1;
                }
                else
                {
                    verify = 0;
                }
            }

            //my index integer
            int i;
            //arrays to hold unicode values and characters
            int[] numArray = null;
            char[] charArray = null;
            //get size
            int charLength = inString.Length;
            numArray = new int[charLength];
            charArray = new char[charLength];

            //convert characters in strin to unicode
            for(i = 0; i < charLength; i++)
            {
                numArray[i] = inString[i];
            }
            //change first and las characters to open and close square brackets
            numArray[0] = 91;
            numArray[charLength - 1] = 93;

            //search array for "," and replace with ] [
            for (i = 2; i < charLength; i++)
            {
                if(numArray[i - 2] == 34 && numArray[i - 1] == 44 && numArray[i] == 34)
                {
                    numArray[i - 2] = 93;
                    numArray[i - 1] = 32;
                    numArray[i] = 91;
                }
            }

            //convert unicode in num array to char in char array
            for(i = 0; i < charLength; i++)
            {
                charArray[i] = (char) numArray[i];
            }

            //convert new char array to string
            string outS = new string(charArray);
            //print string
            Console.WriteLine(outS);

            //wait to display console
            Console.ReadLine();
        }
    }
}
