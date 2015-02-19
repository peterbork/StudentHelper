using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model {
    class Event : Plan {
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public Event(string type, string location, DateTime startdate, string id, string description, string userid, DateTime datetime) {
            this.Type = type;
            this.Location = location;
            this.StartDate = startdate;
            this.ID = id;
            this.Description = description;
            this.UserId = userid;
            this.DateTime = datetime;
        }
    }
}
