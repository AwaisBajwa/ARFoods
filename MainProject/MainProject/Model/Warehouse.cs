using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARFoods.Model
{
    public class Warehouse
    {
        #region Attributes

        private int w_Id;
        private String w_Name;
        private String w_Location;
        private string w_Description;

        #endregion

        #region Properties

        public int WarehouseID
        {
            get { return w_Id; }
            set { w_Id = value; }
        }

        public string WarehouseName
        {
            get { return w_Name; }
            set { w_Name = value; }

        }

        public string WarehouseLocation
        {
            get { return w_Location; }
            set { w_Location = value; }

        }

        public string WarehouseDescription
        {
            get { return w_Description; }
            set { w_Description = value; }
        }

        #endregion

    }
}
