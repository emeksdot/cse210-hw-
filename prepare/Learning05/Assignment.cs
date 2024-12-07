using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;        
    }

    //_________Student Name_________
    public string GetStudentName()
    {
        return _studentName;
    }
    public void SetStudentName(string name)
    {
        _studentName = name;
    }

    //______________Topic___________
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }


    //_________Methods________________
    public string GetSummary()
    {
        return $"{GetStudentName()} - {GetTopic()}";
    }
    
}