using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class CategoryOfAnimal
    {
        [Key]
        public int IdOfCategory { get; set; }
        public string Name { get; set; }
       
    }
}
