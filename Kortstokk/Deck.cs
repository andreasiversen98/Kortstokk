namespace Kortstokk;

class Deck
{
    private List<Card> cards = new List<Card>();

    public Deck()
    {
        for (int s = 0; s < 4; s++)
        {
            for (int r = 0; r < 13; r++)
            {
                cards.Add(new Card((Suit)s, (Rank)r));
            }
        }
    }

    public void Draw()
    {
        if (cards.Count == 0)
        {
            Console.WriteLine("Det er ingen kort igjen");
            return;
        }

        Card card = cards[0];
        cards.RemoveAt(0);
        Console.WriteLine($"{card.Rank} of {card.Suit}");
    }
}
