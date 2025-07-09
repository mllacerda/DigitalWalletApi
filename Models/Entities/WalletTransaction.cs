namespace DigitalWalletApi.Models.Entities
{
    public class WalletTransaction
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string SenderWalletId { get; set; } = string.Empty;
        public string ReceiverWalletId { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }
        public Wallet SenderWallet { get; set; } = null!;
        public Wallet ReceiverWallet { get; set; } = null!;
    }
}