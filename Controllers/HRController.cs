using ContractMonthlyClaimSystem.Data;
using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class HRController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Default action to display the list of claims for processing
        public IActionResult Index()
        {
            return View();
        }

        // Approve a claim
        [HttpPost]
        public IActionResult ProcessClaims(int id)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.ClaimId == id);
            if (claim != null)
            {
                claim.Status = "Approved";
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }


        // Track claims
        public IActionResult TrackClaims()
        {
            var claims = _context.Claims.ToList();
            return View(claims);
        }
    }
}
