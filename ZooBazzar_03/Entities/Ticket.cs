using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ticket
    {
        //Fields
        private int id;
        private Customer? customer;
        private TypeOfTicket typeOfTicket;
        private DateTime? date; //Date when the ticket is meant to be used
        private DateTime dateOfPurchase;
        private bool isUsed;
        private PlaceOfPerchase placeOfPerchase;
        private decimal price;
        private DateTime? dateOfUse; //Date when acctually is used

        public int Id { get { return id; } }
        public Customer Customer
        {
            get { return customer; }
            private set
            {
                if (value != null)
                {
                    customer = value;
                }
            }
        }
        public TypeOfTicket TypeOfTicket
        {
            get { return typeOfTicket; }
            private set
            {
                if (Enum.IsDefined(typeof(TypeOfTicket), value))
                {
                    typeOfTicket = value;
                }
            }
        }
        public DateTime? Date
        {
            get { return date; }
            private set
            {
                if (value >= DateTime.UtcNow)
                {
                    date = value;
                }
            }
        }

        public DateTime DateOfPurchase { get { return dateOfPurchase; } }
        public bool IsUsed { get { return isUsed; } }
        public DateTime? DateOfUse { get { return dateOfUse; } }
        public PlaceOfPerchase PlaceOfPerchase
        {
            get { return placeOfPerchase; }
            private set
            {
                if (Enum.IsDefined(typeof(PlaceOfPerchase), value))
                {
                    this.placeOfPerchase = value;
                }
            }
        }
        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        //Constructor
        public Ticket(Customer? customer, TypeOfTicket typeOfTicket, DateTime? date, PlaceOfPerchase placeOfPerchase, decimal price)
        {
            this.customer = customer;
            this.TypeOfTicket = typeOfTicket;
            this.Date = date;
            this.PlaceOfPerchase = placeOfPerchase;
            this.isUsed = false;
            this.dateOfPurchase = DateTime.UtcNow;

            if (date != null)
            {
                this.price = price - price / 5;
            }
            else
            {
                this.price = price;
            }
        }

        public Ticket(int id, Customer customer, TypeOfTicket typeOfTicket, DateTime? date, PlaceOfPerchase placeOfPerchase, decimal price)
        {
            this.id = id;
            this.customer = customer;
            this.TypeOfTicket = typeOfTicket;
            this.Date = date;
            this.PlaceOfPerchase = placeOfPerchase;
            this.isUsed = false;
            this.dateOfPurchase = DateTime.UtcNow;

            if (date != null)
            {
                this.price = price - price / 5;
            }
            else
            {
                this.price = price;
            }
        }
        public Ticket(int id, Customer customer, TypeOfTicket typeOfTicket, DateTime? date, DateTime dateOfPurchase, PlaceOfPerchase placeOfPerchase, decimal price, bool isUsed, DateTime? dateOfUse)
        {
            this.id = id;
            this.customer = customer;
            this.typeOfTicket = typeOfTicket;
            this.date = date;
            this.dateOfPurchase = dateOfPurchase;
            this.isUsed = false;
            this.dateOfPurchase = dateOfPurchase;
            this.placeOfPerchase = placeOfPerchase;
            this.price = price;
            this.isUsed = isUsed;
            this.dateOfUse = dateOfUse;
        }

        //Method
        public override string ToString()
        {
            if (Customer == null)
            {
                return $" {DateOfPurchase} ";
            }
            return $"{Customer.Email}: {DateOfPurchase} ";
        }

        public void UseTicket()
        {
            this.isUsed = true;
            this.dateOfUse = DateTime.UtcNow;

        }

    }
}
