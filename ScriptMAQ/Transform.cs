using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMAQ
{
    class Transform : Component
    {
        public Vector3 Position { get; set; } = new Vector3();
        public Vector3 Rotation { get; set; } = new Vector3();
        public Vector3 Scale { get; set; } = new Vector3();

        public override string Description()
        {
            string desc = "";
            desc += "Position: " + Position.ToString() + "\n";
            desc += "Rotation: " + Rotation.ToString() + "\n";
            desc += "Scale: " + Scale.ToString() + "\n";
            return desc;
        }
    }
}
