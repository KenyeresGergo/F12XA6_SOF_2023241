namespace F12XA6_SOF_2023241.Models
{
    public interface IGame
    {
        string? ContentType { get; set; }
        string Description { get; set; }
        string Id { get; }
        byte[]? PhotoData { get; set; }
        int Rating { get; set; }
        StudioName StudioName { get; set; }
        string Title { get; set; }
    }
}