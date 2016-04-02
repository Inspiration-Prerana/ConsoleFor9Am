using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Computer
{
    /// <summary>
    /// This class is for the custom queue
    /// </summary>
    public class CustomQueue
    {
        #region Members
        private int[] _array = new int[10];
        private int _count = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// This is contructor
        /// </summary>
        public CustomQueue()
        {

        }
        /// <summary>
        /// Constructor with dynamic array size
        /// </summary>
        /// <param name="i">number of elements in an array</param>
        public CustomQueue(int i)
        {
            this._array = new int[i];
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Used for enqueuing int
        /// </summary>
        /// <param name="item">item to be inserted</param>
        public void Enqueue(int item)
        {
            if (_count<=_array.Length)
            {
                _array[_count] = item;
                _count++;
            }
        }
        /// <summary>
        /// Used for dequeuing item
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            int ret = _array[0];
            for (int i = 1; i <= _count-1; i++)
            {
                _array[i - 1] = _array[i];
            }
            _count--;
            return ret;
        }

        public int[] GetItems()
        {
            var tmp = new int[_count];
            for (int i = 0; i < _count; i++)
            {
                tmp[i] = _array[i];
            }
            return tmp;
        }

        public int Count()
        {
            return _count;
        }
        #endregion

    }
}
