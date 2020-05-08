using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BusinessLayer
{
    public abstract class EntityBase
    {
        public bool IsValid => Validate();

        public abstract bool Validate();

        public bool IsNew { get; set; }

    }
}
