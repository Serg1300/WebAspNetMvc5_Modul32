using System.Threading.Tasks;
using WebAspNet5.Models.Db;

namespace WebAspNet5.Models.Repository
{
    public interface ILogRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequest();
    }
}
