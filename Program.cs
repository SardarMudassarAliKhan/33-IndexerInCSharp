using System;

class SampleCollection
{
    private int[] arr = new int[10];

    // Define the indexer, which allows client code to use [] notation.
    public int this[int index]
    {
        get
        {
            if(index < 0 || index >= arr.Length)
                throw new IndexOutOfRangeException("Index out of range.");
            return arr[index];
        }
        set
        {
            if(index < 0 || index >= arr.Length)
                throw new IndexOutOfRangeException("Index out of range.");
            arr[index] = value;
        }
    }
}

class Program
{
    static void Main()
    {
        SampleCollection collection = new SampleCollection();

        // Set values using the indexer.
        collection[0] = 10;
        collection[1] = 20;
        collection[2] = 30;

        // Retrieve values using the indexer.
        Console.WriteLine(collection[0]); // Output: 10
        Console.WriteLine(collection[1]); // Output: 20
        Console.WriteLine(collection[2]); // Output: 30

        // Using the indexer outside the class
        int valueAtIndex2 = collection[2];
        Console.WriteLine(valueAtIndex2); // Output: 30

        collection[3] = 40;
        Console.WriteLine(collection[3]); // Output: 40
    }
}
