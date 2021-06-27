using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Person
    {
        protected string mName;
        protected string mLastName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }

        public Person()
        {

        }
        public Person(string mName_, string mLastName_)
        {
            mName = mName_;
            mLastName = mLastName_;
        }
    }
}
