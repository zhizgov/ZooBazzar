using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public interface ICRU<T>
    {
        public void Add(T obj);
        public List<T> Read();
        public void Update(T obj);


    }
}
