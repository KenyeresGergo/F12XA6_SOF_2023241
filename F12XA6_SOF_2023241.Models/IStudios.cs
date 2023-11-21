namespace F12XA6_SOF_2023241.Models
{
    public interface IStudios
    {
        ICollection<Game> GamesOwned { get; set; }
        string Id { get; set; }
        string? LogoSvg { get; }
        StudioName Name { get; }
        string Serial_Num { get; }

        void CopyFrom(Studios old);
    }
}