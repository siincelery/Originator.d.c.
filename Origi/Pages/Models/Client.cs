using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Origi.Pages.Models
{
   
    public class Client
    {
        [Key]
        public int Id_Client { get; set; }
        
        public string Name_client { get; set; }
        public string Phone_cleint { get; set; }
        public string Url_client { get; set; }

      
    }
}
