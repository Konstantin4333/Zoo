using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class EventType
    {
        [Key]
        public int IdTypeOfEvent { get; set; }

        public string Type { get; set; }
      
        

    }
}
