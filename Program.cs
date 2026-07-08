using System.Linq;



List<Card> deck = new List<Card>();

deck.Add(new Card(title: "Aragorn", sphere: "Leadership", threat: 12, willpower: 3, type: "Hero"));
deck.Add(new Card(title: "Gandalf", sphere: "Lore", threat: 3, willpower: 3, type: "Ally"));
deck.Add(new Card(title: "Gandalf", sphere: "Lore", threat: 3, willpower: 3, type: "Ally"));


foreach (Card card in deck)
{
    Console.WriteLine(card.Title);
}

List<Card> filteredDeck = deck.Where(Card => Card.Sphere == "Lore").ToList();

//deck.Remove(deck[0]); // fjerner første kort
Console.WriteLine(deck.Count); // antall kort i listen
Console.WriteLine(filteredDeck.Count);


// Ansvar: samle input fra bruker, returnere ETT ferdig Card-objekt
static Card LagKort()
{
    bool success = false;
    string title;
    string sphere;
    int threat = 0;
    int willpower = 0;
    string type;

    Console.WriteLine("Title: ");
    title = Console.ReadLine();
    Console.WriteLine("Sphere: ");
    sphere = Console.ReadLine();
    do
    {
        Console.Write("Threat(heltall): ");
        try
        {
            // Code that might throw an exception
            threat = int.Parse(Console.ReadLine());
            success = true;
        }
        catch (FormatException ex)
        {
            // Code to handle a specific error
            Console.WriteLine($"Error: {ex.Message}");
        }
    } while (!success);
    success = false;
    do
    {
        Console.Write("Willpower(heltall): ");
        try
        {
            // Code that might throw an exception
            willpower = int.Parse(Console.ReadLine());
            success = true;
        }
        catch (FormatException ex)
        {
            // Code to handle a specific error
            Console.WriteLine($"Error: {ex.Message}");
        }
    } while (!success);
    success = false;
    Console.WriteLine("Type: ");
    type = Console.ReadLine();

    return new Card(title: title, sphere: sphere, threat: threat, willpower: willpower, type: type);

    // spør om title, sphere, threat, willpower, type (med validering for int-feltene)
    // return new Card(...);

}

// Ansvar: gjenta "lag kort og legg til i deck" til brukeren vil stoppe
static void LeggTilKort(List<Card> deck)
{
    bool createCard = false;
    string answer;

    do
    {
        //   1. kall LagKort()
        deck.Add(LagKort());
        Console.WriteLine(deck.Count); // antall kort i listen
        do
        {
            Console.WriteLine("Legg til flere?: ");
            answer = Console.ReadLine();

        } while (answer != "j" && answer != "n");
        if (answer == "j")
        {
            createCard = true;
        }
        else if (answer == "n")
        {
            createCard = false;
        }
    } while (createCard);

}

LeggTilKort(deck);


