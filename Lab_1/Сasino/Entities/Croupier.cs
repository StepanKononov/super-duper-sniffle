namespace Сasino.Entities;

public class Croupier
{
    public readonly CardDeck CardDeck;
    
    private Random _random;

    public Croupier()
    {
        CardDeck = new CardDeck();
        _random = new Random();
        
        ShuffleCards(_random);
    }

    private void ShuffleCards(Random random)
    {
        int deckLength = CardDeck.Cards.Length;
        
        for (int i = 0; i < deckLength; i++)
        {
            Card tempCard = CardDeck.Cards[i];
            int ranIndex = random.Next(i, deckLength - 1);

            CardDeck.Cards[i] = CardDeck.Cards[ranIndex];
            CardDeck.Cards[ranIndex] = tempCard;
        }
    }

}