using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Nodes
    {
        public User Data { get; set; }
        public Nodes Next { get; set; }

        public Nodes()
        {
            this.Data = null;
            this.Next = null;
        }

        public Nodes(User data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Nodes(int id, string name, string email, string password)
        {
            User newUser = new User(id, name, email, password);

            this.Data = newUser;
            this.Next = null;
        }
    }
}
