using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Goal
{
    // Private fields
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // _________ ShortName ____________
    public string GetShortName()
    {
        return _shortName;
    }
    public void SetShortName(string name)
    {
        _shortName = name;
    }

    // _________ Description __________
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    // ________ Points _________
    public string GetPoints()
    {
        return _points;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }
}
