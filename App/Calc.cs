using System.ComponentModel;
using FirstProject.App.Helpers;

namespace FirstProject.App;

public class Calc
{
    public static dynamic sum(dynamic a, dynamic b)
    {
        return a + b;
    }
    public static float sum(int a, float b)
    {
        return a + b;
    }

    public static dynamic discount(float price, float percentage)
    {
        while (price <= 0 || percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Inserisci un prezzo positivo e una percentuale tra 0 e 100");
            price = Casting.stringToFloat(Console.ReadLine());
        }
        return price * (100 - percentage) / 100;
    }

    public static float BMI(float kg, float h)
    {
        return kg / (h * h);
    }

    public static int agv(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
    public static float agv(float[] numbers)
    {
        float sum = 0.00f;
        foreach (float number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }

    public static bool isPositiveFloat(float number)
    {
        return number > 0;
    }

    public static bool isMajorThan(int a, int b)
    {
        return a > b;
    }

    public static bool isMajorThan(dynamic a, dynamic b)
    {
        return a > b;
    }

    public static int[] tabellaMoltiplicazioni(int num, int multiplicate)
    {
        int[] tabella = new int[multiplicate];
        for (int i = 0; i < multiplicate; i++)
        {
            tabella[i] = num * (i + 1);
        }

        return tabella;
    }

    public static int max(int[] numbers)
    {
        int max = 0;
        foreach (int num in numbers)
        {
            if (max < num)
            {
                max = num;
            }
        }

        return max;
    }
    
    public static float max(float[] numbers)
    {
        float max = 0;
        foreach (float num in numbers)
        {
            if (max < num)
            {
                max = num;
            }
        }

        return max;
    }

    public static int min(int[] numbers)
    {
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > min)
            {
                min = num;
            }
        }
        return min;
    }
    public static float min(float[] numbers)
    {
        float min = numbers[0];

        // Foreach per prendere il numero più alto. 
        foreach (float num in numbers)
        {
            if (min > num)
            {
                min = num;
            }
        }

       
        return min;
    }




}