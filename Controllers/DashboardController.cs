using Microsoft.AspNetCore.Mvc;

namespace MVC_APP.Controllers
{
    public class DashboardController : Controller
    {
        // Main dashboard page
        public IActionResult Index()
        {
            return View();
        }

        // Department report page
        public IActionResult DepartmentReport()
        {
            return View(); // Load Views/Dashboard/DepartmentReport.cshtml
        }

        // Action to show report form (if needed)
        public IActionResult ShowReportForm()
        {
            // Logic to prepare the report form
            ViewBag.ShowForm = true;
            return View("DepartmentReport");
        }

        // Action to generate report (simulate)
        [HttpPost]
        public IActionResult GenerateReport()
        {
            // Dummy report HTML
            string reportHtml = "<h3>Report Results</h3><p>This is a sample report.</p>";
            ViewBag.ReportHtml = reportHtml;
            ViewBag.ShowForm = false; // or true if you want to show the form again
            return View("DepartmentReport");
        }
    }
}