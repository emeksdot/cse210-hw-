using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Biking : Activity
{
    private double _speed;

    public Biking(DateTime date, int duration, double speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (Convert.ToDouble(GetDuration()) / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{DateTime.Now.ToString("dd MMM yyyy")} Biking ({GetDuration()} min)- Distance {GetDistance()} km, Speed: {GetSpeed()}kph, Pace: {GetPace()} min per km";
    }
}
