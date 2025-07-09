namespace DigitalWalletApi.Models.Entities
{
    public class Wallet
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = string.Empty;
        public decimal Balance { get; set; }
        public User User { get; set; } = null!;
        public List<WalletTransaction> SentTransactions { get; set; } = new();
        public List<WalletTransaction> ReceivedTransactions { get; set; } = new();
    }
}