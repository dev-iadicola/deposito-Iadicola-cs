namespace FirstProject.App.Helpers.Numeric;

class InternRandom
{
    private static Random _random = new Random();

    public static int Next(int min, int max)
    {
        return _random.Next(min, max);
    }


    public static float NextFloat(float min, float max)
    {
        double range = max - min;
        double sample = _random.NextDouble();
        double scaled = (sample * range) + min;
        return (float)scaled;
    }
}