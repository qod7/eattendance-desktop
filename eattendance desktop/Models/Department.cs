using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eattendance_desktop.Models
{
    class Department
    {
        public int id;
        public string name;
        public int? pk;

        // TODO ENCAPSULTE THE FIELDS ABOVE

        // CONSTRUCTORS
        public Department(int id, string name) : this(id, name, null) { }

        public Department(int id, string name, int? pk)
        {
            this.id = id;
            this.name = name;
            this.pk = pk;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
