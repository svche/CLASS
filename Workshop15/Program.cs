using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop15
{
    class Program
    {

        class Book
        {
            protected string _author;
            protected string _name;
            protected int _pages;

            public void printAll()
            {
                Console.Write("{0},  {1},  {2}. ", _author, _name, _pages);
            }

            public string author
            {
                get { return _author; }
                set { _author = value; }
            }
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            public int pages
            {
                get { return _pages; }
                set
                {
                    if (value > 0) { _pages = value + 2; };
                }
            }

            public Book()
            {
                _author = "unknown";
                _name = "unknown";
                _pages = 0;
            }
            public Book(string author)
            {
                _author = author;
            }
            public Book(string author, string name)
            {
                _author = author;
                _name = name;
            }
            public Book(string author, string name, int pages)
            {
                _author = author;
                _name = name;
                _pages = pages;
            }
        }

        class Technical_Book : Book
        {
            private string _fieldOfScience;

            public void printAll()
            {
                Console.Write("{0},  {1},  {2},  {3}. ", _author, _name, _pages, _fieldOfScience);
            }

            public string fieldOfScience
            {
                get { return _fieldOfScience; }
                set { _fieldOfScience = value; }
            }

            public Technical_Book() : base()
            {
                _fieldOfScience = "unknown";
            }

            public Technical_Book(string fieldOfScience) : base()
            {
                _fieldOfScience = fieldOfScience; 
            }

            public Technical_Book(string fieldOfScience, string author, string name) : base(author, name)
            {
                _fieldOfScience = fieldOfScience;
            }
            public Technical_Book(string author, string name, int pages, string fieldOfScience) : base (author, name, pages)
            {
                _fieldOfScience = fieldOfScience;
            }

        }

        class Fuction_Book : Book
        {
            private string _fieldOfLiterature;
            public void printAll()
            {
                Console.Write("{0},  {1},  {2},  {3}. ", _author, _name, _pages, _fieldOfLiterature);
            }
            public string fieldOfLiterature
            {
                get { return _fieldOfLiterature; }
                set { _fieldOfLiterature = value; }
            }

            public Fuction_Book() : base ()
            {
                _fieldOfLiterature = "unknown";
            }
            public Fuction_Book(string fieldOfLiterature) : base()
            {
                _fieldOfLiterature = fieldOfLiterature;
            }
            public Fuction_Book(string fieldOfLiterature, string author, string name) : base(author, name)
            {
                _fieldOfLiterature = fieldOfLiterature;
            }
            public Fuction_Book(string author, string name, int pages, string fieldOfLiterature) : base (author, name, pages)
            {
                _fieldOfLiterature = fieldOfLiterature;
            }
        }

        class Library 
        {
            public static List<Book> bookList = new List<Book>();

            public void addBook(Book b)
            {
                bookList.Add(b);
            }

            public void printBookList()
            {
                foreach (Book b in bookList) Console.Write(b.author + ", " + b.name + ", " + b.pages + "\n");
            }

            public void printFuctioBook()
            {
                foreach(Book b in bookList)
                {
                    if (b.GetType().Name.Equals("Fuction_Book"))
                    {
                        Console.Write(b.author + ", " + b.name + ", " + b.pages + "\n");
                    }
                }
            }

            public void printTechnicalBook()
            {
                foreach (Book b in bookList)
                {
                    if (b.GetType().Name.Equals("Technical_Book"))
                    {
                        Console.Write(b.author + ", " + b.name + ", " + b.pages + "\n");
                    }
                }
            }

            public void sortAuthor()
            {
                bookList.Sort((b1, b2) => b1.author.CompareTo(b2.author));
            }

        }

        static void Main(string[] args)
        {

            Fuction_Book fb = new Fuction_Book("Rend", "Atlas Shrugged", 800, " Philosofy Novel");
            fb.printAll();
            Console.WriteLine();

            Technical_Book tb = new Technical_Book("Shildt", "C#", 1000, "IT");
            tb.printAll();
            Console.WriteLine("\n");

            Library l1 = new Library();
            l1.addBook(fb);
            l1.addBook(tb);

            Console.WriteLine("All book:");
            l1.printBookList();

            Console.WriteLine("\nFuction Book:");
            l1.printFuctioBook();

            Console.WriteLine("\nTechnical Book:");
            l1.printTechnicalBook();
            Console.WriteLine("\n");
            l1.sortAuthor();
            l1.printBookList();



            //Console.WriteLine(tb1.GetType().Name);

            ///////////////////////////////////////////////////////////////////////////////////
            //List<int> myList = new List<int>();

            //myList.Add(5);
            //myList.Add(10);
            //myList.Add(15);

            //Console.WriteLine(myList.Count + "\n");

            //foreach(int i in myList) Console.WriteLine(i);
            //Console.WriteLine();

            //myList.Remove(10);
            //foreach (int i in myList) Console.WriteLine(i);
            //Console.WriteLine();

            //myList.RemoveAt(1);
            //foreach (int i in myList) Console.WriteLine(i);

            ////////////////////////////////////////////////////////
            //LinkedList<int> myLinkedlist = new LinkedList<int>();
            //myLinkedlist.AddFirst(1);
            //myLinkedlist.AddLast(2);
            //myLinkedlist.AddLast(3);

            //foreach (int i in myLinkedlist) Console.WriteLine(i);
            //Console.WriteLine();

            //myLinkedlist.RemoveFirst();
            //foreach (int i in myLinkedlist) Console.WriteLine(i);
            ///////////////////////////////////////////////////////////////////////////////////////////

            Console.ReadLine();
        }
    }
}
