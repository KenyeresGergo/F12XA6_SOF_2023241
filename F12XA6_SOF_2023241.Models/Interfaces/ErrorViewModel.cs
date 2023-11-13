namespace F12XA6_SOF_2023241.Models.Interfaces
{
    public class ErrorViewModel : IErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}