using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class EternalGoal : Goal
{ // Constructor
    public EternalGoal(string name, string description, string points)
        : base(name, description, points) { }

    //_________Methods_________
    public override void RecordEvent() { }

    public override void IsComplete() { }

    public override void GetStringRepresentation() { }
}
