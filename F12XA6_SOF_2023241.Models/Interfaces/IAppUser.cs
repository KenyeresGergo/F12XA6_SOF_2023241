﻿namespace F12XA6_SOF_2023241.Models.Interfaces
{
    public interface IAppUser
    {
        string Id { get; set; }
        byte[] PhotoData { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhotoContentType { get; set; }
    }
}