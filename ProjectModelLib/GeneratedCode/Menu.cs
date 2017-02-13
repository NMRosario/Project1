using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModelLib.GeneratedCode
{
    class Menu
    {
        protected Dictionary<ConsoleKey, MenuItem> _items;
        public MenuItem this[ConsoleKey c]
        {
            get { return this._items[c]; }
            set { this._items[c] = value; }
        }
        public Menu()
        {
            this._items = new Dictionary<ConsoleKey, MenuItem>();
        }
        public override string ToString()
        {
            string returnVal = "";
            foreach (ConsoleKey k in this._items.Keys)
            {
                returnVal += "(" + k.ToString() + ") " + this._items[k].ToString() + "\n";
            }
            return returnVal;
        }
        public bool Contains(ConsoleKey k)
        {
            return this._items.Keys.Contains(k);
        }
        public bool Action(ConsoleKey k)
        {
            if (this.Contains(k))
                return this[k].action();
            else return false;
        }// Action
        public void Remove(ConsoleKey k)
        {
            if (this.Contains(k))
                this._items.Remove(k);
        }
    }
}
