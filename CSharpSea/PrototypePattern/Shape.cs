using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Shape : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }

        private string id;
        protected string type;

        public abstract void draw();

        public string getType() { return type; }

        public string getId() { return id; }

        public void setId(string id)
        {
            this.id = id;
        }
            }
}
