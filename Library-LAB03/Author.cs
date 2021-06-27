using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Author : Person
    {
        //private string mName;
        //private string mLastName;
        private string mNationality;

        public string Nationality
        {
            get { return mNationality; }
            set { mNationality = value; }
        }
        //public string Name
        //{
        //    get { return mName; }
        //    set { mName = value; }
        //}public string LastName
        //{
        //    get { return mLastName; }
        //    set { mLastName = value; }
        //}
        public Author()
        {

        }
        public Author(string mName_, string mLastName_, string mNationality_)
        {
            mName = mName_;
            mLastName = mLastName_;
            mNationality = mNationality_;
        }
    }
}
