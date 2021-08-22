using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Fax.Common
{
    public class MailList
    {
        private ArrayList al = new ArrayList();

        public MailList() { }

        public object GetItem(int index)
        {
            try
            {
                return al[index];
            }
            catch
            {
                return null;
            }
        }

        public void SetItem(object Item)
        {
            al.Add(Item);
        }

        public void SetItem(object Item,int index)
        {
            al[index] = Item;
        }

        public int Count
        {
            get{ return al.Count;}
        }

        public void Clear()
        {
            al.Clear();
        }

        public void RemoveItem(object item)
        {
            al.Remove(item);
        }
    }
}