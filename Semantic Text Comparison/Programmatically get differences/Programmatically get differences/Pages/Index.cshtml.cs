using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Programmatically_get_differences.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("PDF Comparison page loaded");
        }

        /// <summary>
        /// API endpoint to handle PDF comparison results from frontend
        /// </summary>
        public IActionResult OnPostComparisonResult([FromBody] ComparisonResultRequest request)
        {
            try
            {
                _logger.LogInformation($"Received comparison result with {request?.TotalDifferences ?? 0} differences");
                return new JsonResult(new { success = true, message = "Comparison result received" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing comparison result");
                return new JsonResult(new { success = false, message = ex.Message });
            }
        }
    }

    public class ComparisonResultRequest
    {
        public int TotalDifferences { get; set; }
        public SummaryInfo Summary { get; set; }
        public Dictionary<string, PageInfo> ByPage { get; set; }
    }

    public class SummaryInfo
    {
        public int Added { get; set; }
        public int Deleted { get; set; }
        public int Modified { get; set; }
    }

    public class PageInfo
    {
        public int Added { get; set; }
        public int Deleted { get; set; }
        public int Modified { get; set; }
        public List<DifferenceDetail> Details { get; set; }
    }

    public class DifferenceDetail
    {
        public string Type { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }
    }
}
