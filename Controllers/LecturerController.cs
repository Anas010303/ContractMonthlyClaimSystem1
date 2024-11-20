using ContractMonthlyClaimSystem.Data;
using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class LecturerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LecturerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Default action to display the Index view
        public IActionResult Index()
        {

            return View();
        }


        // Action to submit a claim
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitClaim(Claim model)
        {
            if (ModelState.IsValid)
            {
                model.TotalPayment = model.HoursWorked * model.HourlyRate;
                model.SubmissionDate = DateTime.Now;
                _context.Claims.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index)); // Redirect to Index after submission
            }
            return View(model);
        }

        // Action to track claims
        public IActionResult TrackClaim()
        {
            return RedirectToAction(nameof(Index)); // Redirect to Index for claims overview
        }
    }
}
