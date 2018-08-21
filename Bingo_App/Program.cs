using System;
using System.Collections.Generic;
using System.Linq;

namespace Bingo_App
{
    class Bingo
    {
        static void Main(string[] args)
        {
            

            Scorecard PlayerOne = new Scorecard();
            PlayerOne.fillCard(PlayerOne.scoreCard);
            

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
                if (PlayerOne.bingoNumbers.ContainsKey(listOfNumbers[picked]))
                {
                    MatchedNumbers.Add(PlayerOne.bingoNumbers[listOfNumbers[picked]]);
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

        public static int SetNumber(int minNum, int maxNum)
        {
            Random rnd = new Random();
            int correctNumber = rnd.Next(minNum, maxNum);
            return correctNumber;
        }


    }

    //class CallerPicksNumbers
    //{
    //    // Host selects random numbers

    //    List<int> listOfNumbers = new List<int>();
    //    List<int> CallerNumbers = new List<int>();
    //    List<int> MatchedNumbers = new List<int>();

    //    public void CallerPicks()
    //    {

    //        for (int l = 1; l <= 75; l++)
    //        {
    //            listOfNumbers.Add(l);
    //        }


    //        int picked;
    //        bool horizontalFour = false;
    //        bool corners = false;
    //        bool fullHouse = false;

    //        while (horizontalFour == false && corners == false)
    //        {
    //            picked = Bingo.SetNumber(0, (listOfNumbers.Count - 1));
    //            Console.WriteLine("And the number drawn is " + listOfNumbers[picked]);
    //            //CallerNumbers.Add(listOfNumbers[picked]);

    //            //if random number drawn = number on the scorecard, then add that key to a new list
    //            if (Bingo. PlayerOne.bingoNumbers.ContainsKey(listOfNumbers[picked]))
    //            {
    //                MatchedNumbers.Add(PlayerOne.bingoNumbers[listOfNumbers[picked]]);
    //            }
    //            listOfNumbers.RemoveAt(picked);

    //            if (MatchedNumbers.Contains(0)
    //                && MatchedNumbers.Contains(5)
    //                && MatchedNumbers.Contains(10)
    //                && MatchedNumbers.Contains(15)
    //                && MatchedNumbers.Contains(20))
    //            {
    //                horizontalFour = true;
    //                Console.WriteLine("Bingo, Top Row");
    //            }
    //            if (MatchedNumbers.Contains(1)
    //                && MatchedNumbers.Contains(6)
    //                && MatchedNumbers.Contains(11)
    //                && MatchedNumbers.Contains(16)
    //                && MatchedNumbers.Contains(21))
    //            {
    //                horizontalFour = true;
    //                Console.WriteLine("Bingo, Second Row");
    //            }

    //            if (MatchedNumbers.Contains(2)
    //                && MatchedNumbers.Contains(7)
    //                && MatchedNumbers.Contains(12)
    //                && MatchedNumbers.Contains(17)
    //                && MatchedNumbers.Contains(22))
    //            {
    //                horizontalFour = true;
    //                Console.WriteLine("Bingo, Third Row");
    //            }

    //            if (MatchedNumbers.Contains(3)
    //                && MatchedNumbers.Contains(8)
    //                && MatchedNumbers.Contains(13)
    //                && MatchedNumbers.Contains(18)
    //                && MatchedNumbers.Contains(23))
    //            {
    //                horizontalFour = true;
    //                Console.WriteLine("Bingo, Third Row");
    //            }

    //            if (MatchedNumbers.Contains(4)
    //                && MatchedNumbers.Contains(9)
    //                && MatchedNumbers.Contains(14)
    //                && MatchedNumbers.Contains(19)
    //                && MatchedNumbers.Contains(24))
    //            {
    //                horizontalFour = true;
    //                Console.WriteLine("Bingo, Bottom Row");
    //            }

    //            if (MatchedNumbers.Contains(0)
    //                && MatchedNumbers.Contains(4)
    //                && MatchedNumbers.Contains(20)
    //                && MatchedNumbers.Contains(24))
    //            {
    //                corners = true;
    //                Console.WriteLine("Bingo, Four Corners");
    //            }


    //        }

    //        //MatchedNumbers.ForEach(Console.WriteLine);
    //    }
    //}
}
