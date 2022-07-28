using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class EventType
    {
        [Key]
        public string IdTypeOfEvent { get; set; }

        public string Type { get; set; }
        

    }
}
