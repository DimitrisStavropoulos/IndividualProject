using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Student
    {
        private string _firstname;
        private string _lastname;
        private DateTime _dateofbirth;
        private double _tuitionfees;

        public double Tuitionfees
        {
            get { return _tuitionfees; }
            set { _tuitionfees = value; }
        }

        public DateTime Dateofbirth
        {
            get { return _dateofbirth; }
            set { _dateofbirth = value; }
        }


        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }


        public string FirstName
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public override string ToString()
        {
            return ($"First Name: {_firstname}\t Last Name: {_lastname}\t Date of birth: {_dateofbirth}\t Tuition fees: {_tuitionfees}");
        }

    }
}
