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
        public int Count = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// This is contructor
        /// </summary>
        public CustomQueue()
        {

        }
        
        #endregion

        #region Public methods
        /// <summary>
        /// Used for enqueuing int
        /// </summary>
        /// <param name="item">item to be inserted</param>
        public void Enqueue(int item)
        {
            if (Count<=10)
            {
                _array[Count] = item;
                Count++;
            }
        }
        /// <summary>
        /// Used for dequeuing item
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            int ret = _array[0];
            for (int i = 1; i < Count-1; i++)
            {
                _array[i - 1] = _array[i];
            }
            Count--;
            return ret;
        }
        #endregion

    }
}
