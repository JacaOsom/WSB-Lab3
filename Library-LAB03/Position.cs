using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public abstract class Position
    {
        protected string mTitle;
        protected int mID;
        protected string mPublishingHouse;
        protected int mPublicationDate;
        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }public int ID
        {
            get { return mID; }
            set { mID = value; }
        }public string PublishingHouse
        {
            get { return mPublishingHouse; }
            set { mPublishingHouse = value; }
        }public int PublicationDate
        {
            get { return mPublicationDate; }
            set { mPublicationDate = value; }
        }
        public Position()
        {

        }
        public Position(string mTitle_, int mID_, string mPublishingHouse_, int mPublicationDate_)
        {
            mTitle = mTitle_;
            mID = mID_;
            mPublishingHouse = mPublishingHouse_;
            mPublicationDate = mPublicationDate_;
        }

        public abstract void WriteOutInfo();

    }
}
