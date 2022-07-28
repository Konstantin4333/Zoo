﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooProject.Model
{
    class Animals
    {
        [Key]
        public int IdAnimal { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //
        [ForeignKey("CategoryOfAnimal")]
        public int AnimalCategoryID { get; set; }
      //  public CategoryOfAnimal CategoryOfAnimal { get; set; }

    }
}
