using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebApplication8.Models;
namespace WebApplication8.Pages
{
    public class IndexModel : PageModel
    {
        // проблема в option
        private readonly ILogger<IndexModel> _logger;
        List<MyType> types;
        public List<MyType> MyTypes { set; get; }
        
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            types = new List<MyType>()
            {
                new MyType{MyName="Фотография"},
                new MyType{MyName="Открытка"},
                new MyType{MyName="Письмо"},
                new MyType{MyName="Проповедь"},
                new MyType{MyName="Записки технические"},
                new MyType{MyName="Записки богословские"},
                new MyType{MyName="Записки бытовые, документы"}
            };
        }
        

        public void OnGet()
        {

        }
        public void OnPostSave()
        {

        }
    }
}
