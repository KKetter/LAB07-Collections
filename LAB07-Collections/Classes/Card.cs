using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07_Collections.Classes
{
    /// <summary>
    /// assign card properties and crate enums to contain the possible values for each property
    /// </summary>
    public class Card
    {
        public CardSuites CardSuit { get; set; }
        public CardValues CardValue { get; set; }
    }
    public enum CardSuites { Hearts, Diamonds, Spades, Clubs}
    public enum CardValues { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}
}
