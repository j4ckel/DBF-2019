using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassPerson
    {   
        public int personId { get; set; }
        public string navn { get; set; }
        public string adresse { get; set; }

        public virtual ClassBrugerRolle roller { get; set; }
    }
}
