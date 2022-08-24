using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class TypeSubscription
    {
        public static List<TypeSubscription> GetTypesSubscription { get { return GetChildClasses(); } }
        public abstract decimal GetPrice();
        public abstract DateTime CalculateEndDate(DateTime startDate);
        public abstract override string ToString();

        private static List<TypeSubscription> GetChildClasses()
        {
            List<TypeSubscription> objects = new List<TypeSubscription>();
            foreach (Type type in
            Assembly.GetAssembly(typeof(TypeSubscription)).GetTypes()
            .Where(myType => myType.IsClass && myType.IsSubclassOf(typeof(TypeSubscription))))
            {
                objects.Add((TypeSubscription)Activator.CreateInstance(type));

            }
            return objects;
        }
        

        
    }
}
