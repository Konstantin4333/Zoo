using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZooProject.Model
{
    class Events
    {
        [Key]
        public int IdOfEvent { get; set; }

        public DateTime Date { get; set; }
         public string Name { get; set; }
        public string Description { get; set; }
        // Table EventType
        [ForeignKey("EventType")]
       
        public int IdTypeOfEvent { get; set; }
        public virtual EventType EventType { get; set; }

    }
}
