using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;        
    }

    //_____________Text Book Section____________
    public string GetTextBookSection()
    {
        return _textbookSection;
    }
    public void SetTextBookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    //_____________Problems_____________
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    //__________Methods_____________
    public string GetHomeworkList()
    {
        return $"{GetTextBookSection()}  {GetProblems()}";
    }
    
}