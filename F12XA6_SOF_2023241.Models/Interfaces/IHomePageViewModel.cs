namespace F12XA6_SOF_2023241.Models.Interfaces;

public interface IHomePageViewModel
{
    List<Studios> Studios { get; }
    int CurrentPage { get; }
    int TotalPages { get; }
}