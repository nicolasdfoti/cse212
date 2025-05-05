using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
    }

    public static List<int> Interleave(List<int> list1, List<int> list2)
    {
        List<int> result = new List<int>();

        int i = 0;
        int j = 0;

        while (i < list1.Count || j < list2.Count)
        {
            if (i < list1.Count)
            {
                result.Add(list1[i]);
                i++;
            }

            if (j < list2.Count)
            {
                result.Add(list2[j]);
                j++;
            }
        }

        return result;
    }
   
}