using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Computer
{
    class CutomQueueList
    {
        private List<int> _list=new List<int>();


        public void Enqueue(int i)
        {
            _list.Add(i);

        }

        public int Dequeue()
        {
            var res = _list[0];
            _list.RemoveAt(0);
            return res;
        }

        public List<int> GetItems()
        {
            return _list;
        }
    }
}
