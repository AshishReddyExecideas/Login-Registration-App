using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL1
{


    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public bool HasChanges { get; set; }
        public bool isNew { get; private set; } 
        public string ProductName { get; set; }
        public bool IsValid
        {
            get { return true; }
        }
    }
}
