using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using Origi.Pages.Models;
using System;

namespace Origi.Pages
{
    public class Index4Model : PageModel
    {
        private readonly ApplicationContext _context;
        public Client Client { get; set; }
        [BindProperty]
        public Service Services { get; set; } = new();
        public List<Service> AllServices { get; private set; } = new(); 

        public Index4Model(ApplicationContext context)
        {
            _context = context;
        }

        public List<Client> Clients { get; set; } = new();

        public void OnGet()
        {
            Clients = _context.Clients.ToList();
            AllServices = _context.Services.ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); 
            }

            if (Services.Id_Service > 0)
            {
                _context.Services.Update(Services);
            }
            else
            {
                _context.Services.Add(Services);
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("Index4");
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var serviceToDelete = await _context.Services.FindAsync(id);

            if (serviceToDelete != null)
            {
                _context.Services.Remove(serviceToDelete);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
