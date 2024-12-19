using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CheckListGoal : Goal
{ // Fields specific to CheckListGoal
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public CheckListGoal(
        string name,
        string description,
        string points,
        int target,
        int bonus
    )
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Accessor (getter) for _amountCompleted
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    // Mutator (setter) for _amountCompleted
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    // Accessor (getter) for _target
    public int GetTarget()
    {
        return _target;
    }

    // Mutator (setter) for _target
    public void SetTarget(int target)
    {
        _target = target;
    }

    // Accessor (getter) for _bonus
    public int GetBonus()
    {
        return _bonus;
    }

    // Mutator (setter) for _bonus
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    //____ Methods___________
    public override void RecordEvent() { }

    public override void IsComplete() { }

    public override void GetStringRepresentation() { }

    public override void GetDetailsString() { }
}
