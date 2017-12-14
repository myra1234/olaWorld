using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class MyClass
    {
        public string DisplayString { get; set; }

        #region "Properties to be used in future when the data comes from Database"
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime Modified { get; set; }
        public bool isDeleted { get; set; }
        #endregion
    }
}