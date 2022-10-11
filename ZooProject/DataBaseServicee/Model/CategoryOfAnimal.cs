using System.ComponentModel.DataAnnotations;

namespace DataBaseServicee.Model
{
    public class CategoryOfAnimal
    {
        [Key]
        public int IdOfCategory { get; set; }
        public string Name { get; set; }
        public int IsDeleted { get; set; }

        public CategoryOfAnimal(int idOfCategory, int isDeleted)
        {
            IdOfCategory = idOfCategory;
        
            IsDeleted = isDeleted;
        }
        public CategoryOfAnimal()
        {

        }
    }
}
