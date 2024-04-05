using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Node
    {
        public User Data { get; set; }
        public Node Next { get; set; }

        public Node()
        {
            this.Data = null;
            this.Next = null;
        }

        public Node(User data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Node(int id, string name, string email, string password)
        {
            User newUser = new User(id, name, email, password);

            this.Data = newUser;
            this.Next = null;
        }
    }
}
