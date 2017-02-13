using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectModelLib.GeneratedCode
{
    class MenuItem
    {
        protected string _menuListing;
        public string menuListing
        {
            get { return this._menuListing; }
        }
        protected Func<bool> _action;
        public Func<bool> action
        {
            get { return this._action; }
        }
        public MenuItem(string initMenuListing, Func<bool> initAction)
        {
            this._menuListing = initMenuListing;
            this._action = initAction;
        }// constructor
        public override string ToString()
        {
            return this._menuListing;
        }
    }
}
