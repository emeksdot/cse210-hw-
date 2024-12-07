using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class WrtingAssignment : Assignment
{
        private string _title;

        public WrtingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;            
        }

        //_________Title_____
        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string title)
        {
            _title = title;
        }

        //__________Methods____________
        public string GetWritingInformation()
        {
            return $"{GetTitle()}";
        }


    
}