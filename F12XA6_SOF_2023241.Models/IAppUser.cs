namespace F12XA6_SOF_2023241.Models
{
    public interface IAppUser
    {
        byte[] Data { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhotoContentType { get; set; }
    }
}