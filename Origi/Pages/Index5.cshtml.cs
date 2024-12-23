using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Origi.Pages.Models;

namespace Origi.Pages
{
    public class Index5Model : PageModel
    {
        ApplicationContext _context;

        [BindProperty]
        public Client Client { get; set; } = new();

       
       

        public Service SelectedService { get; set; }
        public List<Service> Services { get; set; }
        public Index5Model(ApplicationContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync(int serviceId)
        {
            if (serviceId > 0) 
            {
                SelectedService = await _context.Services.FindAsync(serviceId);
                if (SelectedService == null) // Проверяем, что услуга найдена
                {
                    
                    RedirectToPage("Index"); // Или другая логика
                }
                Services = await _context.Services.ToListAsync();
            }
            else
            {
                // Если serviceId не верен, то устанавливаем SelectedService в null
                SelectedService = null;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && !string.IsNullOrEmpty(Client.Name_client))
            {
                
                _context.Clients.Add(Client);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

