using System.Threading.Tasks;

namespace YogurtBank.Services
{
    public interface IUserRepository
    {
        Task<Models.UserDetailsDTO> FindUserAsync(int userId);
        Task<Models.UserDetailsDTO> AddUserAsync(Models.UserCreateDTO user);
        Task UpdateUserAsync(int id, Models.UserUpdateDTO user);
       
    }
}
