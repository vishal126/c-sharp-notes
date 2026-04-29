// Problem statement 1:
// Given a list of integers, find the total number of anagrams, palindromes, and the highest palindrome in the list.

// Anagrams: Two numbers are anagrams if their digits are the same but in different order. For example, the numbers 12 and 21 are anagrams.

// Palindromes: A number is a palindrome if it reads the same backwards and forwards. For example, the number 121 is a palindrome.

// Highest palindrome: The highest palindrome in the list is the palindrome with the largest value.

// Write a program that will take in a list of integers and output the total number of anagrams, palindromes, and the highest palindrome in the list.


// // Program.cs
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace problem_statements
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> list = new List<int>{121, 12321, 0000, 112, 1243, 4534};

//             Anagrams anagramObj = new Anagrams();

//             anagramObj.CountAnagrams(list);

//             Palindrome palindromeObj = new Palindrome();
//             palindromeObj.Palindromes(list);
//         }
//     }
// }


// // Anagrams.cs
// using System;
// using System.Collections.Generic;
// using System.Runtime.InteropServices;

// public class Anagrams
// {
// 	public int CountAnagrams(List<int> inputNumbers)
// 	{
//         int anagramCount = 0;

// 		for(int i = 0; i < inputNumbers.Count; i++)
// 		{
//             int[] freqFromCompare = new int[10];

//             int num = inputNumbers[i];
//             while(num!=0)
//             {
//                 int digit = num % 10;
//                 freqFromCompare[digit]++;
//                 num/=10;
//             }

//             for(int j=0; j<inputNumbers.Count; j++)
//             {
//                 if(j!=i)
//                 {
//                     int[] freqToCompare = new int[10];
//                     int numToCompare = inputNumbers[j];
//                     while (numToCompare != 0)
//                     {
//                         int digit = numToCompare % 10;
//                         freqToCompare[digit]++;
//                         numToCompare /= 10;
//                     }

//                     bool isAnagram = true;

//                     for (int k = 0; k < 10; k++)
//                     {
//                         if (freqFromCompare[k] != freqToCompare[k])
//                         {
//                             isAnagram = false;
//                             break;
//                         }
//                     }

//                     if (isAnagram)
//                     {
//                         anagramCount++;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine($"Total number of Anagrams: {anagramCount}");
//         return 0;
//     }
// }


// // Palindrome.cs
// using System;
// using System.Collections.Generic;

// public class Palindrome
// {
//     private int palindromeCount = 0, highestPalindrome = 0;


//     public int Palindromes(List<int> numbers)
//     {
//         for(int i = 0; i < numbers.Count; i++ )
//         {
//             bool isPalindrome = true;
//             int currNum = numbers[i];
//             List<int> tempList = new List<int>();

//             while(currNum!=0)
//             {
//                 int digit = currNum%10;
//                 currNum /= 10;
//                 tempList.Add(digit);
//             }

//             int start = 0, end = tempList.Count - 1;
//             while(start<end)
//             {
//                 if (tempList[start] != tempList[end])
//                 {
//                     isPalindrome=false;
//                     break;
//                 }
//                 start++;
//                 end--;
//             }

//             if(isPalindrome)
//             {
//                 palindromeCount++;
//                 if (numbers[i] > highestPalindrome)
//                 {
//                     highestPalindrome = numbers[i];
//                 }
//             }
//         }

//         Console.WriteLine("Total palindrome numbers: {0}", palindromeCount);
//         Console.WriteLine($"Highest Palindrome: {highestPalindrome}");
//         return 0;
//     }

// }