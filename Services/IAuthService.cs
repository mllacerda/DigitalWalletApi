using DigitalWalletApi.Models.DTOs;

namespace DigitalWalletApi.Services
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(RegisterDto dto);
        Task<string> LoginAsync(LoginDto dto);
    }
}