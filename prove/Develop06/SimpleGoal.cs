using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class SimpleGoal : Goal
{ // Field specific to SimpleGoal
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // ______________ IsComplete__________
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    // ___________ IsComplete__________
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    //_______Methods_________
    public override void RecordEvent()
    {

    }
    public override void IsComplete()
    {

    }
    public override void GetStringRepresentation()
    {

    }
}
