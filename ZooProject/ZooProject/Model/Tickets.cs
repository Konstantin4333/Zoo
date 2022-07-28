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
        [ForeignKey("CategoryOfTickets")]
        public int IdOfCategoryTicket { get; set; }
        
        public virtual CategoryOfTickets CategoryOfTickets { get; set; }




    }
}
