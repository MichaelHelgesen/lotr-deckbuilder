

List<Card> deck = new List<Card>();

deck.Add(new Card(title: "Aragorn", sphere: "Leadership", threat: 12, willpower: 3, type: "Hero"));
deck.Add(new Card(title: "Gandalf", sphere: "Lore", threat: 3, willpower: 3, type: "Ally"));

foreach (Card card in deck)
{
    Console.WriteLine(card.Title);
}

deck.Remove(deck[0]); // fjerner første kort
Console.WriteLine(deck.Count); // antall kort i listen


