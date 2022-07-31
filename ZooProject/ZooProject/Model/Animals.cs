using System;
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
        public byte[] AnimalImage { get; set; }
        //
        [ForeignKey("CategoryOfAnimal")]
        public int AnimalCategoryID { get; set; }
        public virtual CategoryOfAnimal CategoryOfAnimal { get; set; }


        public Animals()
        {

        }
        public Animals(string name, string description, byte[] picture,int category)
        {

            Name = name;
            Description = description;
            AnimalImage = picture;
            AnimalCategoryID = category;

        }



    }

}
