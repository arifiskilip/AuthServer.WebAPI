using AuthServer.Core.Dtos;
using SharedLibrary.ResponseDto;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<AppUserDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<AppUserDto>> GetUserByNameAsync(string userName);
    }
}
