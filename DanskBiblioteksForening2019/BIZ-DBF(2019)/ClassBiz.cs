using DB_IO_DBF_2019_;
using REPO_DBF_2019_;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ_DBF_2019_
{
    public class ClassBiz : ClassNotify
    {
        // Private fields
        private List<ClassBog> _boeger;
        private List<ClassBog> _laanteBoeger;
        private ClassBog _bog;
        private ClassPerson _person;
        ClassDbfDB classDbfDB;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClassBiz()
        {
            classDbfDB = new ClassDbfDB();
            bog = new ClassBog();
            person = new ClassPerson();
            laanteBoeger = GetAllLentBoks(person.id);
        }


        // Public properties
        public ClassPerson person
        {
            get { return _person; }
            set
            {
                if (value != _person)
                {
                    _person = value;
                    Notify("person");
                }
            }
        }

        public ClassBog bog
        {
            get { return _bog; }
            set
            {
                if (value != _bog)
                {
                    _bog = value;
                    Notify("bog");
                }
            }
        }

        public List<ClassBog> laanteBoeger
        {
            get { return _laanteBoeger; }
            set
            {
                if (value != _laanteBoeger)
                {
                    _laanteBoeger = value;
                    Notify("laanteBoeger");
                }
            }
        }

        public List<ClassBog> boeger
        {
            get { return _boeger; }
            set
            {
                if (value != _boeger)
                {
                    _boeger = value;
                    Notify("boeger");
                }
            }
        }

        public List<ClassBog> GetAllLentBoks(int personID)
        {
            return classDbfDB.GetAllLentToUser(personID.ToString());
        }

        public List<ClassBog> GetAllBooksWhereTheTitleContainsTheseWords(string words)
        {
            return classDbfDB.GetAllBooksLike(words);
        }

        public void LendThisBookToTheUser(int bogID, int personID)
        {
            
        }

        public void SubmitThisBookToTheLibrary(int bogID, int personID)
        {

        }
    }
}
