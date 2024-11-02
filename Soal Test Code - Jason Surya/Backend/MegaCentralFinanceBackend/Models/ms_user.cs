using System.ComponentModel.DataAnnotations;

namespace MegaCentralFinanceBackend.Models
{
    public class ms_user
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public bool is_active { get; set; }
    }
}
