using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class CategoryOfTickets
    {
        [Key]
        public int IdOfCategoryTicket { get; set; }
        public string TicketType { get; set; }
        public int NumOfTickets { get; set; }
        public double price { get; set; }
        public bool IsDeleted { get; set; }

    }
}
