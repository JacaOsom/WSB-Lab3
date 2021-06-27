using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Book : Position
    {
        public List<Author> authors = new List<Author>();
        private int mNumberOfPages;
        public int NumberOfPages
        {
            get { return mNumberOfPages; }
            set { mNumberOfPages = value; }
        }
        public Book()
        {

        }
        public Book(string mTitle_, int mID_, string mPublishingHouse_, int mPublicationDate_, int mNumberOfPages_, Author author)
        {
            mTitle = mTitle_;
            mID = mID_;
            mPublishingHouse = mPublishingHouse_;
            mPublicationDate = mPublicationDate_;
            mNumberOfPages = mNumberOfPages_;
            AddTheAuthor(author);
        }

        public void AddTheAuthor(Author author)
        {
            authors.Add(author);
        }
        public override void WriteOutInfo()
        {
            foreach (var item in authors)
            {

                Console.WriteLine($"Title: {mTitle}");
                Console.WriteLine($"ID: {mID}");
                Console.WriteLine($"Publishing house: {mPublishingHouse}");
                Console.WriteLine($"Publication Date: {mPublicationDate}");
                Console.WriteLine($"Number of pages: {mNumberOfPages}");
                Console.WriteLine($"Author: {item.Name} {item.LastName} Nationality: {item.Nationality}");
            }

        }
    }
}
