using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ZooDescription
    {
        private int id;
        private string description;
        private bool isActive;
        private DateTime dateOfCreation;

        public int Id { get { return this.id; } }
        public string Description
        {
            get { return this.description; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Description cannot be empty");
                }
                this.description = value;
            }
        }
        public bool IsActive { get { return this.isActive; } }
        public DateTime DateOfCreation
        {
            get { return this.dateOfCreation; }
            private set
            {
                if (value != DateTime.Today)
                {
                    throw new Exception("This should not be happening");
                }
                dateOfCreation = value;
            }
        }


        public ZooDescription(int id, string description, bool isActive, DateTime dateOfCreation)
        {
            this.id = id;
            this.Description = description;
            this.isActive = isActive;
            this.dateOfCreation = dateOfCreation;
        }

        public ZooDescription(string description, bool isActive, DateTime dateOfCreation)
        {
            this.description = description;
            this.isActive = isActive;
            this.DateOfCreation = dateOfCreation;
        }
        public void UpdateStatus(bool isActive)
        {
            this.isActive = isActive;
        }
        public override string ToString()
        {
            return DateOfCreation.ToShortDateString();
        }
    }
}
