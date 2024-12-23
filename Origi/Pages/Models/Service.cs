using System.ComponentModel.DataAnnotations;

namespace Origi.Pages.Models
{
    public class Service
    {
        [Key]
        public int Id_Service { get; set; }
        public string Name_Service { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Emloyee { get; set; }
        
    }
}
