using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BT5_Composite
{
    public class File : Item
    {
        public File(string Name)
        {
            this.Name = Name;
        }
        public override void searchItemByName(string Name, List<Item> list)
        {
            if (this.Name == Name)
                list.Add(this);
        }
    }
}