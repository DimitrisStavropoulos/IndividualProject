using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.Models
{
    class Course
    {
        private string _title;
        private string _stream;
        private string _type;
        private DateTime _start_date;
        private DateTime _end_date;

        public DateTime EndDate
        {
            get { return _end_date; }
            set { _end_date = value; }
        }


        public DateTime StartDate
        {
            get { return _start_date; }
            set { _start_date = value; }
        }


        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Stream
        {
            get { return _stream; }
            set { _stream = value; }
        }


        public string Title

        {
            get { return _title; }
            set { _title = value; }
        }

        public override string ToString()
        {
            return ($"Title: {_title}\t Stream: {_stream}\t Type: {_type}\t Start Date: {_start_date}\t End Date {_end_date}");
        }
    }
}
