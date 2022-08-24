using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class ZooDescriptionManager
    {
        private List<ZooDescription> descriptions = new List<ZooDescription>();
        IZooDescription<ZooDescription> db;
        IAutoIncrementable auto;
        public ZooDescriptionManager(IZooDescription<ZooDescription> db, IAutoIncrementable auto)
        {
            this.db = db;
            this.auto = auto;
            db.GetDescriptions(descriptions);
            CheckIfOverSixMonths();
        }


        public void AddDescription(ZooDescription zd)
        {
            if (descriptions.Find(x => x.Description == zd.Description) is null)
            {
                ZooDescription zdWithId = new ZooDescription(auto.GetNexID(), zd.Description, zd.IsActive, zd.DateOfCreation);
                db.AddDescription(zdWithId);
                descriptions.Add(zdWithId);
                return;
            }
            throw new Exception("There is already such a description!");
        }

        public void DisablePreviousDescription(ZooDescription zd)
        {
            if (descriptions.Find(x => x.Id == zd.Id) is null)
            {
                throw new Exception("There is no such description to delete!");
            }
            if (zd.IsActive == false)
            {
                throw new Exception("The description is already disabled!");
            }
            db.DisablePreviousDescription(zd);
            zd.UpdateStatus(false);
            int index = descriptions.FindIndex(x => x.Id == zd.Id);
            descriptions[index] = zd;
        }

        public void CheckIfOverSixMonths()
        {
            List<ZooDescription> inactiveDescriptions = descriptions.FindAll(x => x.DateOfCreation >= DateTime.Today.AddMonths(6));
            if (inactiveDescriptions.Count == 0)
            {
                return;
            }
            db.DeleteDescriptions(inactiveDescriptions);
        }

        public List<ZooDescription> GetDescriptions()
        {
            return descriptions;
        }
    }
}
