﻿using Microsoft.AspNetCore.Mvc;

namespace ContractClaimSystem.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ApproveClaim()
        {
            // Logic for approving claim
            return View();
        }

        public IActionResult TrackClaim()
        {
            // Logic for tracking approved claims
            return View();
        }
       
    }
}
