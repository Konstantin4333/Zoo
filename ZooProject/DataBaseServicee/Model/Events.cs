using DataBaseServicee.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataBaseServicee.Model
{
    public class Events
    {
        [Key]
        public int IdOfEvent { get; set; }

        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsDeleted { get; set; }
        // Table EventType
        [ForeignKey("EventType")]

        public int Id { get; set; }
        public virtual EventType EventType { get; set; }
    }
}
