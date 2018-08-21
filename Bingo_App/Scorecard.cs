using System;
using System.Collections.Generic;

namespace Bingo_App
{
    internal class Scorecard
    {
        public int[,] scoreCard = new int[5, 5];
        public Dictionary<int, int> bingoNumbers = new Dictionary<int, int>();

        //public Scorecard(int columns, int rows)
        //{
        //    scoreCard = new int[columns, rows];
        //}

        public Array fillCard(int[,] scoreCard)
        {
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
                            k = Bingo.SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 1:
                            //scoreCard[i, j] = SetNumber(16, 30);
                            k = Bingo.SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 2:
                            //scoreCard[i, j] = SetNumber(31, 45);
                            k = Bingo.SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 3:
                            //scoreCard[i, j] = SetNumber(46, 60);
                            k = Bingo.SetNumber(0, (listOfIntegers.Count - 1));
                            scoreCard[i, j] = listOfIntegers[k];
                            listOfIntegers.RemoveAt(k);
                            bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            //bingoNumbers.Add(scoreCard[i, j], (5 * i) + j);
                            break;
                        case 4:
                            //scoreCard[i, j] = SetNumber(61, 75);
                            k = Bingo.SetNumber(0, (listOfIntegers.Count - 1));
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
            foreach (KeyValuePair<int, int> kvp in bingoNumbers)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            return scoreCard;

        }
    }
}