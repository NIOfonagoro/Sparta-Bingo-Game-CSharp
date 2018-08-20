using System;
using System.Collections.Generic;
using System.Linq;

namespace Bingo_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = SetNumber(1,10);

            

            int[,] scoreCard = new int[5, 5];
            Dictionary<int, int> bingoNumbers = new Dictionary<int, int>();
            //IEnumerable<int> NumbersList = Enumerable.Range(1, 75);
            //NumbersList.Select(x => x*x);
            //foreach (int num in NumbersList)
            //{
            //    Console.WriteLine(num);
            //}


            for (int i = 0; i < 5; i++)
            {
                List<int> listOfIntegers = new List<int>();
                switch (i)
                {
                    case 0:
                        for (int l = 1; l <= 15; l++)
                        {
                            listOfIntegers.Add(l);
                        }
                        break;
                    case 1:
                        for (int l = 16; l <= 30; l++)
                        {
                            listOfIntegers.Add(l);
                        }
                        break;
                    case 2:
                        for (int l = 31; l <= 45; l++)
                        {
                            listOfIntegers.Add(l);
                        }
                        break;
                    case 3:
                        for (int l = 46; l <= 60; l++)
                        {
                            listOfIntegers.Add(l);
                        }
                        break;
                    case 4:
                        for (int l = 61; l <= 75; l++)
                        {
                            listOfIntegers.Add(l);
                        }
                        break;
                }

                //listOfIntegers.ForEach(Console.WriteLine);

                for (int j = 0; j < 5; j++)
                {
                    int k;
                    switch (i)
                    {
                        case 0:
                            //scoreCard[i,j] = SetNumber(1, 15);
                            k = SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 1:
                            //scoreCard[i, j] = SetNumber(16, 30);
                            k = SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 2:
                            //scoreCard[i, j] = SetNumber(31, 45);
                            k = SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 3:
                            //scoreCard[i, j] = SetNumber(46, 60);
                            k = SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 4:
                            //scoreCard[i, j] = SetNumber(61, 75);
                            k = SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                    }
                }
            //Console.WriteLine(listOfIntegers[0]);
            //Console.WriteLine(listOfIntegers[14]);

            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(scoreCard[i, j]);
                }
            }

            //foreach (KeyValuePair<int, int> kvp in bingoNumbers)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}
            

            // Host selects random numbers

            List<int> listOfNumbers = new List<int>();          
            List<int> CallerNumbers = new List<int>();          
            List<int> MatchedNumbers = new List<int>();          
            
            for (int l = 1; l <= 75; l++)
            {
                listOfNumbers.Add(l);
            }


            int picked;
            bool horizontalFour = false;
            bool corners = false;
            bool fullHouse = false;

            while(horizontalFour == false && corners == false)
            {
                picked = SetNumber(0, (listOfNumbers.Count - 1));
                Console.WriteLine("And the number drawn is " + listOfNumbers[picked]);
                //CallerNumbers.Add(listOfNumbers[picked]);

                //if random number drawn = number on the scorecard, then add that key to a new list
                if (bingoNumbers.ContainsKey(listOfNumbers[picked]))
                {
                    MatchedNumbers.Add(bingoNumbers[listOfNumbers[picked]]);
                }
                listOfNumbers.RemoveAt(picked);

                if (MatchedNumbers.Contains(0)
                    && MatchedNumbers.Contains(5)
                    && MatchedNumbers.Contains(10)
                    && MatchedNumbers.Contains(15)
                    && MatchedNumbers.Contains(20))
                {
                    horizontalFour = true;
                    Console.WriteLine("Bingo, Top Row");
                }
                if (MatchedNumbers.Contains(1)
                    && MatchedNumbers.Contains(6)
                    && MatchedNumbers.Contains(11)
                    && MatchedNumbers.Contains(16)
                    && MatchedNumbers.Contains(21))
                {
                    horizontalFour = true;
                    Console.WriteLine("Bingo, Second Row");
                }
                
                if (MatchedNumbers.Contains(2)
                    && MatchedNumbers.Contains(7)
                    && MatchedNumbers.Contains(12)
                    && MatchedNumbers.Contains(17)
                    && MatchedNumbers.Contains(22))
                {
                    horizontalFour = true;
                    Console.WriteLine("Bingo, Third Row");
                }
                
                if (MatchedNumbers.Contains(3)
                    && MatchedNumbers.Contains(8)
                    && MatchedNumbers.Contains(13)
                    && MatchedNumbers.Contains(18)
                    && MatchedNumbers.Contains(23))
                {
                    horizontalFour = true;
                    Console.WriteLine("Bingo, Third Row");
                }

                if (MatchedNumbers.Contains(4)
                    && MatchedNumbers.Contains(9)
                    && MatchedNumbers.Contains(14)
                    && MatchedNumbers.Contains(19)
                    && MatchedNumbers.Contains(24))
                {
                    horizontalFour = true;
                    Console.WriteLine("Bingo, Bottom Row");
                }

                if (MatchedNumbers.Contains(0)
                    && MatchedNumbers.Contains(4)
                    && MatchedNumbers.Contains(20)
                    && MatchedNumbers.Contains(24))
                {
                    corners = true;
                    Console.WriteLine("Bingo, Four Corners");
                }
                

            }

            //MatchedNumbers.ForEach(Console.WriteLine);


            Console.ReadKey();       
           

        }

        static int SetNumber(int minNum, int maxNum)
        {
            Random rnd = new Random();
            int correctNumber = rnd.Next(minNum, maxNum);
            return correctNumber;
        }


    }
}
