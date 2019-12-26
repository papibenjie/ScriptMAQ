using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptMAQ
{

    class GameObject
    {
        public List<Component> Components { get; set; } = new List<Component>();
        public string Name { get; set; } = "GameObject";

        public T GetComponent<T>() where T : Component
        {
            return Components.Where(c => c is T).Cast<T>().FirstOrDefault();
        }

        public override string ToString()
        {
            string desc = Name + "\n";
            foreach (var com in Components)
            {
                desc += com.ToString();
                desc += "---------------------------------------------\n";
            }
            return desc;
        }
    }
}
