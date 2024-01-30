namespace F12XA6_SOF_2023241.Models.Interfaces
{
    public interface IComment
    {
        string Content { get; set; }
        DateTime CreatedOn { get; set; }
        string GameId { get; set; }
        string Id { get; set; }
        AppUser Owner { get; set; }
        int ReactionCounter { get; set; }
    }
}