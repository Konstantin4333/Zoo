using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZooProject.Model
{
    class Tickets
    {
        [Key]
        public int IdOfTicket { get; set; }
        public string Name { get; set; }
        public int NumOfTickets { get; set; }
        //
        [ForeignKey("CategoryOfTicket")]
        public string TicketCategoryId { get; set; }
        public string TicketType { get; set; }
        



    }
}
