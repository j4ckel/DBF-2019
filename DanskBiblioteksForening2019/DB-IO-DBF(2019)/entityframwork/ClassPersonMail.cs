using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassPersonMail
    {
        
        public int Id { get; set; }
        public string mails { get; set; }        
        public virtual ClassPerson personId { get; set; }
    }
}
