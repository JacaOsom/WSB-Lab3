using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Magazine : Position
    {
        private int mNumber;
        public int Number
        {
            get { return mNumber; }
            set { mNumber = value; }
        }
        public Magazine()
        {

        }
        public Magazine(string mTitle_, int mID_, string mPublishingHouse_, int mPublicationDate_, int mNumber_)
        {
            mTitle = mTitle_;
            mID = mID_;
            mPublishingHouse = mPublishingHouse_;
            mPublicationDate = mPublicationDate_;
            mNumber = mNumber_;
        }

        public override void WriteOutInfo()
        {
            Console.WriteLine($"Title: {mTitle}");
            Console.WriteLine($"ID: {mID}");
            Console.WriteLine($"Publishing house: {mPublishingHouse}");
            Console.WriteLine($"Publication Date: {mPublicationDate}");
            Console.WriteLine($"Number: {mNumber}");
        }
    }
}
