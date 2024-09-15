namespace AnimeApi.Services.Interfaces
{
    public interface IAuthenticateService
    {
        string GenerateJwtToken(string username);
    }
}
