using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Complaint
    {
        private int id;
        private Account author;
        private string title;
        private string description;
        private DateTime time;

        
        public int ID { get { return id; } }
        public Account Author { get { return author; } }
        public string Title { get { return title; } }
        public string Description { get { return description; } }
        public DateTime Time { get { return time; } }

        public Complaint(int id, Account author, string title, string description, DateTime time)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.description = description;
            this.time = time;
        }
        public Complaint(Account author, string title, string description, DateTime time)
        {
            this.author = author;
            this.title = title;
            this.description = description;
            this.time = time;
        }

        public override string ToString()
        {
            return $"Complaint {this.id} by {this.author.Username}";
        }

    }
}
