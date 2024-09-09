using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class CoordinatorController : Controller
    {
        // GET: Coordinator/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: Coordinator/VerifyClaim
        public IActionResult VerifyClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VerifyClaim(int claimId)
        {
            // Add logic for handling claim verification here
            return RedirectToAction("Index");
        }
    }
}
