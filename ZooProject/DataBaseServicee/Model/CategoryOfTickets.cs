using System.ComponentModel.DataAnnotations;

namespace DataBaseServicee.Model
{
    internal class CategoryOfTickets
    {
        [Key]
        public int IdOfCategoryTicket { get; set; }
        public string TicketType { get; set; }
        public int NumOfTickets { get; set; }
        public double price { get; set; }
        public bool IsDeleted { get; set; }
    }
}
