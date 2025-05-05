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

        // 1) Create an empty array of doubles with the size of "length".
        // 2) Use a for loop to iterate through the array, creating a variable to hold the index.
        // 3) In every iteration, multiply the current number by the index + 1, and store the result in the array.
        // 4) Return the array.

        var numbers = new double[length];

        for (int i = 0; i < length; i++)
        {
            numbers[i] = number * (i + 1);
        }

        return numbers; // replace this return statement with your own
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

        // 1) Create an empty list to hold the last "amount" numbers from the original list.
        // 2) Use a for loop to iterate the original list. It should start from the data.Count - amount to the end of the list.
        // 3) Add the elements from the original list to the new list.
        // 4) Outside the loop, remove the "amount" range from the original list.
        // 5) Lastly, insert the range of numbers from the new list to index 0 in the original list.

        List<int> lastElements = new List<int>();

        for (int i = data.Count - amount; i < data.Count; i++)
        {
            lastElements.Add(data[i]);
        }

        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, lastElements);
    }
}