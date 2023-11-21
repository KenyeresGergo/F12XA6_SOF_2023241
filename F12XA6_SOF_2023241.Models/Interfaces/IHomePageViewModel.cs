namespace F12XA6_SOF_2023241.Models.Interfaces;

public interface IHomePageViewModel
{
    List<Studios> Studios { get; set; }
    int CurrentPage { get; set; }
    int TotalPages { get; set; }
}