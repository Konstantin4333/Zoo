using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZooProject.Model
{
    class UserOrder
    {
        [Key]
        public int  IdOrder { get; set; }
        // Table User
        [ForeignKey("User")]
        public int IdUser { get; set; }
        public User User { get; set; }
        // table Ticket
        [ForeignKey("Tickets")]

        public int IdOfTicket { get; set; }
        public virtual Tickets Tickets { get; set; }







    }
}
