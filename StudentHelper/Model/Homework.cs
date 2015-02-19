using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model {
    class Homework : Plan {
        public string Class { get; set; }
        public Homework(string Class, string id, string description, string userid, DateTime datetime) {
            this.ID = id;
            this.Class = Class;
            this.Description = description;
            this.UserId = userid;
            this.DateTime = datetime;
        }
    }
}
