using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Computer
{
    public class CustomQueueTemplates<T>
    {
        private List<object> _list { get; set; }

        public void Enqueue(T item)
        {
            _list.Add(item);
        }
    }
}
