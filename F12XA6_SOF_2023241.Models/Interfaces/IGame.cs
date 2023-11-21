namespace F12XA6_SOF_2023241.Models.Interfaces;

public interface IGame
{
    string Id { get; }
    string Title { get; set; }
    string Description { get; set; }
    int Rating { get; set; }
    string? PhotoContentType { get; set; }
    byte[]? PhotoData { get; set; }
}