#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ALOHA.Data;
using ALOHA.Models;

namespace ALOHA.Pages.Products
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly ALOHA.Data.ALOHAContext _context;

        public IndexModel(ALOHA.Data.ALOHAContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }
        [BindProperty(SupportsGet=true)]
        public string   SearchString { get; set; }
        public SelectList Product { get; set;  }
        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }


        public async Task OnGetAsync()
        
        {
            var Products = from p in _context.Item select p;
            if (!string.IsNullOrEmpty(SearchString))
                Products = Products.Where(s => s.ProductName.Contains(SearchString));


            Item = await _context.Item.ToListAsync();
        }

#pragma warning disable CS8618
#pragma warning disable CS8604
    }
}
