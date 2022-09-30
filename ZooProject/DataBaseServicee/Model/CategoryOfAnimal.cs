using System.ComponentModel.DataAnnotations;

namespace DataBaseServicee.Model
{
    internal class CategoryOfAnimal
    {
        [Key]
        public int IdOfCategory { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
