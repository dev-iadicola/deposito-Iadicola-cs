#nullable disable
namespace FirstProject.App.IO;

using FirstProject.App.Helpers;
class IOutput
{

    public string[] output;

    // public int[] IntResponses;



    // public bool[] boolResponses;

    // public decimal[] decimalResponses;



    public IOutput(string[] questions = null)
    {
        this.output = InputSystem.GenerateIO(questions ?? new string[] { "" });
    }

    public static T Make<T>(string question)
    {
        IOutput io = new IOutput([question]);

        object value;

        if (typeof(T) == typeof(int))
            value = io.GetInt(0);
        else if (typeof(T) == typeof(float))
            value = io.GetFloat(0);
        else if (typeof(T) == typeof(double))
            value = io.GetDouble(0);
        else if (typeof(T) == typeof(decimal))
            value = io.GetDecimal(0);
        else if (typeof(T) == typeof(string))
            value = io.output[0];
        else
            throw new NotSupportedException($"Il tipo {typeof(T).Name} non è supportato.");

        return (T)Convert.ChangeType(value, typeof(T));
    }


    public static string Make(string question) // FIX: vecchio metodo Get richimato in Make
    {
        IOutput io = new IOutput([question]);
        return io.output[0];

    }

    public static double MakeDoble(string question)
    {
        IOutput io = new IOutput([question]);

        return io.GetDouble(0);
    }

    public static int GetInt(string question)
    {
        IOutput io = new IOutput([question]);
        return io.GetInt(0);
    }
    public string Get(int index)
    {
        return this.output[index];
    }

    public object[] All()
    {
        return this.output;
    }

    public string[] AllString()
    {
        return this.output;
    }


    public int GetInt(int index)
    {
        return (int)Casting.stringToInt((string)this.output[index]);
    }
    public float GetFloat(int index)
    {
        return Casting.stringToFloat((string)this.output[index]);
    }

    public bool GetBool(int index)
    {
        return Casting.stringToBool((string)this.output[index]);
    }

    public decimal GetDecimal(int index)
    {
        return (decimal)Casting.stringToDouble((string)this.output[index]);
    }

    public double GetDouble(int index)
    {
        return (double)Casting.stringToDouble((string)this.output[index]);
    }
    public int getSize()
    {
        return this.output.Length;
    }

    public float[] AllFloat()
    {
        float[] floatOutPut = new float[this.All().Length];
        for (int i = 0; i < this.All().Length; i++)
        {
            floatOutPut[i] = this.GetFloat(i);
        }

        return floatOutPut;
    }

    public int[] AllInt()
    {

        int[] intO = new int[this.All().Length];
        for (int i = 0; i < this.All().Length; i++)
        {
            intO[i] = this.GetInt(i);
        }
        return intO;
    }




}