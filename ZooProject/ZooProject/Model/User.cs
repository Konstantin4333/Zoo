using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZooProject.Model
{
    class User
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
