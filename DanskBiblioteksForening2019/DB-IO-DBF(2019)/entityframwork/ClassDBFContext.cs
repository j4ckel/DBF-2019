using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class DBFContext : DbContext
    {
        public DBFContext() : base(@"data source=CV-BB-5772\SQLEXPRESS;initial catalog=DBF_DB;integrated security=True;")
        {
            Database.SetInitializer<DBFContext>(new CreateDatabaseIfNotExists<DBFContext>());
        }
        public DbSet<ClassPerson> person { get; set; }
        public DbSet<ClassPersonMail> personMails { get; set; }
        public DbSet<ClassPersontelefon> personTelefons { get; set; }
        public DbSet<ClassBrugerRolle> brugerRolles { get; set; }
        public DbSet<ClassUdlaan> udlaans { get; set; }
        public DbSet<ClassUdlaansStatus> udlaansStatuses { get; set; }
        public DbSet<ClassAccess> access { get; set; }
        public DbSet<ClassBooks> books { get; set; }
        public DbSet<Classtitel> titels { get; set; }
        public DbSet<ClassISBNnr> iSBNnrs { get; set; }
        public DbSet<ClassForfatter> forfatters { get; set; }
        public DbSet<Classgenre> genres { get; set; }
        public DbSet<Classtype> types { get; set; }
        public DbSet<ClassForlag> forlags { get; set; }

    }
}
