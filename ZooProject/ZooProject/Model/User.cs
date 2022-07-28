using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class User
    {
        [Key]
        public int IdUser { get; set; }

        public string Name { get; set; }

    }
}
