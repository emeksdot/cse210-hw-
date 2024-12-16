using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Goal
{
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public string GetDetailsString()
    {
        return "Returns a string.";
    }
    public abstract string GetStringRepresentation();

}