using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassUdlaan
    {       
        public int Id { get; set; }
        public virtual ClassBooks BookId { get; set; }
        public virtual ClassPerson personId { get; set; }
        public DateTime udlaansdato { get; set; }        
        public virtual ClassUdlaansStatus udlaansStatus { get; set; }
    }
}
