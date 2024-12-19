using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return Convert.ToDouble(_laps) * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetDuration() / 60);
    }

    public override double GetPace()
    {
        return 60.0 / GetSpeed();
    }

    public override string GetSummary()
    {
        return $"{DateTime.Now.ToString("dd MMM yyyy")} Swimming ({GetDuration()} min)- Distance {GetDistance()} km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    }
}
