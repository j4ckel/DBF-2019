using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassPersontelefon
    {        
        public int Id { get; set; }
        public string telefonnummer { get; set; }        
        public virtual ClassPerson personId { get; set; }
    }
}
