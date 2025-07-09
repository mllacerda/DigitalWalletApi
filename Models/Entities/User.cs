﻿namespace DigitalWalletApi.Models.Entities
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public Wallet Wallet { get; set; } = null!;
    }
}