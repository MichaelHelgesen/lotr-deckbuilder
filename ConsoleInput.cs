public class ConsoleInput
{
    // Ansvar: sjekke om brukeren angir et tall
    // Angitt som private for tydelighet (selv om private er default)
        // fordi den kun brukes internt i denne klassen
    private static int LesHeltall(string promptTekst)
    {   // Her må verdi legges til, fordi kompilatoren protesterer hvis ikke,
        // siden kodeblokken i catch ikke tilegner variabelen noe
        int numberToCheck = 0;
        bool success = false;

        do
        {
            Console.Write(promptTekst);
            try
            {
                numberToCheck = int.Parse(Console.ReadLine());
                success = true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        } while (!success);

        return numberToCheck;
    }

    // Ansvar: samle input fra bruker, returnere ETT ferdig Card-objekt
    // Angitt som private for tydelighet (selv om private er default)
        // fordi den kun brukes internt i denne klassen
    private static Card LagKort()
    {
        Console.WriteLine("Title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Sphere: ");
        string sphere = Console.ReadLine();

        int threat = LesHeltall("Threat (heltall): ");
        int willpower = LesHeltall("Willpower (heltall): ");

        Console.WriteLine("Type: ");
        string type = Console.ReadLine();

        return new Card(title: title, sphere: sphere, threat: threat, willpower: willpower, type: type);
    }

    // Ansvar: gjenta "lag kort og legg til i deck" til brukeren vil stoppe
    // Angitt som public, siden den kalles fra Program.cs
    public static void LeggTilKort(List<Card> deck)
    {
        // Jeg hadde "= false" på denne, men det er ikke nødvendig
        // siden alle veier i koden tilegner den en verdi.
        bool createCard; // = false;
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
            else
            {
                createCard = false;
            }
        } while (createCard);

    }
}