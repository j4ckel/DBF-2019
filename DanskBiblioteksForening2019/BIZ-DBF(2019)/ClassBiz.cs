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
        private ObservableCollection<ClassTitle> _bookTitles;
        private ObservableCollection<ClassAuthor> _bookAuthors;
        private ObservableCollection<ClassPublisher> _bookPublishers;
        private ObservableCollection<ClassGenre> _bookGenre;
        private ObservableCollection<ClassType> _bookTypes;
        private ObservableCollection<decimal> _bookPrices;
        private ClassBog _bog;
        private ClassUser _user;
        ClassDbfDB classDbfDB;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ClassBiz()
        {
            classDbfDB = new ClassDbfDB();
            bog = new ClassBog();
            user = new ClassUser();

            boeger = classDbfDB.GetAllBooks();
            

        }


        // Public properties
        #region properties
        public ObservableCollection<decimal> bookPrices
        {
            get { return _bookPrices; }
            set
            {
                if (value != _bookPrices)
                {
                    _bookPrices = value;
                    Notify("bookPrices");
                }
            }
        }

        public ObservableCollection<ClassType> bookTypes
        {
            get { return _bookTypes; }
            set
            {
                if (value != _bookTypes)
                {
                    _bookTypes = value;
                    Notify("bookTypes");
                }
            }
        }

        public ObservableCollection<ClassGenre> bookGenre
        {
            get { return _bookGenre; }
            set
            {
                if (value != _bookGenre)
                {
                    _bookGenre = value;
                    Notify("bookGenre");
                }
            }
        }

        public ObservableCollection<ClassPublisher> bookPublishers
        {
            get { return _bookPublishers; }
            set
            {
                if (value != _bookPublishers)
                {
                    _bookPublishers = value;
                    Notify("bookPublishers");
                }
            }
        }

        public ObservableCollection<ClassAuthor> bookAuthors
        {
            get { return _bookAuthors; }
            set
            {
                if (value != _bookAuthors)
                {
                    _bookAuthors = value;
                    Notify("bookAuthors");
                }
            }
        }

        public ObservableCollection<ClassTitle> bookTitles
        {
            get { return _bookTitles; }
            set
            {
                if (value != _bookTitles)
                {
                    _bookTitles = value;
                    Notify("bookTitles");
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

        public void GetBooksFromDB()
        {
            boeger = classDbfDB.GetAllBooks();
            MakeCollectionsForComboBoxes();
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
        public void addbook(ClassBog bog)
        {
           
           
           

        }
        public bool HandleLogin()
        {
            user = classDbfDB.GetUser(user.userName, user.password);
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

        public void MakeCollectionsForComboBoxes()
        {
            bookTitles = classDbfDB.GetTitles();
            bookAuthors = classDbfDB.GetAuthors();
            bookPublishers = classDbfDB.GetPublishers();
            bookTypes = classDbfDB.GetTypes();
            bookGenre = classDbfDB.GetGenre();
            bookPrices = classDbfDB.GetPrices();
        }
    }
}
