using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI32.Collections
{
    public abstract class SCI32Collection<T> : System.Collections.CollectionBase, IDisposable
    {
        /// <summary>
        /// Gets the object disposed state.
        /// </summary>
        public bool IsDisposed { get; private set; }
        
        /// <summary>
        /// Adds a item to this collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Add(T value)
        {
            if (!this.List.Contains(value))
            {
                lock (this.List)
                {
                    this.List.Add(value);
                }
            }
            return this.List.Contains(value);
        }
        /// <summary>
        /// Removes a item from this collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Remove(T value)
        {
            if (this.List.Contains(value))
            {
                lock (this.List)
                {
                    this.List.Remove(value);
                }
            }
            return this.List.Contains(value) ? false:true;
        }

        /// <summary>
        /// Gets item at position index
        /// </summary>
        /// <param name="index">the index</param>
        /// <returns>the object located</returns>
        public T this[int index]
        {
            get
            {
                return (T)this.List[index];
            }
        }
        /// <summary>
        /// Returns true if the value is in the list already.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(T value)
        {
            bool found = false;
            foreach (T item in List)
                if (item.Equals(value)) { found = true; }
            return found;
        }
        /// <summary>
        /// Disposes this object
        /// </summary>
        public void Dispose()
        {
            // Lock and clear our list
            this.IsDisposed = true;
        }
    }
}
