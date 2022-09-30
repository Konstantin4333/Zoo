using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class CategoryOfAnimal
    {
      //  public int idOfCategory = 0;
        [Key]
        public int IdOfCategory { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

       
    }
}
