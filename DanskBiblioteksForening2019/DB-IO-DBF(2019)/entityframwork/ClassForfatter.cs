using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassForfatter
    {
        [Key]
        public int ForfatterId { get; set; }
        public string Forfatternavne { get; set; }
    }
}
