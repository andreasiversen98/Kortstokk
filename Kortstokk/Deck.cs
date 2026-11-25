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

    public void Shuffle()
    {
        Random random = new Random();
        List<Card> shuffled = new List<Card>();
        
        while (cards.Count > 0)
        {
            int index = random.Next(cards.Count);
            shuffled.Add(cards[index]);
            cards.RemoveAt(index);
        }
        cards = shuffled;
    }
}
