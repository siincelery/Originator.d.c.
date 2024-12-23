using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Origi.Pages.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;



namespace Origi.Pages
{
    public class Index2Model : PageModel
    {
        private readonly ApplicationContext _context;


        public bool IsSuccess { get; private set; }
        public bool IsError { get; private set; }
        public Index2Model(ApplicationContext context)
        {
            _context = context;
        }

        public List<Service> Services { get; set; } = new();

        public void OnGet()
        {
            Services = _context.Services.ToList();
        }
    }
    }
