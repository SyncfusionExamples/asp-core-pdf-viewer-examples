using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Syncfusion.EJ2.PdfViewer;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using Syncfusion.Pdf.Parsing;
//using SkiaSharp;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Security;
using Syncfusion.Pdf;
using System.Security.Cryptography.X509Certificates;
using Syncfusion.Drawing;
using System.IO;
using Syncfusion.Pdf.Interactive;
using Syncfusion.Pdf.Redaction;
using System.Text.Json.Nodes;
using SkiaSharp;

namespace WebApplication5.Pages
{
    [IgnoreAntiforgeryToken(Order = 1001)]
    public class IndexModel : PageModel
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IMemoryCache _cache;
        public IndexModel(IWebHostEnvironment hostingEnvironment, IMemoryCache cache)
        {
            _hostingEnvironment = hostingEnvironment;
            _cache = cache;
        }

        public class CustomToolbarItems
        {
            public CustomToolbarItems() { }
            public List<object> ToolbarItems { get; set; }

        }
    }
}