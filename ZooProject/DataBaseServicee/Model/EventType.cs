
using System.ComponentModel.DataAnnotations;

namespace DataBaseServicee.Model
{
    public class EventType
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }
        public bool IsDeleted { get; set; }
    }
}
