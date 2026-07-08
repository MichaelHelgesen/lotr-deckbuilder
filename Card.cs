public class Card
{
    public string Title { get; set; }
    public string Sphere { get; set; }
    public int Threat { get; set; }
    public int Willpower { get; set; }
    public string Type { get; set; }
    public Card(string title, string sphere, int threat, int willpower, string type)
   {
      this.Title = title;
      this.Sphere = sphere;
      this.Threat = threat;
      this.Willpower = willpower;
      this.Type = type;
   }
}