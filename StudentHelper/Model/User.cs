using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model {
    class User {
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public User(string id, string username, string password, string name) {
            this.ID = id;
            this.Username = username;
            this.Password = password;
            this.Name = name;
        }

        public User(string id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
