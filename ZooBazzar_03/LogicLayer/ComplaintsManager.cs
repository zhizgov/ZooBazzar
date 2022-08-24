using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace LogicLayer
{
    public class ComplaintsManager
    {
        private List<Complaint> complaints;
        private IComplaints<Complaint> complaintsDB;

        public List<Complaint> Complaints { get { return complaints; } }

        public ComplaintsManager(IComplaints<Complaint> complaintsDB)
        {
            this.complaintsDB = complaintsDB;
            this.complaints = complaintsDB.ReadComplaints();
        }

        public void AddComplaint(Complaint complaint)
        {
            complaintsDB.AddComplaint(complaint);
        }

        public void GetComplaints()
        {
            if (complaints!=null)
            {
                complaints.Clear();
            }

            complaints = complaintsDB.ReadComplaints();
        }

    }
}
