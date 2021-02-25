using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";

            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
             /*Console.WriteLine("Question 7");
               int[,] Scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
               HighFive(Scores);
               Console.WriteLine();*/

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] ar1, int n1)
        {
            try
            /* 
             * We suspect that this block of the statement can throw 
             * exception so we handled it by placing these statements
             * inside try and handle the exception in the catch block
            */
            {
                int count = 0;
                int[] result = new int[ar1.Length];
                for (int i = 0, j = n1; i < n1; i++, j++)
                {
                    result[count++] = ar1[i];
                    result[count++] = ar1[j];
                }
                Console.WriteLine();
                return;

            }

            catch (Exception e)
            {
                /*
                * This is a generic Exception handler which means it can handle
                * all the exceptions. This will execute if the exception is not
                * handled by previous catch blocks.
                */
                Console.WriteLine("Exception Occured while computing ShuffleArray" + e.Message);
                
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try

            {
                int index = 0;
                int n = ar2.Length;
                if (n == 0) return;
                for (int i = 0; i < n; i++)
                {
                    if (ar2[i] != 0)
                    {
                        ar2[index++] = ar2[i];
                    }
                }
                for (int n1 = index; n1 < n; n1++)
                {
                    ar2[n1] = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured while computing  Movezeroes()");

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static int CoolPairs(int[] ar3)
        {
            try
            {
                int count = 0;
                for (int i = 0; i < ar3.Length - 1; i++)
                {
                    for (int j = i + 1; j < ar3.Length; j++)
                    {
                        if (ar3[i] == ar3[j])
                        {
                            count++;
                        }
                    }
                }
                return (count);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static int[] TwoSum(int[] ar4, int target)
        {
            try
            {
                int l = 0, r = ar4.Length - 1, sum;
                while (true)
                {
                    sum = ar4[l] + ar4[r];
                    if (sum == target)
                        break;
                    else if (sum < target)
                        l += 1;
                    else
                        r -= 1;
                }
                return new int[2] { l + 1, r + 1 };

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static string RestoreString(string s5, int[] indices)
        {
            try
            {
                var arr = new char[s5.Length];
                for (int i = 0; i < s5.Length; i++)
                {
                    arr[indices[i]] = s5[i];
                }
                return new string(arr);

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s61, string s62)
        {
            int size = 256;
            try
            {
                int m = s61.Length;
                int n = s62.Length;
                if (m != n)
                    return false;
                bool[] marked = new bool[size];
                for (int i = 0; i < size; i++)
                    marked[i] = false;
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /* private static int[,] HighFive(int[,] items)
         {

             try
             {
                 List<int[]> list = new List<int[]>();
                 List<int[]> result = new List<int[]>();
                 //var items = null;
                 for (int i = 0; i < items.Length; i++)
                 {
                     list.Add(new int[] { items[i, 0], items[i, 1] });
                 }
                 list.Sort((x, y) => { return (x[0] < y[0]) ? -1 : ((x[0] == y[0]) ? ((x[1] <= y[1]) ? 1 : -1) : 1); });
                 int n = list[0][0];
                 int c = 1;
                 int s = list[0][1];
                 for (int i = 1; i < list.Count; i++)
                 {
                     if (list[i][0] == n && c < 5)
                     {
                         s += list[i][1];
                         c += 1;
                     }
                     else if (list[i][0] != n)
                     {
                         result.Add(new int[] { n, s });
                         Console.WriteLine("id=" + n + " Highfive=" + s);
                         n = list[i][0];
                         c = 1;
                         s = list[i][1];
                     }
                     return false;
                 }

             catch (Exception)
             {

                 throw;
             }
         }*/

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n8)
        {
            try
            {
                static int sumDigitSquare(int n8)
                {
                    int sq = 0;
                    while (n8 > 0)
                    {
                        int digit = n8 % 10;
                        sq += digit * digit;
                        n8 = n8 / 10;
                    }
                    return sq;
                }
                HashSet<int> s = new HashSet<int>();
                s.Add(n8);
                while (true)
                {

                    // Number is Happy if we reach 1 
                    if (n8 == 1)
                        return true;

                    // Replace n with sum of squares 
                    // of digits 
                    n8 = sumDigitSquare(n8);

                    // If n is already visited, a cycle 
                    // is formed, means not Happy 
                    if (s.Contains(n8))
                        return false;

                    // Mark n as visited 
                    s.Add(n8);
                    return false;
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] ar9)
        {
            try
            {
                var n = ar9.Length;
                if (n < 2) return 0;
                for (var i = 0; i < n - 1; i++)
                    ar9[i] = ar9[i + 1] - ar9[i];
                return ar9.Where(x => x > 0).Sum() - ar9[n - 1];

            }

            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                //write your code here.

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
