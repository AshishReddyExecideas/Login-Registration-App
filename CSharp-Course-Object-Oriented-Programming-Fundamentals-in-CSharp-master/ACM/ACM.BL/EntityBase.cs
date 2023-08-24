using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{

    public enum entityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public entityStateOption entityState { get; set; }
       
        public bool isNew { get; private set; }
        public bool hasChanges { get; set; }

        public bool isValid => Validate();

        public abstract bool Validate();
        
        
    }
}
