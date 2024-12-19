using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }

    public override string GetSummary()
    {
        return 
            $"{DateTime.Now.ToString("dd MMM yyyy")} Running ({GetDuration()} min)- Distance {GetDistance()} km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km"
        ;
    }
}
