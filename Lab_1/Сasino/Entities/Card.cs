using Сasino.Entities.CardValue;

namespace Сasino.Entities;

public class Card
{
    public readonly CardRank Rank;
    public readonly CardSuit Suit;

    public Card(CardRank rank, CardSuit suit)
    {
        Rank = rank;
        Suit = suit;
    }
}