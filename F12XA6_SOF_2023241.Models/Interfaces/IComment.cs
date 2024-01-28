namespace F12XA6_SOF_2023241.Models
{
    public interface IComment
    {
        string Content { get; set; }
        Game Game { get; set; }
        string Id { get; set; }
        int ReactionCounter { get; set; }
        AppUser User { get; set; }
    }
}