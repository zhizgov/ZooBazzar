using DataAccessLayer;
using Entities;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazzar_Group03.Forms
{
    public partial class Tickets : Form
    {
        private TicketManager tm = new TicketManager(new TicketsDB(), new TicketsDB());
        public Tickets()
        {
            InitializeComponent();
            this.cmbTypeTicket.DataSource = Enum.GetValues(typeof(TypeOfTicket));

        }

        private void btnSaleTicket_Click(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(TypeOfTicket), this.cmbTypeTicket.Text) && this.nudQuantity.Value > 0)
            {
                int quantity = Convert.ToInt32(this.nudQuantity.Value);
                TypeOfTicket type = (TypeOfTicket)Enum.Parse(typeof(TypeOfTicket), this.cmbTypeTicket.Text);
                for (int i = 0; i < quantity; i++)
                {
                    tm.AddTicket(new Ticket(null, type, null, PlaceOfPerchase.zoo, calculatePrice(type)));
                }
                MessageBox.Show($"Succsessfuly bought {quantity} {type} tickets!");
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private decimal calculatePrice(TypeOfTicket type)
        {
            if (type == TypeOfTicket.adult)
            {
                return 8.0m;
            }
            else if (type == TypeOfTicket.child)
            {
                return 6.5m;
            }

            return 0;
        }
    }
}
