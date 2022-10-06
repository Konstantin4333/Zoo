
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseServicee.Model
{
    public class Animals
    {
        [Key]
        public int IdAnimal { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] AnimalImage { get; set; }
        public bool IsDeleted { get; set; }
        //

        [ForeignKey("CategoryOfAnimal")]
        public int AnimalCategoryID { get; set; }
        public virtual CategoryOfAnimal CategoryOfAnimal { get; set; }


        public Animals()
        {

        }
        public Animals(string name, string description, byte[] picture, int category)
        {

            Name = name;
            Description = description;
            AnimalImage = picture;
            AnimalCategoryID = category;

        }

        public Animals(int id, bool isDeleted)
        {
            IdAnimal = id;
            IsDeleted = isDeleted;
        }

        public Animals(bool isDeleted)
        {

            IsDeleted = isDeleted;
        }
    }
}
