namespace FirstProject.App.Helpers;

class Casting
{
    public static int stringToInt(string? str)
    {
        if (String.IsNullOrEmpty(str))
        {
            return 0;
        }
        return int.Parse(str);
    }



    public static float stringToFloat(string? number = "0.00")
    {
        if (string.IsNullOrEmpty(number))
        {
            return 0;
        }
        return float.Parse(number, System.Globalization.CultureInfo.InvariantCulture);
    }

    public static bool stringToBool(string? value = "false")
    {
        if (string.IsNullOrEmpty(value))
        {
            return false;
        }
        return bool.Parse(value);
    }

    public static double stringToDouble(string number = "0.00")
    {
        if (string.IsNullOrEmpty(number))
        {
            return 0;
        }
        return double.Parse(number, System.Globalization.CultureInfo.InvariantCulture);
    }

    // Converti tipi non string in string
    public static string ToString(int? number)
    {
        if (number == null)
            return 0.ToString();

        return number.Value.ToString();
    }


    public static string ToString(bool? number)
    {
        if (number == null)
            return 0.ToString();

        return number.Value.ToString();
    }

    public static string ToString(float? number)
    {
        if (number == null)
            return 0.ToString();

        return number.Value.ToString();
    }
    
      public static string ToString(dynamic? number)
    {
        if (number == null)
            return "";

        return number.Value.ToString();
    }







}
