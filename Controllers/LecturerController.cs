using Microsoft.AspNetCore.Mvc;
using ContractMonthlyClaimSystem.Models;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        // GET: Lecturer/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: Lecturer/SubmitClaim
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitClaim(Claim model)
        {
            // Add logic for handling claim submission here
            return RedirectToAction("TrackClaim");
        }

        // GET: Lecturer/TrackClaim
        public IActionResult TrackClaim()
        {
            return View();
        }
    }
}
