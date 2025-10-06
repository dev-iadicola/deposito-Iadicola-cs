#nullable disable
using System.Numerics;
using System.Text.Json.Serialization;
using System.Threading.Tasks.Dataflow;
using FirstProject.App.IO;
using Microsoft.VisualBasic;

namespace FirstProject.App.Helpers.Array;

class Dinamic<T> where T : IComparable<T>
{

    private T[] items;

    public Dinamic(int? length = null)
    {
        this.items = new T[length ?? 0];
    }

    public void Create(T[] values)
    {

        if (this.items.Length <= values.Length)
        {
            this.items = new T[this.items.Length + values.Length];
        }

        this.items = values;

    }


    public void Add(T value)
    {
        T[] oldItems = this.items; // copio i vecchi valori 

        this.items = new T[this.items.Length + 1]; // creo un nuovo array con un indice incrementato

        // popolare il nuovo array coi dati precedenti
        for (int i = 0; i < oldItems.Length; i++)
        {
            this.items[i] = oldItems[i];
        }

        this.items[this.items.Length - 1] = value; // inserisco il nuovo valore

    }


    // Aggiunge piu valori 
    public void Add(T[] values) // aggiunge piu valori
    {
        // System.Console.WriteLine("Differenza tra lunghezza tra vecchio e nuovo array");
        // System.Console.WriteLine("items lunghezza: " + this.items.Length);
        // System.Console.WriteLine("nuovi valori lunghezza: " + values.Length);

        T[] newArray = new T[this.items.Length + values.Length];
        // System.Console.WriteLine("Lunghezza Nuovo array: " + newArray.Length);

        //inizio a popolare l'antenato
        for (int j = 0; j < this.items.Length; j++)
        {
            newArray[j] = this.items[j];
            //System.Console.WriteLine("Indice del ciclo popolamento items: " + j);
        }

        // inizio a popolare coi nuovi dati
        int index = 0;
        for (int i = items.Length; i < newArray.Length; i++)
        {
            newArray[i] = values[index++];
        }

        this.items = newArray;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= this.items.Length) throw new IndexOutOfRangeException();
        return items[index];
    }


    public void Unset(int index)
    {
        if (index < 0 || index >= this.items.Length)
            throw new IndexOutOfRangeException();

        T[] newArray = new T[this.items.Length - 1];
        int newPos = 0;

        for (int i = 0; i < this.items.Length; i++)
        {
            if (i == index) continue; // salto l'elemento da rimuovere

            newArray[newPos] = this.items[i];
            newPos++;
        }

        this.items = newArray;
    }



    public void UnsetByValue(T value)
    {
        if (this.items.Length == 0) throw new NullReferenceException("L'array è vuoto, impossibile rimuovere un lemento in un array vuoto.");

        if (!ValueExist(value))
        {
            throw new Exception($"Il valore {value} non è stato trovato nell'array");
        }
        int occurrences = 0;
        foreach (T item in this.items)
        {
            if (item.Equals(value))
            {
                occurrences++;
            }
        }
        // Creo un nuovo array con la lughezza minore di quante occorrenze del valore da rimuovere;
        T[] newArray = new T[this.items.Length - occurrences];
        int newIndex = 0;

        //  System.Console.WriteLine("dentro ciclo");

        for (int i = 0; i < this.items.Length; i++)
        {
            if (items[i].Equals(value)) continue; // ignora elemento uguale e continua il ciclo

            newArray[newIndex] = this.items[i];
            //  System.Console.WriteLine("new: "+newArray[newIndex]);
            //  System.Console.WriteLine("items: "+this.items[i]);

            newIndex++;

        }
        //  System.Console.WriteLine("Fuori ciclo");

        this.items = newArray;
    }

    public void RemoveDuplicate()
    {
        Dinamic<T> valueToRemoveAndAdd = new Dinamic<T>();



        for (int i = 0; i < this.items.Length; i++)
        {
            for (int j = 0; j < this.items.Length; j++)
            {
                if (this.items[i].Equals(this.items[j]))
                {
                    if (!valueToRemoveAndAdd.ValueExist(this.items[i]))
                    {
                        valueToRemoveAndAdd.Add(this.items[i]);
                    }
                }
            }
        }


        // System.Console.WriteLine("Valori da rimuovere e aggiungere");
        // valueToRemoveAndAdd.Print();
        // System.Console.WriteLine("Fine valori da rimuovere e aggiungere");


        foreach (T valore in valueToRemoveAndAdd.All())
        {
            this.UnsetByValue(valore); // rimuovo il valore duplicato
            if (!this.ValueExist(valore))
            {
                this.Add(valore); // lo riaggiungo una volta sola
            }

        }
    }


    public bool ValueExist(T value)
    {

        foreach (T item in this.items)
        {
            if (item.Equals(value))
            {
                return true;
            }
        }

        return false;
    }

    public T[] All()
    {
        return items;
    }

    // Al momento è solo numerico !
    public void Sort()
    {
        for (int i = 0; i < this.items.Length; i++)
        {
            for (int k = 0; k < this.items.Length; k++)
            {
                if (items[k].CompareTo(items[i]) > 0)
                {
                    T max = this.items[i];
                    T min = this.items[k];

                    this.items[i] = min;
                    this.items[k] = max;
                }
            }
        }
    }

    public void SortRevert()
    {
        for (int i = 0; i < this.items.Length; i++)
        {
            for (int k = 0; k < this.items.Length; k++)
            {
                if (items[k].CompareTo(items[i]) < 0)
                {

                    T max = this.items[i];
                    T min = this.items[k];

                    this.items[i] = min;
                    this.items[k] = max;
                }
            }
        }
    }

    // STAMPA
    public void PrintLine()
    {
        foreach (T item in items)
        {
            InputSystem.printLine(item.ToString());
        }
    }

    public void PrintLine(int index)
    {
        InputSystem.printLine(this.Get(index).ToString());
    }

    public void Print(int index) {
        InputSystem.print(this.Get(index).ToString());
    }

    

   



}
