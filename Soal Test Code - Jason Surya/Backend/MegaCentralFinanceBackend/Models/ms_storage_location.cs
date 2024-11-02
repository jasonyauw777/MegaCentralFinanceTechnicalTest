using System.ComponentModel.DataAnnotations;

namespace MegaCentralFinanceBackend.Models
{
    public class ms_storage_location
    {
        [Key]
        public string location_id { get; set; }
        public string location_name { get; set; }
    }
}
