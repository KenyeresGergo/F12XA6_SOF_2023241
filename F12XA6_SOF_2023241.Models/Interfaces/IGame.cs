namespace F12XA6_SOF_2023241.Models.Interfaces;

public interface IGame
{
    string Id { get; set; }
    string Title { get; set; }
    string Description { get; set; }
    int Rating { get; set; }
    string? PhotoContentType { get; set; }
    byte[]? PhotoData { get; set; }
    string StudiosId { get; set; }
    Studios Studios { get; set; }
    string OwnerId { get; set; }
    AppUser Owner { get; set; }
}