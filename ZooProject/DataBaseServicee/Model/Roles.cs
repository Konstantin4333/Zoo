using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseServicee.Model
{
    public class Roles
    {
        public string Administrator { get; set; }
        public string Member { get; set; }
       public enum Role
        {
            Administrator,
            User
        }
    }
}
