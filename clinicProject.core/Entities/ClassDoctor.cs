using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicProject.core.Entities
{
    public class ClassDoctor
    {
        public int id { get; set; }
        public string name { get; set; }
        public long phone { get; set; }
        public string email { get; set; }
        public int businesshours { get; set; }
    }
}
