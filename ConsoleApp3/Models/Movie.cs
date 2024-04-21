namespace ConsoleApp3.Models;


internal class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DirectorId { get; set; }
    public int ImdbScore { get; set; }
    public int Duration { get; set; }
}
