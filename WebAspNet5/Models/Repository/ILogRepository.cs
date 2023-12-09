using System.Threading.Tasks;
using Model;

namespace WebAspNet5.Models.Repository
{
    public interface ILogRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequest();
    }
}
