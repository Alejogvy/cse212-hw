public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: First we create an array of type double with a length of 'length'
        double[] multiples = new double[length];

        // Step 2: Let's use a loop to fill the array with the multiples
        for (int i = 0; i < length; i++)
        {
            // Here the multiple 'i+1' of 'number' is 'number * (i + 1)'
            multiples[i] = number * (i + 1);
        }

        // Step 3: Finally we return the array with the generated multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: We make sure that amount is not greater than the size of the list we make
        // For this we are going to use the modulo operator to handle rotations greater than the size of the list
        amount = amount % data.Count;

        // Step 2: If the list has more than one element and amount is greater than 0, we rotate the list
        if (amount > 0)
        {
            // In this part we separate the list into two parts
            List<int> lastPart = data.GetRange(data.Count - amount, amount);
            List<int> firstPart = data.GetRange(0, data.Count - amount);

            // Step 3: We replace the original list with the concatenation of the two parts
            data.Clear();
            data.AddRange(lastPart);
            data.AddRange(firstPart);
        }
    }
}
