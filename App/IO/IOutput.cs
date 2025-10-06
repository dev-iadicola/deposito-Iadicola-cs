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


    public static string Make(string question) // FIX: vecchio metodo Get richimato in Make
    {
        IOutput io = new IOutput([question]);
        return io.output[0];

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
        return Casting.stringToDouble((string)this.output[index]);
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

    // public void setResponseToIntegers()
    // {
    //     for (int i = 0; i < this.responses.Length; i++)
    //     {
    //         this.responses[i] = Casting.stringToInt((string)this.responses[i]);
    //     }
    // }

    // public void setResponseToFloats()
    // {
    //     for (int i = 0; i < this.responses.Length; i++)
    //     {
    //         this.responses[i] = Casting.stringToFloat((string)this.responses[i]);
    //     }
    // }

    // public void setResponseToDoubles()
    // {
    //     for (int i = 0; i < this.responses.Length; i++)
    //     {
    //         this.responses[i] = Casting.stringToDouble((string)this.responses[i]);
    //     }
    // }

    // public void setResponseToBooleans()
    // {
    //     for (int i = 0; i < this.responses.Length; i++)
    //     {
    //         this.responses[i] = Casting.stringToBool((string)this.responses[i]);
    //     }
    // }

    // public void setResponseToDecimals()
    // {
    //     for (int i = 0; i < this.responses.Length; i++)
    //     {
    //         this.responses[i] = ((decimal)Casting.stringToDouble((string)this.responses[i]));
    //     }
    // }




}