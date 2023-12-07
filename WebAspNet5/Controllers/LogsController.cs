using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAspNet5.Models.Repository;

namespace WebAspNet5.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogRepository _logRepository;
        public LogsController(ILogRepository logRepository)
        {
            _logRepository = logRepository; 
        }
        public async Task<IActionResult> Index()
        {
            var logs = await _logRepository.GetRequest();
            return View(logs);
        }
    }
}
