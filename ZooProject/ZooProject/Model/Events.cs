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

        public double Date { get; set; }
        // Table EventType
        [ForeignKey("EventType")]
        public string TypeOfEvent { get; set; }
        public int TypeOfEventId { get; set; }

    }
}
