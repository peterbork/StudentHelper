using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper.Model {
    class Event : Plan {
        private string p1;
        private string p2;
        private System.DateTime dateTime1;
        private int p3;
        private string p4;
        private System.DateTime dateTime2;
        private Homework homework;

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
