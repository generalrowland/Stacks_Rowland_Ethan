// See https://aka.ms/new-console-template for more information
using Stacks_Rowland_Ethan;

{
    Card[] myCardsArray = new Card[]
    {
        new Card("Ace", "Spades"),
        new Card("Courier", "Clubs"),
        new Card("Edmund", "Hearts"),
        new Card("9", "Diamonds"),
        new Card("8", "Spades"),
        new Card("2", "Hearts"),
        new Card("11", "Clubs"),
        new Card("5", "Spades"),
        new Card("4", "Diamonds"),
    };

    Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

    Console.WriteLine("Cards in Deck:");
    foreach(Card card in startingDeck)
    {
        Console.WriteLine($"The {card.Number} of {card.Suit}!");
    }

    Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

    List<Card> myHand = new List<Card>();
    myHand.Add(new Card("Jameson", "Diamonds"));
    myHand.Add(new Card("6", "Clubs"));
    myHand.Add(new Card("1", "Hearts"));

    Console.WriteLine("Got any 6's?");
    if(startingDeck.Count > 0)
    {
        myHand.Add(startingDeck.Pop());
    }

    Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

    startingDeck.Push(myHand[0]);
    myHand.RemoveAt(0);

    Console.WriteLine("Cards in Deck:");
    foreach (Card card in startingDeck)
    {
        Console.WriteLine($"The {card.Number} of {card.Suit}!");
    }

}