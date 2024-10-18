using Microsoft.AspNetCore.Mvc;

namespace ContractClaimSystem.Controllers
{
    public class HRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessClaim()
        {
            // Logic for processing claims
            return View();
        }

        public IActionResult TrackClaim()
        {
            // Logic for tracking processed claims
            return View();
        }
    }
}
