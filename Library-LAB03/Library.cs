using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Library : IPositionsManagement
    {
        private List<Catalog> catalogs = new List<Catalog>();
        private List<Librarian> librarians = new List<Librarian>();

        private string mAddress;
        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }
        public Library()
        {

        }
        public Library(string mAddress_)
        {
            Address = mAddress_;
        }

        public void AddTheLibrarian(Librarian librarian)
        {
            librarians.Add(librarian);
        }
        public void WriteOutAllLibrarians()
        {
            Console.WriteLine("The librarians:\n");
            foreach (var item in librarians)
            {
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Last Name: {item.LastName}");
                Console.WriteLine($"Date of employment: {item.DateOfEmployment}");
                Console.WriteLine($"Payment: {item.Payment}");
            }
        }
        public void AddTheCatalog(Catalog catalog)
        {
            catalogs.Add(catalog);
        }
        public void AddThePosition(Position p, string thematicDepartment)
        {
            var cat = catalogs.First(x => x.ThematicDepartment == thematicDepartment);
            if (cat != null)
            {
                cat.AddThePosition(p);
            }
        }

        public void WriteOutAllPositions()
        {
            foreach (var item in catalogs)
            {
                Console.WriteLine($"Thematic department: {item.ThematicDepartment}");
                item.WriteOutAllPositions();
            }
        }

        public void FindPositionByID(int id)
        {
            Console.WriteLine("\nPosition by ID:\n");
            foreach (var catalog in catalogs)
            {
                var query = catalog.positions.FirstOrDefault(x => x.ID == id);
                if (query != null)
                {
                    query.WriteOutInfo();
                    break;
                }
            }
        }

        public void FindPositionByTitle(string title)
        {
            Console.WriteLine("\nPosition by Title:\n");
            foreach (var catalog in catalogs)
            {
                var query = catalog.positions.FirstOrDefault(x => x.Title == title);
                if (query != null)
                {
                    query.WriteOutInfo();
                    break;
                }
            }
        }

    }
}
