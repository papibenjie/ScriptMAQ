using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMAQ
{
    abstract class Component
    {
        public string Name { get; set; } = "Component";

        public override string ToString()
        {
            return Name + "\n" + Description();
        }

        public abstract string Description();
    }
}
