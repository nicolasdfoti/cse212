using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

    }

    public int SumCubesRecursive(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        else
        {
            int cubes = SumCubesRecursive(n - 1) + (n * n * n);
            return cubes;
        }
    }
}