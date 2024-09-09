using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: Manager/ApproveClaim
        public IActionResult ApproveClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ApproveClaim(int claimId)
        {
            // Add logic for handling claim approval here
            return RedirectToAction("Index");
        }
    }
}
