using System;
using LAB07_Collections.Classes;


namespace LAB07_Collections
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //CreateDeck();
            //Menu();
        }
        /// <summary>
        /// 
        /// </summary>
        public static void Menu()
        {
            //Interface is running
            bool running = true;
            //while the interface is running please display the menu
            while (running)
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1: Add a Card");
                Console.WriteLine("2: Delete a Card");
                Console.WriteLine("3: Count Cards In Deck");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Deck<Card> CreateDeck()
        {
            Card cardOne = new Card();
            cardOne.CardSuit = CardSuites.Hearts;
            cardOne.CardValue = CardValues.Ace;

            Card cardTwo = new Card();
            cardTwo.CardSuit = CardSuites.Hearts;
            cardTwo.CardValue = CardValues.King;

            Card cardThree = new Card();
            cardThree.CardSuit = CardSuites.Hearts;
            cardThree.CardValue = CardValues.Queen;

            Card cardFour = new Card();
            cardFour.CardSuit = CardSuites.Hearts;
            cardFour.CardValue = CardValues.Jack;

            Card cardFive = new Card();
            cardFive.CardSuit = CardSuites.Diamonds;
            cardFive.CardValue = CardValues.Ten;

            Card cardSix = new Card();
            cardSix.CardSuit = CardSuites.Diamonds;
            cardSix.CardValue = CardValues.Nine;

            Card cardSeven = new Card();
            cardSeven.CardSuit = CardSuites.Diamonds;
            cardSeven.CardValue = CardValues.Eight;

            Card cardEight = new Card();
            cardEight.CardSuit = CardSuites.Diamonds;
            cardEight.CardValue = CardValues.Seven;

            Card cardNine = new Card();
            cardNine.CardSuit = CardSuites.Spades;
            cardNine.CardValue = CardValues.Six;

            Card cardTen = new Card();
            cardTen.CardSuit = CardSuites.Spades;
            cardTen.CardValue = CardValues.Five;

            Card cardEleven = new Card();
            cardEleven.CardSuit = CardSuites.Spades;
            cardEleven.CardValue = CardValues.Four;

            Card cardTwelve = new Card();
            cardTwelve.CardSuit = CardSuites.Spades;
            cardTwelve.CardValue = CardValues.Three;

            Card cardThirteen = new Card();
            cardThirteen.CardSuit = CardSuites.Clubs;
            cardThirteen.CardValue = CardValues.Two;

        }

    }
}
