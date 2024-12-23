using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Origi.Pages.Models;

namespace Origi.Pages
{
    public class Index3Model : PageModel
    {
        private readonly ApplicationContext _context;

        public Index3Model(ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Admin Admin { get; set; } = new Admin(); 
        public bool IsSuccess { get; private set; }
        public bool IsError { get; private set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // �������� ������
            var admin = await _context.Admins.FirstOrDefaultAsync(a => a.Login_Admin == Admin.Login_Admin);
            if (admin != null && admin.Password == Admin.Password)
            {
                IsSuccess = true; // �������� �����������
                return RedirectToPage("Index4"); // ������� �� �������� Orders
            }
            else
            {
                IsError = true; // ������ �����������
                ModelState.AddModelError(string.Empty, "�������� ����� ��� ������.");
                return Page();
            }
        }
    }
}
