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
        public string NameOfUser { get; set; }
        public int IdOfUser { get; set; }
        // table Ticket
        [ForeignKey("Tickets")]
        public string TicketType { get; set; }
        public int NumOfTicket { get; set; }
        
       
       

        



    }
}
