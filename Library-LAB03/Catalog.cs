using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Catalog : IPositionsManagement
    {
        public List<Position> positions = new List<Position>();
        private string mThematicDepartment;
        public string ThematicDepartment
        {
            get { return mThematicDepartment; }
            set { mThematicDepartment = value; }
        }
        public Catalog()
        {

        }
        public Catalog(string mThematicDepartment_)
        {
            mThematicDepartment = mThematicDepartment_;
        }
        public void AddThePosition(Position position)
        {
            positions.Add(position);
        }
        public void WriteOutAllPositions()
        {
            int i = 1;
            Console.WriteLine("\nBooks and magazines:");
            foreach (var item in positions)
            {
                Console.WriteLine($"Position {i}:");
                item.WriteOutInfo();
                Console.WriteLine("--------------------");
                i++;
            }
        }
        public List<Position> FindPosition(string title, string id, string publishingHouse, string publicationDate)
        {
            Console.WriteLine("\nSearched item:\n");
            var query = positions.Where(x => x.Title == title || x.ID.ToString() == id.ToString() || 
            x.PublishingHouse == publishingHouse || x.PublicationDate.ToString() == publicationDate.ToString()).ToList();
            if (query.Count() > 0)
            {
                foreach (var item in query)
                {
                    item.WriteOutInfo();
                }
                return query;
            }
            return null;
        }

        public void FindPositionByID(int id)
        {
            Console.WriteLine("Position by ID:");
            var query = positions.First(x => x.ID == id);
            if (query != null)
            {
                query.WriteOutInfo();
            }
            else
            {
                Console.WriteLine("No proper ID!");
            }
        }

        public void FindPositionByTitle(string title)
        {
            Console.WriteLine("Position by title:");
            var query = positions.First(x => x.Title == title);
            if (query != null)
            {
                query.WriteOutInfo();
            }
            else
            {
                Console.WriteLine("No proper title!");
            }

        }
    }
}
