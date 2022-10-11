using System.ComponentModel.DataAnnotations;

namespace DataBaseServicee.Model
{
    public class CategoryOfTickets
    {
        [Key]
        public int IdOfCategoryTicket { get; set; }
        public string TicketType { get; set; }
        public int NumOfTickets { get; set; }
        public double price { get; set; }
        public int IsDeleted { get; set; }
    }
}
