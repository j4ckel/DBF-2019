using REPO_DBF_2019_;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassBooks
    {
        [Key]
        public int BookId { get; set; }
        //public int titelID { get; set; }
        public virtual Classtitel titelid { get; set; }
        //public int isbnid { get; set; }
        public virtual ClassISBNnr ISBNid { get; set; }
        //public int forfatterid { get; set; }
        public virtual ClassForfatter Forfatterid { get; set; }
        //public int genreid { get; set; }
        public virtual ClassGenre Genreid { get; set; }
        //public int typeid { get; set; }
        public virtual ClassType Typeid { get; set; }
        //public int forlagid { get; set; }
        public virtual ClassForlag Forlagid { get; set; }
        public decimal pris { get; set; }
    }
}
