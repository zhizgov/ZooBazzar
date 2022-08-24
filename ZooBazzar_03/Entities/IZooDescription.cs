using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IZooDescription<ZooDescription>
    {
        void AddDescription(ZooDescription zd);

        void DisablePreviousDescription(ZooDescription zd);

        void GetDescriptions(List<ZooDescription> descriptions);
        void DeleteDescriptions(List<ZooDescription> descriptions);

    }
}
