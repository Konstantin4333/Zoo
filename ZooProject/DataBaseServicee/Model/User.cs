

using System.ComponentModel.DataAnnotations;

namespace DataBaseServicee.Model
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int IdUser { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
