using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT5_Composite
{
    public class Folder : Item
    {
        private List<Item> _item;
        
        public Folder(string Name)
        {
            this.Name = Name;
        }

        public List<Item> getItem()
        {
            return _item;            
        }

        public void addItem(Item Item)
        {
            _item.Add(Item);
        }

        public bool removeItem(int index)
        {
            if (index>0 && index<_item.Count)
            {
                _item.Remove(_item[index]);
                return true;
            }
            return false;
        }

        public override void searchItemByName(string Name, List<Item> list)
        {            
            if (this.Name == Name)
                list.Add(this);
            for (int i=0; i<_item.Count; i++)
            {
                _item[i].searchItemByName(Name, list);
            }
        }
    }
}