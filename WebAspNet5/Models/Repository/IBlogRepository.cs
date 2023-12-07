using System.Threading.Tasks;
using WebAspNet5.Models.Db;

namespace WebAspNet5.Models.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
