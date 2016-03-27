using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT5_Composite
{
    public abstract class Item
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public abstract void searchItemByName(string Name, List<Item> list);
    }
}