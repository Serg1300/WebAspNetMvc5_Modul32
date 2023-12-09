using System.Threading.Tasks;
using Model;

namespace WebAspNet5.Models.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
