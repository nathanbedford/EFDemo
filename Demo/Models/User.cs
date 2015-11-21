using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public virtual List<Role> Roles { get; set; }

        public User()
        {
            Roles = new List<Role>();
        }
    }
}
