using ContractMonthlyClaimSystem.Data;
using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class CoordinatorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoordinatorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Default action to display the Index view
        public IActionResult Index()
        {
            return View();
        }

        // Action to verify claims
        public IActionResult VerifyClaim()
        {
            return RedirectToAction(nameof(Index)); // Redirect to Index for claims overview
        }

        // Approve a claim
        [HttpPost]
        public IActionResult ApproveClaim(int id)
        {
            var claim = _context.Claims.Find(id);
            if (claim != null)
            {
                claim.Status = "Approved";
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        // Reject a claim
        [HttpPost]
        public IActionResult RejectClaim(int id)
        {
            var claim = _context.Claims.Find(id);
            if (claim != null)
            {
                claim.Status = "Rejected";
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
