using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    public class Action
    {
        private string id;
        private string name;
        private string description;

        #region Properties
        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ActionName
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

    }
}
