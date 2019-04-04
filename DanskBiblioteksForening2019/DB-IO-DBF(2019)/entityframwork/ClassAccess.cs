using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassAccess
    {
        [Key]
        public int Id { get; set; }
        public virtual ClassPerson personID { get; set; }
        public int userid { get; set; }
        public string cprnr { get; set; }
        public string password { get; set; }
    }
}
