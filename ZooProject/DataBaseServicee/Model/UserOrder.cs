using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseServicee.Model
{
    public class UserOrder
    {
        [Key]
        public int IdOrder { get; set; }
        // Table User
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public virtual User User { get; set; }
       
        public string TypeOfTicket { get; set; }
        public int price { get; set; }
       
        public bool IsDeleted { get; set; }
    }
}
