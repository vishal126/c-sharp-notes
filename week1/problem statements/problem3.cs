// Write a program to get the word count in a given sentence and print the each work of the sentence in the reversed order.

using System;
using System.Net;
using System.Runtime.CompilerServices;
namespace problem3
{
    class Problem3
    {
        public static void Main()
        {
            string str = "My organization name is InTimeTEC.";
            char[] wordToReverse = str.ToCharArray();
            int i=0, j=0;
            while(j<wordToReverse.Length)
            {
                while(j<wordToReverse.Length && wordToReverse[j]!=' ' && wordToReverse[j]!='.')
                {
                //     Console.WriteLine($"{wordToReverse[j]}");
                    j++;
                }
                reverse(i, j-1, wordToReverse);
                i=j;
                while(i<wordToReverse.Length && (wordToReverse[i]==' ' || wordToReverse[i] == '.'))
                {
                    i++;
                }
                j=i;
            }
            reverse(i, j, wordToReverse);

            foreach(var ch in wordToReverse)
            {
                Console.WriteLine($"{ch}");
            }
        }

        public static void reverse(int i, int j, char[] wordToReverse)
        {
            while(i<j)
            {
                char temp = wordToReverse[i];
                wordToReverse[i]=wordToReverse[j];
                wordToReverse[j] = temp;
                i++;
                j--;
            }
        }
    }
}