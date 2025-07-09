using DigitalWalletApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalWalletApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                var users = new[]
                {
                    new User { Username = "Marcelo", PasswordHash = BCrypt.Net.BCrypt.HashPassword("marcelo123"), Wallet = new Wallet { Balance = 1000 } },
                    new User { Username = "Franciele", PasswordHash = BCrypt.Net.BCrypt.HashPassword("franciele123"), Wallet = new Wallet { Balance = 500 } }
                };
                context.Users.AddRange(users);
                context.SaveChanges();

                var transactions = new[]
                {
                    new WalletTransaction
                    {
                        SenderWalletId = users[0].Wallet.Id,
                        ReceiverWalletId = users[1].Wallet.Id,
                        Amount = 100,
                        Timestamp = DateTime.UtcNow.AddDays(-1)
                    }
                };
                context.WalletTransactions.AddRange(transactions);
                context.SaveChanges();
            }
        }
    }
}