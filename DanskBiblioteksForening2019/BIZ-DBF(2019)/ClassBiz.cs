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
        private ObservableCollection<ClassBog> _boeger;
        private ObservableCollection<ClassBog> _laanteBoeger;
        private ClassBog _bog;
        private ClassUser _user;
        private ClassLogin _login;
        ClassDbfDB classDbfDB;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClassBiz()
        {
            classDbfDB = new ClassDbfDB();
            bog = new ClassBog();
            user = new ClassUser();
        }


        // Public properties
        #region properties
        public ClassLogin login
        {
            get { return _login; }
            set
            {
                if (value != _login)
                {
                    _login = value;
                    Notify("login");
                }
            }
        }
        public ClassUser user
        {
            get { return _user; }
            set
            {
                if (value != _user)
                {
                    _user = value;
                    Notify("user");
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

        public ObservableCollection<ClassBog> laanteBoeger
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

        public ObservableCollection<ClassBog> boeger
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
        #endregion
        public ObservableCollection<ClassBog> GetAllLentBooks(int personID)
        {
            return classDbfDB.GetAllLentToUser(personID.ToString());
        }

        public ObservableCollection<ClassBog> GetAllBooksWhereTheTitleContainsTheseWords(string words)
        {
            return classDbfDB.GetAllBooksLike(words);
        }

        public void LendThisBookToTheUser(ClassBog lentBook, ClassUser user)
        {
            
        }

        public void SubmitThisBookToTheLibrary(int bogID, int personID)
        {

        }

        public bool HandleLogin()
        {
            user = classDbfDB.GetUser(user);
            if (user.id > 0)
            {
                laanteBoeger = GetAllLentBooks(user.id);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
