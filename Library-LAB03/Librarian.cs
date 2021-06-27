using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_LAB03
{
    public class Librarian : Person
    {
        private string mDateOfEmployment;
        private double mPayment;

        public string DateOfEmployment
        {
            get { return mDateOfEmployment; }
            set { mDateOfEmployment = value; }
        }
        public double Payment
        {
            get { return mPayment; }
            set { mPayment = value; }
        }
        public Librarian()
        {

        }
        public Librarian(string mName_, string mLastName_, string mDateOfEmployment_, double mPayment_)
        {
            Name = mName_;
            LastName = mLastName_;
            DateOfEmployment = mDateOfEmployment_;
            Payment = mPayment_;
        }
    }
}
