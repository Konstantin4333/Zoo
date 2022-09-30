using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseServicee.Model
{
    internal class UserOrder
    {
        [Key]
        public int IdOrder { get; set; }
        // Table User
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public User User { get; set; }
        public bool IsDeleted { get; set; }
    }
}
