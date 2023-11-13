using F12XA6_SOF_2023241.Models.Interfaces;

namespace F12XA6_SOF_2023241.Models
{
    public interface IGame
    {
        string? ContentType { get; set; }
        string Description { get; set; }
        string Id { get; }
        AppUser? Owner { get; set; }
        string? OwnerId { get; set; }
        byte[]? PhotoData { get; set; }
        int Rating { get; set; }
        string Title { get; set; }
    }
}