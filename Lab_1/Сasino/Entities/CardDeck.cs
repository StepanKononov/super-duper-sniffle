using Сasino.Entities.CardValue;

namespace Сasino.Entities;

public class CardDeck
{
    private const int CardAmount = 52;

    public readonly Card[] Cards;

    public CardDeck() => 
        Cards = GenerateDeck(CardAmount);

    private Card[] GenerateDeck(int cardAmount)
    {
        Card[] cards = new Card[cardAmount];
        
        int i = 0;
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
            {
                cards[i] = new Card(rank, suit);
                i++;
            }
        }
        return cards;
    }
}